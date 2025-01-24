using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gamemanager instance;
    int score;
    public Text scoreText;  
    public GameObject GameStarttUI;
    public void Awake()
    {
        instance = this;
    }
    public void StartGame()
    {
     GameStarttUI.SetActive(false);
     scoreText.gameObject.SetActive(true);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
      public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }

}