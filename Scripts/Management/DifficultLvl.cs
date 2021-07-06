using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultLvl : MonoBehaviour
{
    //public SpawnSpikes Spawner;
    public float timeInterval;
    public float speedIncrease;
    public float saveSpeedIncrease;
    public float saveTimeSpeed;

    bool hard1, hard2, hard3, hardMax, extraLvl;

    public GameObject enemy1;
    private bool isEnemeLive;

    public void StartCorout()
    {
        StartCoroutine(RaiseSpeedTime());
    }

    public void Start()
    {
        isEnemeLive = false;
        print("start!");
        hard1 = hard2 = hard3 = hardMax = extraLvl = false;
        StartCoroutine(RaiseSpeedTime());
    }

    private void Update()
    {
        if(enemy1.activeSelf && !isEnemeLive)
        {
            save();
            StopAllCoroutines();
            Time.timeScale = saveTimeSpeed;
            if (saveTimeSpeed > 2f)
            {
                StartCoroutine(lowerSpeedTime(saveTimeSpeed, 2f));
                hard3 = hardMax = false;
            }
            isEnemeLive = true;
        }
        if (!enemy1.activeSelf && isEnemeLive)
        {
            isEnemeLive = false;
            StopAllCoroutines();
            StartCoroutine(RaiseSpeedTime());
        }
    }
    IEnumerator RaiseSpeedTime()
    {
        do
        {
            //print("RaiseSpeedTime");
            if (Time.timeScale >= 2.4 && hardMax)
            {
                if (!extraLvl)
                {
                    Time.timeScale = 2.415f + Random.Range(-0.1f, 0.1f);
                    print("EXTRA LVL");
                    yield return new WaitForSeconds(20f + Random.Range(-5f, 0f));
                    extraLvl = true;
                    print("End of ExtraLvl");
                    StartCoroutine(lowerSpeedTime(Time.timeScale, 2f));
                }
                speedIncrease = 0.5f + Random.Range(-0.005f, 0.005f);
            }
            else if(Time.timeScale >=2.05 && hard3)
            {
                StartCoroutine(lowerSpeedTime(2.1f, 1.7f));                
                speedIncrease = 0.4f + Random.Range(-0.04f, 0.01f);
                hardMax = true;
                yield break;
            }
            else if(Time.timeScale >= 1.7 && hard1 && hard2 && !hard3)
            {
                hard3 = true;
                StartCoroutine(lowerSpeedTime(Time.timeScale, Time.timeScale - 0.4f));
                yield break;
            }
            else if (Time.timeScale >= 1.45 && hard1 && !hard2)
            {
                hard2 = true;
                speedIncrease = 0.35f;
            }
            else if (Time.timeScale >= 1.35 && !hard1)
            {
                hard1 = true;                
                StartCoroutine(lowerSpeedTime(Time.timeScale, 1.2f));
                yield break;
            }
            else
            {
                Time.timeScale += speedIncrease * Time.deltaTime;
            }
            
            yield return new WaitForSeconds(timeInterval /2 );
            //print(Time.timeScale);
        } while (true);
    }

    public void save()
    {
        saveSpeedIncrease = speedIncrease;
        saveTimeSpeed = Time.timeScale;
        destroyTimeSpeed();
    }
    public void destroyTimeSpeed()
    {
        Time.timeScale = 0f;
    }

    public void continueAfterDead()
    {
        Time.timeScale = 1.6f;
    }
    public void ActivateSave()
    {
        speedIncrease = saveSpeedIncrease;
        Time.timeScale = saveTimeSpeed;
    }

    

    IEnumerator lowerSpeedTime(float timeBegin, float timeEnd)
    {       
        do
        {
            //print("lowerSpeedTime");
            //print(Time.timeScale);
            Time.timeScale -= speedIncrease*Time.deltaTime;
            timeBegin -= speedIncrease;
            yield return new WaitForSeconds(timeInterval);
        }   while (timeBegin >= timeEnd);
        if(timeBegin <= timeEnd)
        {            
            StartCoroutine(RaiseSpeedTime());
            yield break;
        }
    }
    
    void StartCor(float timeBegin, float timeEnd)
    {
        StopAllCoroutines();
        StartCoroutine(lowerSpeedTime(timeBegin, timeEnd));
    }

    //IEnumerator ExtraSpeed()
    //{
    //    Time.timeScale = 3.6f + Random.Range(-0.2f, 0.2f);
    //}
}
