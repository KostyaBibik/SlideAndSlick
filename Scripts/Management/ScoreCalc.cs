using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCalc : MonoBehaviour
{
    private Text txt;
    void Start()
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins"));
        txt = GetComponent<Text>();
        StartCoroutine(UpdateScore());
    }
    IEnumerator UpdateScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins"));
        }
    }
    private void FixedUpdate()
    {
        txt.text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
