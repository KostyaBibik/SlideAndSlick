using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    public bool LifeHero, lifeAffected;
    private bool started_coroutine;
    public SpriteRenderer ColorBody;
    public Animation DamageAnim;
    private Color color;

    public GameObject effectSpikes;
    public GameObject effectCoin;

    public GameObject panel;
    public GameObject scoreText;
    public GameObject soundSpike;
    public GameObject soundCoin;
    private Animator camAnim;
    private GameObject soundForDel;

    void Start()
    {
        camAnim = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<Animator>();        
        LifeHero = true;
        lifeAffected = false;
        started_coroutine = false;
        Time.timeScale = 1f;
    }
    private void OnTriggerEnter(Collider other)
    {
        DamageAnim.clip = GetComponent<Animation>().GetClip("damageOnHero");
        if (other.tag == "spike")
        {
            soundForDel = Instantiate(soundSpike, transform.position, Quaternion.identity);
            StartCoroutine(deleteSound());
            Instantiate(effectSpikes, other.transform.position, Quaternion.identity);
            
            if (lifeAffected)
            {
                scoreText.SetActive(false);
                panel.SetActive(true);
                Destroy(gameObject);
                print("Game over");
                Time.timeScale = 0.2f;
                LifeHero = false;                
            }
            if (!lifeAffected)
            {
                GetComponent<Animation>().Play("damageOnHero");

                if (!started_coroutine)
                {
                    StartCoroutine(TimeToBackLife());
                    started_coroutine = true;
                }
                lifeAffected = true;
            }//////////////////////////////////////////////////////////////////////////////////////////////////
            print("damage");
            Destroy(other.gameObject);
        }
        if (other.tag == "coin")
        {
            Instantiate(effectCoin, other.transform.position, Quaternion.identity);
            soundForDel = Instantiate(soundCoin, transform.position, Quaternion.identity);
            StartCoroutine(deleteSound());
            print("coin");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            Destroy(other.gameObject);
        }
    }

    IEnumerator TimeToBackLife()
    {
        yield return new WaitForSeconds(3f);
        if (LifeHero) 
        { 
            lifeAffected = false;
            print("life!");
            color = new Vector4(ColorBody.color.r,ColorBody.color.g,ColorBody.color.b, 50f);
            ColorBody.color = color;
        }
        started_coroutine = false;
    }

    IEnumerator deleteSound()
    {
        yield return new WaitForSeconds(1f);
        Destroy(soundForDel);
    }

    void FixedUpdate()
    {
        if (lifeAffected)
        {
            GetComponent<Animation>().Play("damageOnHero");
        }
    }
}
