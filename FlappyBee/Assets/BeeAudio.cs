using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAudio : MonoBehaviour
{
    [field: SerializeField] public AudioClip collisionClip{get; private set;}
    [field: SerializeField] public AudioClip buzzClip{get; private set;}
    [field: SerializeField] public AudioClip pointsClip { get; private set; }
    [SerializeField] private AudioClip backgroundMusic;
    private AudioManagement audioManagement;

    private void Awake()
    {
        audioManagement = FindObjectOfType<AudioManagement>();
    }

    public void PlayPointsClip()
    {
        audioManagement.PlaySoundEffect(pointsClip);
    }

    public void PlayCollisionClip()
    {
        audioManagement.PlaySoundEffect(collisionClip);
    }

    public void PlayBuzzClip()
    {
        audioManagement.PlaySoundEffect(buzzClip);
    }
}
