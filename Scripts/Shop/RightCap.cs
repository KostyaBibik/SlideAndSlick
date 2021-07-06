using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCap : MonoBehaviour
{
    public GameObject[] caps;
    public GameObject whichCap;
    public GameObject CapPlayer;
    public void Start()
    {


        if (PlayerPrefs.GetString("Now Cap") == "Cap5")
        {
            CapPlayer.transform.localPosition = new Vector3(0, -0.04f, 0f);
            CapPlayer.transform.localScale = new Vector3(0.7142121f, 0.74f, 0.9f);
        }
        else if (PlayerPrefs.GetString("Now Cap") == "Cap2")
        {
            CapPlayer.transform.localPosition = new Vector3(0.063f, 1f, 0f);
            CapPlayer.transform.localScale = new Vector3(1.2f, 1.5f, 0.9f);
        }
        else
        {
            CapPlayer.transform.localScale = new Vector3(0.9069359f, 0.9069359f, 0.9069359f);
            CapPlayer.transform.localPosition = new Vector3(0f, 1.31f, 0f);
        }


        for (int i = 0; i < caps.Length; i++)
        {
            if (PlayerPrefs.GetString("Now Cap") == caps[i].name)
            {
                GetComponent<SpriteRenderer>().sprite = caps[i].GetComponent<SpriteRenderer>().sprite;
                break;
            }
        }
    }
}
