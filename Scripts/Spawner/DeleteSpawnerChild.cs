using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSpawnerChild : MonoBehaviour
{
    public GameObject Spawner;

    public void DeleteChilds()
    {
        int n = Spawner.transform.childCount;
        for (int i = 0; i < n; i++)
        {
            Destroy(Spawner.transform.GetChild(i).gameObject);
        }


        //var spikes = GameObject.FindGameObjectsWithTag("spike");

        //foreach (var child in spikes)
        //{

        //}
    }
}
