using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMove : MonoBehaviour
{
    public float speed;
    private bool spawned;

    void Update()
    {
        var spikes = GameObject.FindGameObjectsWithTag("spike");
        
        foreach (var child in spikes)
        {
            if (child.name == "Meteorit" || child.name == "Meteorit(Clone)"|| child.name == "meteorit(Clone)")
            {
                //print("meteor");
                child.transform.position = Vector3.MoveTowards(child.transform.position, new Vector3(child.transform.position.x, -20f, child.transform.position.z), speed * Random.Range(1.25f, 1.8f) * Time.deltaTime);
            }
            else
                child.transform.position = Vector3.MoveTowards(child.transform.position, new Vector3(child.transform.position.x, -20f, child.transform.position.z), speed * Time.deltaTime);
        }

        var coins = GameObject.FindGameObjectsWithTag("coin");
        foreach (var child in coins)
        {
            
            child.transform.position = Vector3.MoveTowards(child.transform.position, new Vector3(child.transform.position.x, -20f, child.transform.position.z), speed * Time.deltaTime);
        }
        var lifes = GameObject.FindGameObjectsWithTag("heart");
        foreach (var child in lifes)
        {
            child.transform.position = Vector3.MoveTowards(child.transform.position, new Vector3(child.transform.position.x, -20f, child.transform.position.z), speed * Time.deltaTime);
        }

        var bullets = GameObject.FindGameObjectsWithTag("bullet");
        foreach (var child in bullets)
        {
            child.transform.position = Vector3.MoveTowards(child.transform.position, new Vector3(child.transform.position.x, 30f, child.transform.position.z), (speed/2) * speed * Time.deltaTime);
        }

    }
    private void Start()
    {

    }



}
