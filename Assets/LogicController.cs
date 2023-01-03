using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicController : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;

    //[ContextMenu("Add Score")]
    public void AddScore (int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
