using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    public static AudioManagement instance;
    public AudioSource musicSource; 
    public AudioSource effectSource;
    public AudioSource buzzSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySoundEffect(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }

    public void PlayBuzzEffect()
    {
        buzzSource.Play();
    }
    public void StopBuzzEffect()
    {
        buzzSource.Stop();
    }

}
