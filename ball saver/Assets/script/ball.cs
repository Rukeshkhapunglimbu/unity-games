using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    bool gameStarted;
   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            if(Input.anyKeyDown)
                 {
                    StartBounce();
                    gameStarted = true;
                    gamemanager.instance.StartGame();
                  }
        }
        
    }
    public void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), 1f);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "fallcheck")
        {
            gamemanager.instance.Restart(); 
        }
        else if(collision.gameObject.tag == "paddle")
        {
            gamemanager.instance.ScoreUp();
        }

    }
  
}
