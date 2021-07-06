using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecordScore : MonoBehaviour
{
    private Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = "Record: " + PlayerPrefs.GetInt("HighScore");
    }

    
    void Update()
    {
        if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
        { 
            txt.text = "Record: " + PlayerPrefs.GetInt("HighScore");
        }
    }
}
