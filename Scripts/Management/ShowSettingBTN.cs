using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSettingBTN : MonoBehaviour
{
    public GameObject SoundBTN;

    public void Show()
    {
        SoundBTN.SetActive(!SoundBTN.activeSelf);        
    }
    
}
