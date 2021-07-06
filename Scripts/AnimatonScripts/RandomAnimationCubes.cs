using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationCubes : MonoBehaviour
{
    public Animation CubesAnimation;
    public AnimationClip[] animationClips;

    public Animation PlayedClip;
    private int Select;
    public void Start()
    {
        StartCoroutine(changeAnim());
    }


    IEnumerator changeAnim()
    {

        do
        {
            yield return new WaitForSeconds(0.1f);
            Select = Random.Range(0, animationClips.Length);
            CubesAnimation.clip = CubesAnimation.GetClip(animationClips[Select].name);
            CubesAnimation.Play();
            yield return new WaitForSeconds(animationClips[Select].length);      

        } while (true);

    }


}
