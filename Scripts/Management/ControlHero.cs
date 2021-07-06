using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ControlHero : MonoBehaviour
{

    public GameObject player;
    public float minX, maxX;
    public Vector3 targetPos;
    public float speed;

    private bool direction;

    public Animator animatorHero;
    public float PosZ;

    private Vector2 startPos;
    public Camera mainCamera;
    private float TargetPosX;

    private bool isPlayEffect;

    private GameObject effectHero;
    public GameObject soundHeroSwipe;

    public GameObject[] effectsHero;

    
    void Start()
    {
        TargetPosX = player.transform.position.x;
        animatorHero = GetComponent<Animator>();
        PosZ = 5f;
        targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

   
    void Update()
    {
        if (PlayerPrefs.GetString("Now Body") == "Body")
        {
            isPlayEffect = false;
            //effectHero = effectsHero[0];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body1")
        {
            effectHero = effectsHero[1];
            isPlayEffect = true;
        }
        if (PlayerPrefs.GetString("Now Body") == "Body2")
        {
            isPlayEffect = true;
            effectHero = effectsHero[2];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body3")
        {
            isPlayEffect = true;
            effectHero = effectsHero[3];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body4")
        {
            isPlayEffect = true;
            effectHero = effectsHero[4];
        }
        //effectHero = effectsHero[0];


        animatorHero.SetTrigger("Moved");

        
        /////////////////////////////////////////////////////////////
        if (Input.GetMouseButtonDown(0)) startPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
            
            float pos = mainCamera.ScreenToWorldPoint(Input.mousePosition).x;
            if(pos > startPos.x)
            {

                
                
                TargetPosX = maxX;
                if (direction == true)
                {
                    if (effectHero && isPlayEffect) Instantiate(effectHero, player.transform.position, Quaternion.identity);
                    if (soundHeroSwipe) Instantiate(soundHeroSwipe, player.transform.position, Quaternion.identity);
                }
                direction = false;
            }
            else if (pos < startPos.x)
            {
                TargetPosX = minX;
                if (direction == false)
                {
                    if(soundHeroSwipe) Instantiate(soundHeroSwipe, player.transform.position, Quaternion.identity);
                    if (effectHero && isPlayEffect) Instantiate(effectHero, player.transform.position, Quaternion.identity);
                }
                direction = true;//left
                
            }
            
        }
        

        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(TargetPosX, player.transform.position.y, player.transform.position.z), speed * Time.deltaTime);

        if (player.transform.position.x > maxX)
            player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(maxX, player.transform.position.y, player.transform.position.z), speed * Time.deltaTime);

        else if (player.transform.position.x < minX)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(minX, player.transform.position.y, player.transform.position.z), speed * Time.deltaTime);
        }

        ///////////////////////////////////////
        
    }

    

    
    
    
    
}
