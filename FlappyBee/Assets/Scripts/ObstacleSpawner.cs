using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float startTime;
    [SerializeField] private float spawnTime;
    /// positionDifference kann entfernt werden, 
    
    [SerializeField] private float positionDifference;


    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, spawnTime);
    }
    private void SpawnObstacle()
    {
        Instantiate(obstacle);
        //obstacle.transform.position = new Vector3(10, 10, 0);
    }

    public float GetPosition()
    {
        return positionDifference;
    }
}