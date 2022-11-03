using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private BeeMovement beeMovement;
    private BeeCollision beeCollision;

    private void Awake()
    {
        beeMovement = FindObjectOfType<BeeMovement>();
        beeCollision = FindObjectOfType<BeeCollision>();
        PauseGame();
    }

    private void Update()
    {
        StartOnFirstMovement();
        PauseOnCollision();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void StartOnFirstMovement()
    {
        if (beeMovement.gameStart)
        {
            StartGame();
        }
    }
    void PauseOnCollision()
    {
        if (beeCollision.collided)
        {
            PauseGame();
        }
    }

}
