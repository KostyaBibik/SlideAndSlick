using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall" || other.tag == "spike")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.otherCollider.tag == "spike")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {        
        {
            Destroy(other.gameObject);
        }
    }
}
