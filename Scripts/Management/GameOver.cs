using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject player;
    public GameObject bodyPlayer;
    public GameObject capPlayer;
    public GameObject spawner;
    private Vector4 color;
    private SpriteRenderer colorBody;
    private SpriteRenderer colorCap;
    public GameObject GameOverMenu;
    public GameObject imageCoins;
    public GameObject enemy1;
    void Start()
    {
        
    }

    public void deleteSpawnerChildObjects()
    {
        foreach (Transform child in spawner.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void pressRestart()
    {
        if(enemy1.activeSelf)enemy1.SetActive(false);
        deleteSpawnerChildObjects();

        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        player.SetActive(true);
        player.transform.position = new Vector3(0f, player.transform.position.y, player.transform.position.z);
        colorBody = bodyPlayer.GetComponent<SpriteRenderer>();
        color = new Vector4(colorBody.color.r, colorBody.color.g, colorBody.color.b, 255f);
        bodyPlayer.GetComponent<SpriteRenderer>().color = color;

        colorCap = capPlayer.GetComponent<SpriteRenderer>();
        color = new Vector4(colorCap.color.r, colorCap.color.g, colorCap.color.b, 255f);
        capPlayer.GetComponent<SpriteRenderer>().color = color;
        

        
        
        GameObject.Find("Player").GetComponent<ManageHero>().LifeHero = true;
        GameObject.Find("Player").GetComponent<ManageHero>().lifeAffected = false;
        GameOverMenu.SetActive(false);

        imageCoins.GetComponent<Animator>().enabled = true;
    }
}
