using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gamemanager instance;
    public GameObject restarButton;


    public GameObject winText;
    int score = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void scoreUp()
    {
        score++;
        Debug.Log("score add ");
        if (score >= 4)
        {
            Debug.Log("score ");
            Win();
        }
    }

    void Win()
    {

        winText.SetActive(true);
        restarButton.SetActive(true);

    }
    public void ReStart()
    {
        SceneManager.LoadScene("game");
    }

}
