using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicManager;

    public AudioClip song1;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void PlayMusic()
    {
        musicManager.clip = song1;
        musicManager.Play();

    }
    public void StopMusic()
    {
        musicManager.Stop();
    }

    public void PauseMusic()
    {
        musicManager.Pause();
    }
    public void UnPauseMusic()
    {
        musicManager.UnPause();

    }
}