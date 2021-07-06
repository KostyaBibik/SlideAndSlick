using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBuuton : MonoBehaviour
{
    public GameObject SoundButton;
    void Start()
    {
        
    }

    public void SwitchSound()
    {
        SoundButton.SetActive(!SoundButton.activeSelf);        
    }
    
    void Update()
    {
        
    }
}
