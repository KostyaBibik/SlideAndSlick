using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoirtFire : MonoBehaviour
{
    public GameObject effectFire;
    void Start()
    {
        //StartCoroutine(spawnFire());
    }
    
    IEnumerator spawnFire()
    {
        do
        {
            Instantiate(effectFire, new Vector3(transform.position.x, transform.position.y + 1.3f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        } while (gameObject.activeSelf);
        
    }



    void  MoveFire()
    {
        effectFire.transform.position =new Vector3(gameObject.transform.position.x + 0.2f, gameObject.transform.position.x + 9f, gameObject.transform.position.z);
    }
}
