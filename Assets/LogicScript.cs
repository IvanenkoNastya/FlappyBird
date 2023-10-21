using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour {
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource sergeyProkofevTanecRycarey;

    [ContextMenu("Increase Score1")]
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        sergeyProkofevTanecRycarey.Play();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        sergeyProkofevTanecRycarey.Play();
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

}
