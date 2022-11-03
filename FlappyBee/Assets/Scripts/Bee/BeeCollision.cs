using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeCollision : MonoBehaviour
{
    public bool collided { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            collided = true;
        }
    }
}
