using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundSetting : MonoBehaviour
{
    public Sprite enableSprite;
    public Sprite disableSprite;

    bool audioEnabled = true;
    public bool AudioEnabled { get { return audioEnabled; } set { SetAudio(value); } }

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        CheckSound();
    }

    public void CheckSound()
    {
        if (PlayerPrefs.GetString("IsSound") == "false")
        {
            AudioListener.volume = 0f;
            if(gameObject.activeSelf) image.sprite = disableSprite;            
        }
        else
        {
            AudioListener.volume = 1f;
            if(gameObject.activeSelf) image.sprite = enableSprite;
        }
    }
    void SetAudio(bool enabled)
    {
        if (enabled)
        {
            PlayerPrefs.SetString("IsSound", "true");
            AudioListener.volume = 1f;
            image.sprite = enableSprite;
        }
        else
        {
            PlayerPrefs.SetString("IsSound", "false");
            AudioListener.volume = 0f;
            image.sprite = disableSprite;
        }
        audioEnabled = enabled;
    }

    public void SwitchAudio()
    {
        AudioEnabled = !AudioEnabled;
    }
}
