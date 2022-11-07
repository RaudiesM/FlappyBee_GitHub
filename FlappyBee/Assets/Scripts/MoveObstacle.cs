using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private GameObject topObstacle; 
    [SerializeField] private GameObject bottomObstacle;

    [SerializeField, Range(0, 10)] private float obstacleSpeed;
    [SerializeField] private float lifespan;
    [SerializeField] private float startPositionX;
    private ObstacleSpawner obstacleSpawner;
    private float currentXPosition;
    private float currentYPosition;
    private float currentGapHeight;

    public bool correctTop { get; private set; }
    public bool correctBottom { get; private set; }

    private void Awake()
    {
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    private void Start()
    {
        TakeValuesOfObstacleManager();

        CheckForOutOfBounds();
        SetUpPosition(currentXPosition, currentYPosition);
        SetUpGap(currentGapHeight);
    }


    private void Update()
    {
        StartCoroutine(DestroySelf());
    }

    private void FixedUpdate()
    {
        HandleObstacleMovement();

    }
    private void TakeValuesOfObstacleManager()
    {
        currentXPosition = obstacleSpawner.positionXDifference;
        currentYPosition = obstacleSpawner.positionYDifference;
        currentGapHeight = obstacleSpawner.gapDifference;
    }

    private void CheckForOutOfBounds()
    {
        if(currentYPosition > 1.2f || currentYPosition < 0)
        {
            float differenceSum = Mathf.Abs(currentYPosition) + currentGapHeight;
            if (differenceSum >= 3)
            {
                if (currentYPosition > 0)
                {
                    correctTop = true;
                }
                else
                {
                    correctBottom = true;
                }
            }
        }
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }

    private void SetUpPosition(float xDifference, float yDifference)
    {
        transform.position = new Vector3(startPositionX + xDifference, yDifference, 0);
        Debug.Log(xDifference);
    }

    private void SetUpGap(float gapDifference)
    {
        if (correctTop)
        {
            topObstacle.transform.position += new Vector3(0, 0, 0);
        }
        else
        {
            topObstacle.transform.position += new Vector3(0, gapDifference, 0);
        }

        if (correctBottom)
        {
            bottomObstacle.transform.position -= new Vector3(0, 0, 0);
        }
        else
        {
            bottomObstacle.transform.position -= new Vector3(0, gapDifference, 0);
        }
    }

    void HandleObstacleMovement()
    {
            transform.position = new Vector3(
                transform.position.x - (obstacleSpeed * Time.fixedDeltaTime),
                transform.position.y, 
                0
            );
    }

}
