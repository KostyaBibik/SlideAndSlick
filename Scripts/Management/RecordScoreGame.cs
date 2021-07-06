using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecordScoreGame : MonoBehaviour
{
    private Text txt;
    public void Start()
    {
        txt = GetComponent<Text>();
        txt.text = "Record: " + PlayerPrefs.GetInt("HighScore");
        StartCoroutine(ShowRecord());
    }
    void Update()
    {

        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
        {
            txt.text = "Record: " + PlayerPrefs.GetInt("HighScore");
        }
    }

    IEnumerator ShowRecord()
    {
        while (true)
        {
            txt.enabled = !txt.enabled;
            //gameObject.SetActive(!gameObject.activeSelf);
            if(!txt.enabled)
                yield return new WaitForSecondsRealtime(Random.Range(25, 40));
            else
                yield return new WaitForSecondsRealtime(Random.Range(3, 6));
        }
    }
}
