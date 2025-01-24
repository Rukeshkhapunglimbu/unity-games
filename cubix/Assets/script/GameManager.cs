using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public Transform SpawnPoint;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // StartCoroutine("SpawnObstacles");

    }


    IEnumerator SpawnObstacles()
    {
        while (true)
        {

            float waitTime = Random.Range(0.2f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, SpawnPoint.position, Quaternion.identity);
        }
    }


    
    public void ScoreUp()
    {

        score++;
        scoreText.text = score.ToString();

    }

    public void GameStart()
    {

        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine(SpawnObstacles());
        // InvokeRepeating("ScoreUp", 2f, 1f);
    }

}

