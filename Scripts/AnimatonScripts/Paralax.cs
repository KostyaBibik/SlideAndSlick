using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed;
    public float endY;
    public float startY;
    void Start()
    {
        
    }

    public void SpeedMenuFirstW()
    {
        speed = 4.5f / 3f;
    }
    public void SpeedMenuSecondW()
    {
        speed = 2.5f / 3f;
    }
    public void SpeedMenuThirdW()
    {
        speed = 1.3f / 3f;
    }



    public void SpeedGameFirstW()
    {
        speed = 4.5f;
    }
    public void SpeedGameSecondW()
    {
        speed = 2.5f;
    }
    public void SpeedGameThirdW()
    {
        speed = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if(transform.position.y <= endY)
        {
            Vector2 pos = new Vector2(transform.position.x, startY);
            transform.position = pos; 
        }
    }
}
