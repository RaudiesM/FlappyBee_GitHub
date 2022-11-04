using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Obstacle
{
    [field: SerializeField, Range(-3, 3)] public float obstacleHeight { get; private set; }
    [field: SerializeField, Range(0, 3)]  public float gapHeight { get; private set; }
    [field: SerializeField, Range(0, 1)]  public float obstacleDistance { get; private set; }
}
