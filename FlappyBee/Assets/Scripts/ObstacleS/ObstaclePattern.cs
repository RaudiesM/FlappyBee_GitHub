using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ObstaclePattern
{
    [field: SerializeField] public Obstacle[] Obstacles { get; private set; }

}
