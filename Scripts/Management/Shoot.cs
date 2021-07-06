using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject HeroBullet;
    void Start()
    {
        
    }

    public void ShootBTN()
    {
        Instantiate(HeroBullet, new Vector3(transform.position.x, transform.position.y, 5.25f), new Quaternion(0f, 0f, 0, 0));
    }
    
}
