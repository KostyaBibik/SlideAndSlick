using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManageHero : MonoBehaviour
{
    public bool LifeHero, lifeAffected;
    private bool started_coroutine;
    public SpriteRenderer ColorBody;
    private Color color;
    private Animator animator;

    public float minX, maxX;

    public GameObject scoreText;
    public GameObject scoreCoin;
    public GameObject FinalScore;
    public GameObject gameOverMenu;

    public GameObject imageCoins;

    public GameObject effectCoin, effectSpike;
    public GameObject pauseButton;
    public GameObject ContinueADV;
    public GameObject ContinueTXT;
    public bool isContinue = false;

    public GameObject shootBTN;

    public GameObject[] lifes;

    public GameObject soundCoin;
    public GameObject soundSpike;
    public GameObject soundHeart;
    public GameObject soundBG;

    public GameObject enemy1;
    private Animator camAnim;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "spike")
        {
            camAnim.SetTrigger("shake");
            Instantiate(soundSpike, transform.position, Quaternion.identity);
            Instantiate(effectSpike, transform.position, Quaternion.identity);
            animator.SetTrigger("Damage");
            Destroy(other.gameObject);
            print("Damage!");
            if (lifes[3].gameObject.activeSelf)
            {
                lifes[3].gameObject.SetActive(false);
                lifeAffected = true;
            }
            else if (lifes[2].gameObject.activeSelf)
            {
                lifes[2].gameObject.SetActive(false);
                lifeAffected = true;
            }
            else if (lifes[1].gameObject.activeSelf)
            {
                lifes[1].gameObject.SetActive(false);
            }
            else 
            {
                lifes[0].gameObject.SetActive(false);
                //GetComponent<DifficultLvl>().saveSpeedIncrease = GetComponent<DifficultLvl>().speedIncrease;
                //GetComponent<DifficultLvl>().saveTimeSpeed = Time.timeScale;




                //if (isContinue)
                //{
                //    ContinueTXT.SetActive(false);
                //    ContinueADV.SetActive(false);
                //}
                if (enemy1.activeSelf)
                    enemy1.SetActive(false);
                if (shootBTN.activeSelf)
                    shootBTN.SetActive(false);

                pauseButton.SetActive(false);
                scoreText.SetActive(false);
                gameObject.SetActive(false);
                print("Game over");
                Time.timeScale = 0.2f;
                LifeHero = false;
                gameOverMenu.SetActive(true);
                FinalScore.GetComponent<Text>().text = ("Score: " + PlayerPrefs.GetInt("Score"));
                imageCoins.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
                imageCoins.GetComponent<Animator>().enabled = false;
                GameObject.Find("Main Camera").GetComponent<DifficultLvl>().StopAllCoroutines();
                soundBG.gameObject.SetActive(false);
            }
            
        }

        if(other.tag == "heart")
        {
            Instantiate(soundHeart, transform.position, Quaternion.identity);
            if (!lifes[1].gameObject.activeSelf)
                lifes[1].SetActive(true);
            else if(!lifes[2].gameObject.activeSelf)
                lifes[2].SetActive(true);
            else
                lifes[3].SetActive(true);
            Destroy(other.gameObject);
            print("life!");
        }

        if(other.tag == "coin")
        {
            Instantiate(soundCoin, transform.position, Quaternion.identity);
            Instantiate(effectCoin, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 25);
            StopCoroutine(CoinScoreShow());
            StartCoroutine(CoinScoreShow());
            Destroy(other.gameObject);
            print("Coin!");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        }
    }

    //IEnumerator TimeToBackLife()
    //{
    //    yield return new WaitForSeconds(3f);
    //    if (LifeHero)
    //    {
    //        lifeAffected = false;
    //        print("life!");
    //        color = new Vector4(ColorBody.color.r, ColorBody.color.g, ColorBody.color.b, 255f);
    //        ColorBody.color = color;
    //    }
    //    started_coroutine = false;
    //}
    public void Continue()
    {
        isContinue = true;
    }

    public void Start()
    {
        //ContinueTXT.SetActive(true);
        //ContinueADV.SetActive(true);
        isContinue = false;  
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        Time.timeScale = 1f;
        animator = GetComponent<Animator>();
    }



    public void Invisible()
    {
        print("chao");
        var child = transform.GetComponentsInChildren<SpriteRenderer>();
        foreach (var part in child)
        {
            var colorPart = new Vector4(part.color.r, part.color.g, part.color.b, 50f);
            part.color = colorPart;
        }

    }


    
    
    IEnumerator CoinScoreShow()
    {
        scoreCoin.SetActive(true);
        yield return new WaitForSeconds(5f);
        scoreCoin.SetActive(false);
    }
    //void FixedUpdate()
    //{
    //    if(GetComponent<RectTransform>().position.x != minX || GetComponent<RectTransform>().position.x != maxX)
    //    {
    //        animator.SetBool("Moved", true);
    //        //StartCoroutine(AnimMoved());
    //    }
    //    else
    //        animator.SetBool("Moved", false);
    //}

    //IEnumerator AnimMoved()
    //{   
    //    animator.SetTrigger("Moved");
    //    yield return new WaitForSeconds(1f);
    //}
}
