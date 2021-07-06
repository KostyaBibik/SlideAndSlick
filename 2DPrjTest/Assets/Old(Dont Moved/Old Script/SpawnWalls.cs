using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    public GameObject[] BlockLines;
    public GameObject walls;
    public GameObject[] PrefabWall;
    private GameObject blockInst;
    public float speed;
    public float speedIncrease;

    private void Start()
    {
        StartCoroutine(spawn());
    }
    void FixedUpdate()
    {
        
    }
    IEnumerator spawn()
    {
        while (true)
        {
            int rand = Random.Range(0, BlockLines.Length);
            blockInst = Instantiate(PrefabWall[0], new Vector3(18.845f, -1.404541f, 0.3523183f), Quaternion.identity);
            blockInst.transform.parent = walls.transform;
            blockInst = Instantiate(PrefabWall[1], new Vector3(15f, -3.5f, 0f), Quaternion.identity);
            blockInst.transform.parent = walls.transform;
            yield return new WaitForSeconds(0.75f);
        }
    }
    // Update is called once per frame
    void SpawnWave()
    {
        speed += speedIncrease * Time.deltaTime;
    }
}
