using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] public float PositionXDifference { get; private set; }
    [SerializeField] public float PositionYDifference { get; private set; }
    [SerializeField] public float GapDifference { get; private set; }
    private ObstacleSpawnManager obstacleSpawnManager;
    private Obstacle obstacleInstance;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float startTime;
    [SerializeField] private float spawnTime;
    [SerializeField] private bool random;
    [SerializeField] private float obstacleHeight;
    [SerializeField]  private float gapHeight;
    [SerializeField]  private float obstacleDistance;
    private int index;

    private void Awake()
    {
        obstacleSpawnManager = FindObjectOfType<ObstacleSpawnManager>();
    }

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, spawnTime);
    }

    private void SpawnObstacle()
    {
        if (random)
        {
            SetupRandomVariables();
        }
        else
        {
            SetUpObstacleIndex();
            SetupVariables();
        }
        Instantiate(obstacle);
    }

    private void SetupVariables()
    {
        PositionXDifference = obstacleInstance.ObstacleDistance;
        PositionYDifference = obstacleInstance.ObstacleHeight;
        GapDifference = obstacleInstance.GapHeight;
    }

    private void SetupRandomVariables()
    {
        PositionXDifference = Random.Range(0, obstacleDistance);
        PositionYDifference = Random.Range(-obstacleHeight, obstacleHeight);
        GapDifference = Random.Range(0, gapHeight);
    }

    private void SetUpObstacleIndex()
    {
        obstacleInstance = obstacleSpawnManager.CurrentObstacle.Obstacles[index];
        if (index < obstacleSpawnManager.CurrentObstacle.Obstacles.Length - 1)
            {
                index++;
            }
        else
            {
                obstacleSpawnManager.SwitchPatterns();
                index = 0;
            }
    }
}