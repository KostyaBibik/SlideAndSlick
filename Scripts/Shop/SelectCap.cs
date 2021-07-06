using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectCap : MonoBehaviour
{
    public GameObject selectCap, buyCap, PlayerCap;

    public GameObject[] caps;

    public GameObject priceCap;
    [HideInInspector]
    public string nowCap;


    void Start()
    {
        if (PlayerPrefs.GetString("Cap") != "Open")
        {
            PlayerPrefs.SetString("Cap", "Open");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        nowCap = other.gameObject.name;
        other.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        
        
        print(other.name);



        if (other.name == "Cap")
            priceCap.GetComponent<Text>().text = " ";
        if (other.name == "Cap1")
        {
            priceCap.GetComponent<Text>().text = "300";
        }
        if (other.name == "Cap2")
        {
            other.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
            priceCap.GetComponent<Text>().text = "400";
        }
        if (other.name == "Cap3")
            priceCap.GetComponent<Text>().text = "500";

        if (other.name == "Cap4")
            priceCap.GetComponent<Text>().text = "700";

        if (other.name == "Cap5")
            priceCap.GetComponent<Text>().text = "750";

        if (PlayerPrefs.GetString(other.name) == "Open")
            priceCap.GetComponent<Text>().text = " ";


        if (PlayerPrefs.GetString(other.gameObject.name) == "Open")
        {
            selectCap.SetActive(true);
            buyCap.SetActive(false);
        }
        else
        {
            selectCap.SetActive(false);
            buyCap.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.localScale = new Vector3(1f, 1f, 1f);


        if (other.name == "Cap2")
        {
            other.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);            
        }
    }
}
