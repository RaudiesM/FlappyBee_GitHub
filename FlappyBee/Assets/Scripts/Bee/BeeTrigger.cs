using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeTrigger : MonoBehaviour
{
    public bool HitPoints { get; private set; }
    public bool Collided { get; private set; }
    private BeeAudio beeAudio;

    private void Start()
    {
        beeAudio = FindObjectOfType<BeeAudio>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gap"))
        {
            HitPoints = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            beeAudio.PlayCollisionClip();
            Collided = true;
        }
    }

    public void ResetPointBool()
    {
        HitPoints = false;
    }
}
