using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksScript : MonoBehaviour
{
    [SerializeField]
    private GameObject thanks;
    void Start()
    {
        
        if(PlayerPrefs.GetInt("Thanks") != 1)
        {           
            thanks.SetActive(true);
            PlayerPrefs.SetInt("Thanks", 1);
        }
    }

    public void GiveBonus()
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1400);
    }
}
