using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PricesBodies : MonoBehaviour
{
    public GameObject[] bodies;
    public GameObject whichBody;
    void Start()
    {
        ////PlayerPrefs.SetString(bodies[1].name, "Open");
         //PlayerPrefs.SetInt(bodies[0].name, 0);
        //PlayerPrefs.SetInt(bodies[1].name, 500);
        //PlayerPrefs.SetInt(bodies[2].name, 500);
        //PlayerPrefs.SetInt(bodies[3].name, 500);
        //PlayerPrefs.SetInt(bodies[4].name, 1000);



        //print(PlayerPrefs.GetString(bodies[1].name));
        //print(PlayerPrefs.GetString(bodies[2].name));
        //print(PlayerPrefs.GetString(bodies[3].name));
        //print(PlayerPrefs.GetString(bodies[4].name));


        //print(PlayerPrefs.GetInt(bodies[1].name));
        //print(PlayerPrefs.GetInt(bodies[2].name));
        //print(PlayerPrefs.GetInt(bodies[3].name));
        //print(PlayerPrefs.GetInt(bodies[4].name));


    }


    void Update()
    {
        //if (PlayerPrefs.GetString(whichBody.GetComponent<SelectBody>().nowBody) != "Open")
        //    gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt(whichBody.GetComponent<SelectBody>().nowBody).ToString();
        //else
        //    gameObject.GetComponent<Text>().text = "Sold";
    }
}
