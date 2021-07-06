using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySoundEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySound());
    }

   IEnumerator DestroySound()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
