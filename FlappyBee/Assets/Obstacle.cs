using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Obstacle
{
    [SerializeField, Range(-3, 3)] private float obstacleHeight;
    [SerializeField, Range(0, 3)] private float gapHeight;
    [SerializeField, Range(0, 1)] private float obstacleDistance;

}
