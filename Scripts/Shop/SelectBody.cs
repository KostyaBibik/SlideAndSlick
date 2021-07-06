using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectBody : MonoBehaviour
{

    public GameObject selectBody, buyBody, PlayerBody;

    public GameObject[] bodys;

    public GameObject priceBody;
    [HideInInspector]
    public string nowBody;
    

    void Start()
    {
        if(PlayerPrefs.GetString("Body") != "Open")
        {
            PlayerPrefs.SetString("Body", "Open");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        nowBody = other.gameObject.name;
        other.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

        print(other.name);



        //if (other.name == "Body")
        //    priceBody.GetComponent<Text>().text = " ";
        if (other.name == "Body1")
        {
            priceBody.GetComponent<Text>().text = "300";
        }
        if (other.name == "Body2")
        {
            priceBody.GetComponent<Text>().text = "500";
        }
        if (other.name == "Body3")
            priceBody.GetComponent<Text>().text = "500";
        if (other.name == "Body4")
            priceBody.GetComponent<Text>().text = "700";

        if(PlayerPrefs.GetString(other.name) == "Open")
            priceBody.GetComponent<Text>().text = " ";


        if (PlayerPrefs.GetString(other.gameObject.name) == "Open")
        {
            selectBody.SetActive(true);
            buyBody.SetActive(false);
        }
        else
        {
            selectBody.SetActive(false);
            buyBody.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }
}
