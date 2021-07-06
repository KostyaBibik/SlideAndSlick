using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollusionCoinSpike : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "spike")
        {
            Destroy(gameObject);
        }
    }
}
