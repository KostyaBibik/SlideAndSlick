using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Checkpos : MonoBehaviour, IBeginDragHandler, IDragHandler
{
   
    private float speed;
    public GameObject quad;
    SpriteRenderer spriteQuad;
    public GameObject square;
    public void OnBeginDrag(PointerEventData eventData)
    {
        if((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y))){
            if(eventData.delta.x > 0)
            {
                square.transform.position += Vector3.right * Time.deltaTime * speed;
            }
            else
            {
                square.transform.position += Vector3.left * Time.deltaTime * speed;
            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                square.transform.position += Vector3.up * Time.deltaTime * speed;
            }
            else
            {
                square.transform.position += Vector3.down * Time.deltaTime * speed;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {        
    }

    

    // Start is called before the first frame update
    void Start()
    {
        speed = 50f;
        spriteQuad = quad.GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
