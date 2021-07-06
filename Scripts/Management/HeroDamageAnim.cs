using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDamageAnim : MonoBehaviour
{
    public GameObject CapPlayer;
    public GameObject BodyPlayer;
    public Animator PlayerAnim;

    public GameObject[] lifes;
    private float count;   
    
    void Update()
    {

        if (!lifes[0].activeSelf)
        {
            PlayerAnim.SetBool("Damage", true);
            PlayerAnim.SetBool("Damage2", false);
            count = 0f;
            new WaitForSeconds(1f);
            
        }
        else if (!lifes[1].activeSelf )
        {
            PlayerAnim.SetBool("Damage2", true);
            PlayerAnim.SetBool("Damage", false);
            new WaitForSeconds(1f);
            
            count = 0f;
            
        }
        if (lifes[1].activeSelf)
        {
            PlayerAnim.SetBool("Damage", false);
            PlayerAnim.SetBool("Damage2", false);
            new WaitForSeconds(1f);
        }
    }

    
    


}
