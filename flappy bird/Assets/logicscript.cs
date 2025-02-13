using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public int highScore;
    public Text highScoreText;
    public GameObject playbutton;
    public audioscript audio;
    void Start()
    
    
    {
        Time.timeScale = 0f;
    }
    public void PlayGame()
    {
        Time.timeScale = 1f;
        playbutton.SetActive(false);
        audio.PlayMusic();
    }
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

     public void gameOver()
    //  {
    //     // Check for a new high score
    //     if (playerScore > highScore)
    //     {
    //         highScore = playerScore;
    //         PlayerPrefs.SetInt("HighScore", highScore); // Save the new high score
    //     }

    //     // Show Game Over UI
    //     if (gameOverScreen != null)
    //     {
    //         gameOverScreen.SetActive(true);
    //         highScoreText.text = "High Score: " + highScore.ToString(); // Display high score
    //     }

    //     // Pause the game
    //     Time.timeScale = 0;
    // }

    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        //audio pause
        audio.PauseMusic();
    }
    void Update()
    {
        if(PlayerPrefs.HasKey("highScore")){
            highScore = PlayerPrefs.GetInt("highScore");
        }

        if (playerScore > PlayerPrefs.GetInt("highScore"))
        {
            Debug.Log("gdh");
            PlayerPrefs.SetInt("highScore", playerScore);

        }
        highScoreText.text = highScore.ToString();

    }

    public void RestartGame()
    { 
        // Resume time
        Time.timeScale = 1;

        // Reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    // {
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    // }
}
