using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    private Vector3 targetPos;
    public float minX, maxX;
    public float speed;

    private int hpTrader;
    public int hpEnemy;

    public GameObject shootBTN;

    void Start()
    {
        hpTrader = hpEnemy;
        targetPos = new Vector3(maxX, transform.position.y, transform.position.z);
        //hpEnemy = hpTrader = 15;
    }

    public void Fresh()
    {
        hpTrader = hpEnemy;
        targetPos = new Vector3(maxX, transform.position.y, transform.position.z);
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "bullet")
        {
            Destroy(other.gameObject);
            hpEnemy -= 1;
        }
    }
    void Update()
    {
        if(hpEnemy <= 0)
        {
            //GetComponent<SpawnSpikes>().EasyBose1 = false;
            hpTrader = hpTrader + Random.Range(4, 7);
            hpEnemy = hpTrader;
            gameObject.SetActive(false);
            shootBTN.SetActive(false);
        }

        if(transform.position.x == minX)
        {
            targetPos = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if (transform.position.x == maxX)
        {
            targetPos = new Vector3(minX, transform.position.y, transform.position.z);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
