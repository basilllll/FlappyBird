using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public float score;
    public Text ScoreUI;
    public GameObject pauseButton;
    public GameObject pauseMenu;
    public GameObject screenJump;
    public GameObject gameOverMenu;

    public void AddScore(int num)
    {
        score += num;
        ScoreUI.text = score.ToString();
    }

    public void PauseGame()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        screenJump.SetActive(false);
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        screenJump.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        screenJump.SetActive(false);
        gameOverMenu.SetActive(true);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
