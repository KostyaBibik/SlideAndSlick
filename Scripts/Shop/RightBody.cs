using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBody : MonoBehaviour
{
    public GameObject[] bodys;
    void Start()
    {

        for (int i = 0; i < bodys.Length; i++)
        {
            if (PlayerPrefs.GetString("Now Body") == bodys[i].name)
            {
                GetComponent<SpriteRenderer>().sprite = bodys[i].GetComponent<SpriteRenderer>().sprite;
                break;
            }
        }
    }

   
}
