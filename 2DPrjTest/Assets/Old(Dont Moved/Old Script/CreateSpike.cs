using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpike : MonoBehaviour
{
    public GameObject spike;
    private GameObject CheckSpike;
    void Start()
    {
        StartCoroutine(DelaySpikes());
    }


    void Create()
    {
        int posSpike = Random.Range(0, 5);
       
        if (posSpike == 4)
        {
            CheckSpike = Instantiate(spike, new Vector3(4f - Random.Range(0,5)*0.1f, 12f, 4f), new Quaternion(0f, 0f, 90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else if (posSpike == 0)
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f + posSpike * 5f - Random.Range(0, 5) * 0.1f, 12f, 4f), new Quaternion(0f, 0f, -90f, 90f));
            CheckSpike.transform.SetParent(transform, true);
        }
        else
        {
            CheckSpike = Instantiate(spike, new Vector3(-3.63f + Random.Range(0, 7), 12f, 4f), new Quaternion(0f, 0f, 90f, 0f));
            CheckSpike.transform.SetParent(transform, true);
        }

    }
    


    IEnumerator DelaySpikes()
    {
        while (true)
        {
            float rangeSpike = Random.Range(1f, 2f);
            Create();
            yield return new WaitForSeconds(rangeSpike);
        }        
    }
}
