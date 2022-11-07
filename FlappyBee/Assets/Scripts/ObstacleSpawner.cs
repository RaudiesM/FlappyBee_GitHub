using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    private Obstacle obstacleInstance;
    [SerializeField] private float startTime;
    [SerializeField] private float spawnTime;
    /// positionDifference kann entfernt werden, 
    
    [SerializeField] public float positionXDifference { get; private set; }
    [SerializeField] public float positionYDifference { get; private set; }
    [SerializeField] public float gapDifference { get; private set; }

    [SerializeField] private bool random;

    ObstacleSpawnManager obstacleSpawnManager;

    int index;


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
        //obstacle.transform.position = new Vector3(10, 10, 0);
    }

    private void SetupVariables()
    {
        positionXDifference = obstacleInstance.obstacleDistance;
        positionYDifference = obstacleInstance.obstacleHeight;
        gapDifference = obstacleInstance.gapHeight;
    }

    private void SetupRandomVariables()
    {
        positionXDifference = Random.Range(0, 4);
        positionYDifference = Random.Range(-3, 3);
        gapDifference = Random.Range(0, 3);
    }

    private void SetUpObstacleIndex()
    {
        obstacleInstance = obstacleSpawnManager.currentObstacle.obstacles[index];
        if (index < obstacleSpawnManager.currentObstacle.obstacles.Length - 1)
        {
            index++;
        }
        else
        {
            Debug.Log("nextPattern");
            obstacleSpawnManager.switchPatterns();
            index = 0;
        }

    }
}