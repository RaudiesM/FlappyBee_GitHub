using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float startTime;
    [SerializeField] private float spawnTime;
    [SerializeField] private float positionDifference;
    [SerializeField] private float maxDifference;
    [SerializeField] private float increaseDifference;
    [SerializeField] private float increaseDifferenceTime;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, spawnTime);
        InvokeRepeating("IncreaseDifference", increaseDifferenceTime, increaseDifferenceTime);

    }
    private void SpawnObstacle()
    {
        Instantiate(obstacle);
    }

    private void IncreaseDifference()
    {
        if(positionDifference < maxDifference)
        {
            positionDifference += increaseDifference;
        }
        
    }

    public float GetPosition()
    {
        return positionDifference;
    }
}
