using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNowBody : MonoBehaviour
{
    public GameObject whichBody;
    public GameObject BodyPlayer;
    public GameObject Player;



    public void Start()
    {
        //if (Player)
        //{
        //    BodyPlayer.GetComponent<SpriteRenderer>().sprite = GameObject.Find(whichBody.GetComponent<SelectBody>().nowBody).GetComponent<SpriteRenderer>().sprite;
        //}
        //PlayerPrefs.SetString("Now Body", whichBody.GetComponent<SelectBody>().nowBody);
    }
    public void SelectBodyPress()
    {

        if (Player)
        {
            BodyPlayer.GetComponent<SpriteRenderer>().sprite = GameObject.Find(whichBody.GetComponent<SelectBody>().nowBody).GetComponent<SpriteRenderer>().sprite;
        }
        PlayerPrefs.SetString("Now Body", whichBody.GetComponent<SelectBody>().nowBody);
        
        
    }
}
