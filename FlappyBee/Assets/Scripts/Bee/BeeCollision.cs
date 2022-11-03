using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeCollision : MonoBehaviour
{
    private BeeAudio beeAudio;
    public bool collided { get; private set; }

    private void Start()
    {
        beeAudio = FindObjectOfType<BeeAudio>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            beeAudio.PlayCollisionClip();
            collided = true;
        }
    }
}
