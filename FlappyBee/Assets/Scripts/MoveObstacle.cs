using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float obstacleSpeed;
    [SerializeField] private float lifespan;
    [SerializeField] private float startPositionX;
    private ObstacleSpawner obstacleSpawner;


    private void Awake()
    {
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    private void Start()
    {
        SetUpPosition();
    }

    private void Update()
    {
        StartCoroutine(DestroySelf());
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - (obstacleSpeed * Time.fixedDeltaTime), transform.position.y, 0);
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }

    private void SetUpPosition()
    {
        float positionDifference = obstacleSpawner.GetPosition();
        float startHeight = Random.Range(-positionDifference, positionDifference);
        transform.position = new Vector3(startPositionX, startHeight, 0);
    }

}
