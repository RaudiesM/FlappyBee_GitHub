using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanda : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float pandaSpeed;
    [SerializeField] private float lifespan;


    private void Start()
    {
        StartCoroutine(DestroySelf());
    }

    private void Update()
    {
        HandleObstacleMovement();
    }

    

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }
  
    void HandleObstacleMovement()
    {
        transform.position = new Vector3(
            transform.position.x - (pandaSpeed * Time.deltaTime),
            transform.position.y,
            transform.position.z
        );
    }
}

