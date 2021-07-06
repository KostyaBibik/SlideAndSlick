using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNowCap : MonoBehaviour
{
    public GameObject whichCap;
    public GameObject CapPlayer;
    public GameObject Player;



    public void Start()
    {
        
    }
    public void SelectBodyPress()
    {

        if (Player)
        {
            CapPlayer.GetComponent<SpriteRenderer>().sprite = GameObject.Find(whichCap.GetComponent<SelectCap>().nowCap).GetComponent<SpriteRenderer>().sprite;



            if (whichCap.GetComponent<SelectCap>().nowCap == "Cap2")
            {
                CapPlayer.transform.localPosition = new Vector3(0.063f, 1f, 0f);
                CapPlayer.transform.localScale = new Vector3(1.2f, 1.5f, 0.9f);
            }
            else
            {
                CapPlayer.transform.localScale = new Vector3(0.9069359f, 0.9069359f, 0.9069359f);
                CapPlayer.transform.localPosition = new Vector3(0f, 1.31f, 0f);
                
            }


        }
        PlayerPrefs.SetString("Now Cap", whichCap.GetComponent<SelectCap>().nowCap);


    }
}
