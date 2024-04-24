using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class percentVolume : MonoBehaviour
{
    float volume;

    private AudioSource GameSettingAudioSource;

    private void Start()
    {
        GameSettingAudioSource = GetComponent<AudioSource>();
    }


    private void FixedUpdate()
    {
        volume = PlayerPrefs.GetFloat("totalVolume");
        GameSettingAudioSource.volume = volume;
    }
}
