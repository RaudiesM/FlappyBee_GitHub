using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject panda;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float startTime;
    [SerializeField] private float[] spawnRange = {0 , 0};
    private float spawnTime;

    private void Start()
    {
        spawnTime = Random.Range(spawnRange[0], spawnRange[1]);
        InvokeRepeating("SpawnPanda", startTime, spawnTime);
        panda.transform.position = startPosition;
    }

    private void SpawnPanda()
    {
        Instantiate(panda);
        spawnTime = Random.Range(spawnRange[0], spawnRange[1]);
    }
}
