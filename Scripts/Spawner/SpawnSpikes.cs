using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour
{
    public GameObject spike;
    public GameObject meteorit;
    private GameObject CheckSpike;
    public GameObject cross;

    public float minX;
    public float maxX;
    //public float intervalSpawn;

    private float posZ;

    public bool EasyBose1;
    private bool IsStart = false;
    private bool isSpawnSpike = true;

    public GameObject shootBTN;

    public GameObject enemy1;
    public GameObject enemy1Bullet;
    public GameObject enemy1Bullet2;
    private GameObject enemyBullet;

    public GameObject soundMeteorit;
    private float boardScore;

    public GameObject[] spikes;
    public void Start()
    {
        boardScore = 500;
        //if(!IsStart)StartCoroutine(DelaySpikes());
        //else
        //{
        //    StartCoroutine(DelaySpikes());
        //    IsStart = true;
        //}
        StopAllCoroutines();
        StartCoroutine(DelaySpikes());
        posZ = 5.25f;
        EasyBose1 = false;
        isSpawnSpike = true;
        enemy1.SetActive(false);
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("Now Body") == "Body")
        {
            spike = spikes[0];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body1")
        {
            spike = spikes[1];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body2")
        {
            spike = spikes[2];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body3")
        {
            spike = spikes[3];
        }
        if (PlayerPrefs.GetString("Now Body") == "Body4")
        {
            spike = spikes[4];
        }
        //if (!enemy1.activeSelf)
        //{
        //    EasyBose1 = false;
        //}

        if (!enemy1.activeSelf && EasyBose1 && !isSpawnSpike)
        {
            isSpawnSpike = true;
            StopAllCoroutines();
            StartCoroutine(DelaySpikes());
        }
    }
    public void restart()
    {
        
    }
    void Create()
    {
        int posSpike = Random.Range(0, 11);
        //posSpike = 9;
        if (posSpike == 10)
        {
            CheckSpike = Instantiate(cross, new Vector3(Random.Range(minX, maxX), 23.5f, posZ), new Quaternion(0f, 0f, 0f, 0f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 9)
        {
            Instantiate(soundMeteorit, transform.position, Quaternion.identity);
            CheckSpike = Instantiate(meteorit, new Vector3(Random.Range(0, 5) * 0.2f, 23.5f, posZ), new Quaternion(0f, 0f, 0f, 0f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 8)
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 12f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 13f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            

            CheckSpike = Instantiate(spike, new Vector3(4f, 12f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(4f, 13f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);            
        }
        else if (posSpike == 7)
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 12f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 13f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 14f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);

            CheckSpike = Instantiate(spike, new Vector3(4f, 12f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(4f, 13f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(4f, 14f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 6)
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 12f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 13f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true); 
            CheckSpike = Instantiate(spike, new Vector3(-3.63f, 14f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 5)
        {
            CheckSpike = Instantiate(spike, new Vector3(4f , 12f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(4f , 13f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
            CheckSpike = Instantiate(spike, new Vector3(4f , 14f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 4)
        {
            CheckSpike = Instantiate(spike, new Vector3(4f - Random.Range(0, 5) * 0.1f, 12f, posZ), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 0)
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f + posSpike * 5f - Random.Range(0, 5) * 0.1f, 12f, posZ), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f + Random.Range(0, 7), 12f, posZ), new Quaternion(0f, 0f, 90f, 0f));
            CheckSpike.transform.SetParent(transform, true);
        }

    }

    IEnumerator DelaySpikes()
    {
        while (true)
        {
            if (PlayerPrefs.GetInt("Score") > boardScore && !EasyBose1)
            {
                //boardScore += boardScore * Random.Range(1.75f, 2.8f);
                boardScore += Random.Range(750, 2100);
                print("enemy1");
                StartCoroutine(spawnDamage());
                enemy1.SetActive(true);
                EasyBose1 = true;
                isSpawnSpike = false;
                shootBTN.SetActive(true);
                

                yield break;
            }
            if(PlayerPrefs.GetInt("Score") > 1000)
            {
                EasyBose1 = false;
            }


            if (isSpawnSpike)
            {
                float rangeSpike = Random.Range(1f, 2.4f);
                Create();
                yield return new WaitForSeconds(rangeSpike);
            }
            
        }
    }

    IEnumerator spawnDamage()
    {
        do
        {
            float rand = Random.Range(0, 15);

            float randBullet = Random.Range(0, 3);
            if (randBullet == 2)
            {
                enemyBullet = enemy1Bullet2;
            }
            else
            {
                enemyBullet = enemy1Bullet;
            }

            if (rand < 10)
            {
                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x, enemy1.transform.position.y, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);
                yield return new WaitForSeconds(Random.Range(1.1f, 1.7f));
            }
            else if (rand < 13)
            {
                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x, enemy1.transform.position.y, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);

                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x - 1f, enemy1.transform.position.y + 1f, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);

                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x + 1f, enemy1.transform.position.y + 1f, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);
                yield return new WaitForSeconds(Random.Range(1.1f, 1.7f));
            }
            else if(rand == 14)
            {
                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x, enemy1.transform.position.y, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);

                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x, enemy1.transform.position.y + 1.5f, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);

                CheckSpike = Instantiate(enemyBullet, new Vector3(enemy1.transform.position.x, enemy1.transform.position.y + 3f, posZ), new Quaternion(0f, 0f, 0, 0));
                CheckSpike.transform.SetParent(transform, true);
                yield return new WaitForSeconds(Random.Range(1.1f, 1.7f));
            }

        } while (true);
    }
}