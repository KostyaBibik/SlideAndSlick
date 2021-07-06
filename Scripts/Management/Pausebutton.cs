using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausebutton : MonoBehaviour
{
    public static bool gameIsPause = false;
    public GameObject pauseMenuUI;
    

    public void OnMouseDown()
    {
        if (gameIsPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
   

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        gameIsPause = true;
        gameObject.SetActive(false);
    }

    public void Resume()
    {        
        gameObject.SetActive(true);        
        gameIsPause = false;
        pauseMenuUI.SetActive(false);
        //Time.timeScale = GameObject.Find("MainCamera").GetComponent<DifficultLvl>().saveSpeedIncrease;

    }

    public void LoadMenu()
    {
        Debug.Log("load");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {   
        Debug.Log("load");
        Application.Quit();
    }


    
}
