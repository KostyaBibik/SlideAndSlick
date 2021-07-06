using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScroolingShop : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    private Vector3 targetPos;
    public float BodyminX, BodyMaxX;//-18.7; -2.9
    public float CapminX, CapMaxX;//-18.7; -2.9
    public GameObject Bodys;
    public GameObject Caps;
    public float speed;
    public Camera mainCamera;

    private float CheckTarget;
    private bool CheckTargetBegin;

    private float TargetPosX;
    public Vector2 startPos;
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
    }

    void Start()
    {
        TargetPosX = Bodys.transform.position.x;
    }

    
    void Update()
    {
        if (Bodys.activeSelf)
        {
            if (Input.GetMouseButtonDown(0)) startPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            else if (Input.GetMouseButton(0))
            {
                float pos = mainCamera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                TargetPosX = Bodys.transform.position.x + pos;
            }

            Bodys.transform.position = Vector3.MoveTowards(Bodys.transform.position, new Vector3(TargetPosX, Bodys.transform.position.y, Bodys.transform.position.z), speed * Time.deltaTime);

            if (Bodys.transform.position.x > BodyMaxX)
                Bodys.transform.position = Vector3.MoveTowards(Bodys.transform.position, new Vector3(BodyMaxX, Bodys.transform.position.y, Bodys.transform.position.z), speed * Time.deltaTime);

            else if (Bodys.transform.position.x < BodyminX)
            {
                Bodys.transform.position = Vector3.MoveTowards(Bodys.transform.position, new Vector3(BodyminX, Bodys.transform.position.y, Bodys.transform.position.z), speed * Time.deltaTime);
            }
        }


        if (Caps.activeSelf)
        {
            if (Input.GetMouseButtonDown(0)) startPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            else if (Input.GetMouseButton(0))
            {
                float pos = mainCamera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                TargetPosX = Caps.transform.position.x + pos;
            }

            Caps.transform.position = Vector3.MoveTowards(Caps.transform.position, new Vector3(TargetPosX, Caps.transform.position.y, Caps.transform.position.z), speed * Time.deltaTime);

            if (Caps.transform.position.x > CapMaxX)
                Caps.transform.position = Vector3.MoveTowards(Caps.transform.position, new Vector3(CapMaxX, Caps.transform.position.y, Caps.transform.position.z), speed * Time.deltaTime);

            else if (Caps.transform.position.x < CapminX)
            {
                Caps.transform.position = Vector3.MoveTowards(Caps.transform.position, new Vector3(CapminX, Caps.transform.position.y, Caps.transform.position.z), speed * Time.deltaTime);
            }
        }

    }
}
