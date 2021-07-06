using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHero : MonoBehaviour
{
    public Rigidbody player;
    public float force;

    public float CheckRadius;
    public bool canMove;

    public float speed;
    public float minX, maxX;

    public Vector3 targetPos;
    public Animation heroAnim;

    public GameObject effectHero;
    public GameObject[] soundsHero;
    private Animator camAnim;
    private GameObject soundForDel;

    private float PosYbot;

    private Vector3 startTouchPos, endTouchPos;
    void Start()
    {
        PosYbot = 0f;//- 8.83f;
        canMove = true;
        heroAnim.clip = GetComponent<Animation>().GetClip("Hero");
        camAnim = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<Animator>();
    }

    private void Update()
    {

        float randomX = Random.Range(2f, 3f);
        float randomY = Random.Range(-2f, 2f);
        int randSound = Random.Range(1, soundsHero.Length);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            soundForDel = Instantiate(soundsHero[randSound], transform.position, Quaternion.identity) as GameObject;
            StartCoroutine(deleteSound());
            Instantiate(effectHero, new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z), Quaternion.identity);
            camAnim.SetTrigger("shake camera");
        }

        //canMove = Physics.OverlapBox(new Vector3(transform.position.x/2, transform.position.y/2, transform.position.z), );
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX && canMove)
        {           
            Instantiate(effectHero, new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z), Quaternion.identity);
            targetPos = new Vector3(minX, 0f, transform.position.z);
            StartCoroutine(AfterMove());
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX && canMove)
        {            
            Instantiate(effectHero, new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z), Quaternion.identity);
            targetPos = new Vector3(maxX, PosYbot, transform.position.z);
            StartCoroutine(AfterMove());
        }

        

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    startTouchPos = Input.GetTouch(0).position;
        //}
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    endTouchPos = Input.GetTouch(0).position;

        //    if (endTouchPos.x < startTouchPos.x)
        //    {
        //        Instantiate(effectHero, new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z), Quaternion.identity);
        //        targetPos = new Vector3(minX, transform.position.y, transform.position.z);
        //        StartCoroutine(AfterMove());
        //    }

        //    if (endTouchPos.x > startTouchPos.x)
        //    {
        //        Instantiate(effectHero, new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z), Quaternion.identity);
        //        targetPos = new Vector3(maxX, transform.position.y, transform.position.z);
        //        StartCoroutine(AfterMove());
        //    }

        //}
        
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
    IEnumerator deleteSound()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(soundForDel);
    }

    public IEnumerator AfterMove()
    {
        new WaitForSeconds(0.13f);
        new WaitUntil(() => transform.position.x == maxX || transform.position.x == minX);

        //GetComponent<Animation>().Play("Hero");
        yield return null;
    }
    void FixedUpdate()
    {
        
    }
}
