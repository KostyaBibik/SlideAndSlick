using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawnWall : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    private GameObject CheckCube;
    private int CountCubes = 0;
    private float timeDelay;
    private float xLeft, xRight;
    void Start()
    {
        CountCubes = 0;
        StartCoroutine(CreateCubes());
        xLeft = -5.1f;
        xRight = 6.3f;
    }
    IEnumerator CreateCubes()
    {
        
        while(true)
        {
            if (CountCubes < 40)
                timeDelay = 0.05f;
            else
                timeDelay = 0.24f;
            yield return new WaitForSeconds(timeDelay);
            Spawn(xLeft, xRight, Cube1);
            
            yield return new WaitForSeconds(timeDelay);
            Spawn(xLeft, xRight, Cube2);
            
        }        
    }
    void Spawn(float xLeft, float xRight, GameObject Prefab)
    {
        CheckCube = Instantiate(Prefab, new Vector3(xLeft, -10f + CountCubes * 1.245f, 0f), Quaternion.identity);
        CheckCube.transform.SetParent(transform, false);
        CheckCube = Instantiate(Prefab, new Vector3(xRight, -10f + CountCubes * 1.245f, 0f), Quaternion.identity);
        CheckCube.transform.SetParent(transform, false);
        CountCubes++;
    }
    
    void Update()
    {
        
    }
}
