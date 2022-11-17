using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject panda;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float startTime;
    [SerializeField] private float spawnTime;


    private void Start()
    {
        InvokeRepeating("SpawnPanda", startTime, spawnTime);
        panda.transform.position = startPosition;

    }

    private void SpawnPanda()
    {
        Instantiate(panda);
        spawnTime = Random.Range(60, 100);
    }

}
