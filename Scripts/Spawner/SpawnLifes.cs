using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLifes : MonoBehaviour
{

    public GameObject life;
    private GameObject CheckLife;
    private float posZ;
    public bool startGame;

    public void Start()
    {
        StartGame();
        posZ = 5f;
        StartCoroutine(DelaySpikes());
    }
    void StartGame()
    {
        startGame = true;
    }

    void Create()
    {
        int posSpike = Random.Range(0, 5);

        if (posSpike == 4)
        {
            CheckLife = Instantiate(life, new Vector3(4f - Random.Range(0, 5) * 0.1f, 12f, posZ), Quaternion.identity);
            CheckLife.transform.SetParent(transform, true);
        }
        else if (posSpike == 0)
        {
            CheckLife = Instantiate(life, new Vector3(-3.63f + posSpike * 5f - Random.Range(0, 5) * 0.1f, 12f, posZ), Quaternion.identity);
            CheckLife.transform.SetParent(transform, true);
        }
        else
        {
            CheckLife = Instantiate(life, new Vector3(-3.63f + Random.Range(0, 7), 12f, posZ), Quaternion.identity);
            CheckLife.transform.SetParent(transform, true);
        }

    }


    IEnumerator DelaySpikes()
    {
        

        while (true)
        {
            float rangeSpike = Random.Range(25f, 50f);
            if (startGame == true)
                rangeSpike = 30f + Random.Range(-5f, 5f);
            if (Time.timeScale > 2.4f)
                rangeSpike -= Random.Range(5f, 10f);
            yield return new WaitForSeconds(rangeSpike);
            Create();
            
        }
    }
}
