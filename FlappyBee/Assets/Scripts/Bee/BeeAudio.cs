using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAudio : MonoBehaviour
{
    [field: SerializeField] public AudioClip CollisionClip{get; private set;}
    [field: SerializeField] public AudioClip PointsClip{ get; private set; }
    [field: SerializeField] public AudioClip SchleckClip{ get; private set; }
    //[field: SerializeField] public AudioClip buzzClip{get; private set;}
    private AudioManagement audioManagement;

    private void Awake()
    {
        audioManagement = FindObjectOfType<AudioManagement>();
    }

    public void PlayPointsClip()
    {
        audioManagement.PlaySoundEffect(PointsClip);
    }

    public void PlayCollisionClip()
    {
        audioManagement.PlaySoundEffect(CollisionClip);
    }

    /*public void PlayBuzzClip()
    {
        audioManagement.PlaySoundEffect(buzzClip);
    }*/

    public void Buzzing(bool isBuzzing, float yPosition)
    {
        audioManagement.PlayBuzzSound(isBuzzing);
        audioManagement.AdjustPitch(yPosition);
    }

    public void PlaySchleckClip()
    {
        audioManagement.PlaySoundEffect(SchleckClip);
    }
}
