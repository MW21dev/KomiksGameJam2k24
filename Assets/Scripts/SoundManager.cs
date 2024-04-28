using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource soundManager;



    public AudioClip SIN;
    public AudioClip BLESS;
    public AudioClip click;
    public AudioClip lose;
    public AudioClip use;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

        public void PlaySound(int soundnb)
    {
        switch (soundnb)
        {
            case 0:
                soundManager.clip = SIN;
                soundManager.Play();

                break;
            case 1:
                soundManager.clip = BLESS;
                soundManager.Play();

                break;
            case 2:
                soundManager.clip = click;
                soundManager.Play();

                break;
            case 3:
                soundManager.clip = lose;
                soundManager.Play();

                break;

            case 4:
                soundManager.clip = use;
                soundManager.Play();

                break;

        }

    }

    public void PlayOneS(AudioClip clip)
    {
        soundManager.PlayOneShot(clip);
    }
}