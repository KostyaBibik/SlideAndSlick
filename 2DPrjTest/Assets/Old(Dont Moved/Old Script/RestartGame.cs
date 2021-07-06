using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public Text Finalscore;
   // public ScoreManager sm;
    void Start()
    {
        Finalscore.text = "Your score: " + PlayerPrefs.GetInt("Coins").ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
