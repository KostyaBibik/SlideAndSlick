using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;
    private GameObject CheckSpike;
    private float posZ;
    public void Start()
    {
        StopAllCoroutines();
        posZ = 5f;
        StartCoroutine(DelaySpikes());
    }


    void Create()
    {
        int posSpike = Random.Range(0, 5);
       
        if (posSpike == 4)
        {
            CheckSpike = Instantiate(coin, new Vector3(4f - Random.Range(0,5)*0.1f, 12f, posZ), Quaternion.identity);
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 0)
        {
            CheckSpike = Instantiate(coin, new Vector3(-3.63f + posSpike * 5f - Random.Range(0, 5) * 0.1f, 12f, posZ), Quaternion.identity);
            CheckSpike.transform.SetParent(transform, true);
        }
        else
        {
            CheckSpike = Instantiate(coin, new Vector3(-3.63f + Random.Range(0, 7), 12f, posZ), Quaternion.identity);
            CheckSpike.transform.SetParent(transform, true);
        }

    }
   

    IEnumerator DelaySpikes()
    {
        while (true)
        {
            float rangeSpike = Random.Range(3f, 10f);
            Create();
            yield return new WaitForSeconds(rangeSpike);
        }        
    }
}
