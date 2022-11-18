using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject panda;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float startTime;
    private float spawnTime;
    [SerializeField] private float[] range;


    private void Start()
    {
        spawnTime = Random.Range(range[0], range[1]);
        InvokeRepeating("SpawnPanda", startTime, spawnTime);
        panda.transform.position = startPosition;

    }

    private void SpawnPanda()
    {
        Instantiate(panda);
        spawnTime = Random.Range(range[0], range[1]);
    }

}
