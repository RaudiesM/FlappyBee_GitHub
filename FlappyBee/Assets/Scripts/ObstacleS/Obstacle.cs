using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Obstacle
{
    [field: SerializeField, Range(-3, 3)] public float ObstacleHeight { get; private set; }
    [field: SerializeField, Range(0, 3)]  public float GapHeight { get; private set; }
    [field: SerializeField, Range(0, 4)]  public float ObstacleDistance { get; private set; }
}
