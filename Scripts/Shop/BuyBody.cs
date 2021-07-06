using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyBody : MonoBehaviour
{
    public GameObject selectBTN;
    public GameObject whichBody;
    public GameObject BodyPlayer;
    public GameObject priceBody;

    
    public void BuyBodyPress()
    {
        if (PlayerPrefs.GetInt("Coins") >= int.Parse(priceBody.GetComponent<Text>().text))
        {
            print(PlayerPrefs.GetInt(whichBody.GetComponent<SelectBody>().nowBody));

            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(priceBody.GetComponent<Text>().text));

            PlayerPrefs.SetString(whichBody.GetComponent<SelectBody>().nowBody, "Open");
            
            PlayerPrefs.SetString("Now Body", whichBody.GetComponent<SelectBody>().nowBody);
            BodyPlayer.GetComponent<SpriteRenderer>().sprite = GameObject.Find(whichBody.GetComponent<SelectBody>().nowBody).GetComponent<SpriteRenderer>().sprite;
            selectBTN.SetActive(true);
            gameObject.SetActive(false);

            
        }        
    }

}
