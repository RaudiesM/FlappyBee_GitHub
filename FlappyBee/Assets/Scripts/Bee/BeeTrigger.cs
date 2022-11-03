using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gap"))
        {
            Debug.Log("Punkt");
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("You hit something");
        }
    }

}
