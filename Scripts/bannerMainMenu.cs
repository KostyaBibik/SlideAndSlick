using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class bannerMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Advertisement.Initialize("4059909", false);
        StartCoroutine(showBannnerWhenReady());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    public IEnumerator showBannnerWhenReady()
    {
        while (!Advertisement.IsReady("banner"))
        {
            yield return new WaitForSeconds(0.0f);
        }
        Advertisement.Banner.Show("banner");
    }


    void Update()
    {
        
    }
}
