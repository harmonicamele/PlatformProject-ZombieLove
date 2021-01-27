using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundobserver : MonoBehaviour
{
    AudioSource sound;
    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        scorecontrol.scorePlay += PlaySoundOneShot;    
    }
    private void OnDisable()
    {
        scorecontrol.scorePlay -= PlaySoundOneShot;
    }
    
    private void PlaySoundOneShot(AudioClip clip)
    {
        sound.PlayOneShot(clip);
    }
}
