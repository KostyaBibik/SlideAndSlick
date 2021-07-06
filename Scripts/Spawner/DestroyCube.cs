using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "spike" || other.tag == "coin" || other.tag == "heart" || other.tag =="bullet")
        {
            Destroy(other.gameObject);
        }
    }
   
}
