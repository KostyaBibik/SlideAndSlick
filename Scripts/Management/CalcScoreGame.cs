using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalcScoreGame : MonoBehaviour
{
    private Text txt;
    public float waitingTime;
    public GameObject enemy1;

    public void Start()
    {
        waitingTime = 1.444f;
        PlayerPrefs.SetInt("Score", 0);
        txt = GetComponent<Text>();
        StartCoroutine(UpdateScore());
    }
    public void StartCor()
    {
        StartCoroutine(UpdateScore());
    }

    public void restart()
    {
        PlayerPrefs.SetInt("Score", 0);
        waitingTime = 1.444f;
    }
    public void ActiveText()
    {
        GetComponent<Text>().gameObject.SetActive(true);
        waitingTime = 1.444f;
    }
    public IEnumerator UpdateScore()
    {
        while (true)     //(GameObject.Find("Player").GetComponent<GameManage>().LifeHero)
        {
            yield return new WaitForSeconds(waitingTime);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 10);
        }
    }
    private void FixedUpdate()
    {
        if (enemy1.activeSelf)
            waitingTime = 2f;
        else
            waitingTime = 1.444f;


        if (gameObject.activeSelf)
        {
            txt.text = "Score " + PlayerPrefs.GetInt("Score").ToString();
            if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score")); 
            }
        }
    }
}
