using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private BeeMovement beeMovement;
    private BeeTrigger beeTrigger;
    [SerializeField] private GameObject endscreen;

    private void Awake()
    {
        beeMovement = FindObjectOfType<BeeMovement>();
        beeTrigger = FindObjectOfType<BeeTrigger>();
        PauseGame();
    }

    private void Update()
    {
        StartOnFirstMovement();
        PauseOnCollision();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void LoadGame()
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

    private void PauseOnCollision()
    {
        if (beeTrigger.Collided)
        {
            PauseGame();
            LoadEndscreen(true);
        }
    }

    private void LoadEndscreen(bool isActive)
    {
        endscreen.SetActive(isActive);
    }
}
