using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMover : MonoBehaviour
{
    public float speed;    
    private bool spawned;

    void Update()
    {
       // spawner.transform.position = new Vector3(0, 0, 0);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        //speed += 5f * Time.deltaTime;
        if(transform.position.x<0 && !spawned)
        {
            //Destroy();
            //int rand = Random.Range(0, spawner.BlockLines.Length);
            //Instantiate(spawner.BlockLines[rand], spawner.BlockLines[rand].transform.position, Quaternion.identity);
        }
    }
    private void Start()
    {
        
    }

    

}
