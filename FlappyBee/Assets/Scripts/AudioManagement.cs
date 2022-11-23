using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    public static AudioManagement Instance;
    public AudioSource MusicSource; 
    public AudioSource EffectSource;
    public AudioSource BuzzSource;
    public float Pitch { get; private set; }
    //[SerializeField] private float[] pitchRange = {1.4f, 1.6f};

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        BuzzSource.Stop();
    }

    private void Update()
    {
        if(Time.deltaTime <= 0)
        {
            PlayBuzzSound(false);
        }
    }

    public void PlaySoundEffect(AudioClip clip)
    {
        EffectSource.PlayOneShot(clip);
    }

    public void PlayBuzzSound(bool isBuzzing)
    {
        if (isBuzzing && BuzzSource.isPlaying == false)
        {
            BuzzSource.Play();
            //buzzSource.pitch = Random.Range(pitchRange[0], pitchRange[1]);
        }
        else if(isBuzzing == false && BuzzSource.isPlaying == true)
        {
            BuzzSource.Stop();
        }
        BuzzSource.pitch = Pitch;
    }

    public void AdjustPitch(float number)
    {
        Pitch = ((number + 6) / 6) + 1;
        //die Höhe (yPosition) schwankt zwischen -6 & 6, die Pitch-Höhe schwankt so zwischen 1 & 3
    }

}
