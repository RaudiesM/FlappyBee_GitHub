using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    [field: SerializeField] public ObstaclePattern tutorialPattern { get; private set; }
    [field: SerializeField] public ObstaclePattern[] obstaclePatterns { get; private set; }

    public ObstaclePattern currentObstacle { get; private set;}
    private int lastIndex = 0;
    private int nextIndex = 0;

    private void Start()
    {
        currentObstacle = tutorialPattern;
    }

    public void switchPatterns()
    {
        while(lastIndex == nextIndex){
            nextIndex = Random.Range(0, obstaclePatterns.Length);
        }
        currentObstacle = obstaclePatterns[nextIndex];
        lastIndex = nextIndex;
    }

}



