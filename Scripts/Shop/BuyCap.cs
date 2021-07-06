using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyCap : MonoBehaviour
{
    public GameObject selectBTN;
    public GameObject whichCap;
    public GameObject CapPlayer;
    public GameObject priceCap;


    public void BuyBodyPress()
    {
        if (PlayerPrefs.GetInt("Coins") >= int.Parse(priceCap.GetComponent<Text>().text))
        {
            print(PlayerPrefs.GetInt(whichCap.GetComponent<SelectCap>().nowCap));

            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(priceCap.GetComponent<Text>().text));

            PlayerPrefs.SetString(whichCap.GetComponent<SelectCap>().nowCap, "Open");

            PlayerPrefs.SetString("Now Cap", whichCap.GetComponent<SelectCap>().nowCap);

            CapPlayer.GetComponent<SpriteRenderer>().sprite = GameObject.Find(whichCap.GetComponent<SelectCap>().nowCap).GetComponent<SpriteRenderer>().sprite;
            selectBTN.SetActive(true);
            gameObject.SetActive(false);


        }
    }
}
