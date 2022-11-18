using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAudio : MonoBehaviour
{
    [field: SerializeField] public AudioClip collisionClip{get; private set;}
    [field: SerializeField] public AudioClip buzzClip{get; private set;}
    [field: SerializeField] public AudioClip pointsClip { get; private set; }
    [field: SerializeField] public AudioClip schleckClip { get; private set; }
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

    public void PlaySchleckClip()
    {
        audioManagement.PlaySoundEffect(schleckClip);
    }
}
