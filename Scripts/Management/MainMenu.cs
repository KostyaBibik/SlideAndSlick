using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   
    void Start()
    {
        if (PlayerPrefs.GetString("IsSound") == "false")
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
    }
    public void PressBTN()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("NewGameObj");
    }
}
