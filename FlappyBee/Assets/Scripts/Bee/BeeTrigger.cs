using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeTrigger : MonoBehaviour
{
    public bool hitPoints { get; private set; }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gap"))
        {
            hitPoints = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("You hit something");
        }
    }

    public void ResetPointBool()
    {
        hitPoints = false;
    }

}
