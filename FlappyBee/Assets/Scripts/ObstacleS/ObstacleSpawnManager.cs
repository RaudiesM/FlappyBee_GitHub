using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    [field: SerializeField] public ObstaclePattern TutorialPattern { get; private set; }
    [field: SerializeField] public ObstaclePattern[] ObstaclePatterns { get; private set; }
    public ObstaclePattern CurrentObstacle { get; private set;}
    private int lastIndex = 0;
    private int nextIndex = 0;

    private void Start()
    {
        CurrentObstacle = TutorialPattern;
    }

    public void SwitchPatterns()
    {
        while(lastIndex == nextIndex){
            nextIndex = Random.Range(0, ObstaclePatterns.Length);
        }
        CurrentObstacle = ObstaclePatterns[nextIndex];
        lastIndex = nextIndex;
    }

}



