using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.Monetization;
using UnityEngine.Advertisements;
public class ContinuePlayADV : MonoBehaviour
{
    public GameObject Pause;
    public GameObject MainCamera;

    public GameObject Player;
    public GameObject Score;
    public GameObject ScoreTXT;
    public GameObject Lifes;
    public GameObject Heart1;
    public GameObject GameOverMenu;
    public GameObject CoinImage;

    [System.Obsolete]
    void Awake()
    {
        //if (Advertisement.isSupported)
        //{
        //    print("SUP");
           Advertisement.Initialize("4059909", true);
        Advertisement.Show();
        print("sfasaf" + Advertisement.isSupported);
        //}

        //if (Monetization.isSupported)
        //{
        //    Monetization.Initialize("4059909", false);
        //}
    }

    //[System.Obsolete]
    public void showADV()
    {
        //if (Advertisement.IsReady())
        //{
        //    print("ADV");
        //    Advertisement.Show("Rewarded video");
        //}

        //if (Monetization.IsReady("Reward"))
        //{
        //    ShowAdCallbacks options = new ShowAdCallbacks();
        //    options.finishCallback = HandleShowResults;
        //    ShowAdPlacementContent ad = Monetization.GetPlacementContent("Reward") as ShowAdPlacementContent;
        //    ad.Show(options);

            //print("ADV");
            Advertisement.Show();
        print(Advertisement.GetPlacementState());
        Destroy(gameObject);
        //}
    }

    void HandleShowResults(ShowResult result)
    {
        if(result == ShowResult.Finished)
        {
            print("ads finished");
            Pause.GetComponent<Pausebutton>().Resume();
            Player.SetActive(true);
            Score.SetActive(true);
            ScoreTXT.GetComponent<Text>().enabled = true;
            Lifes.SetActive(true);
            MainCamera.GetComponent<DifficultLvl>().continueAfterDead();
            Heart1.SetActive(true);
            GameOverMenu.SetActive(false);
            Player.GetComponent<ManageHero>().Continue();
            gameObject.GetComponent<DeleteSpawnerChild>().DeleteChilds();
            Score.GetComponent<CalcScoreGame>().StartCor();
            CoinImage.GetComponent<Animator>().Play("CoinScore");
        }


        if (result == ShowResult.Skipped)
        {
            print("ads skipped");
            SceneManager.LoadScene("NewGameObj");
        }


        if (result == ShowResult.Failed)
        {
            print("ads failed");
            SceneManager.LoadScene("NewGameObj");
        }
    }
}
