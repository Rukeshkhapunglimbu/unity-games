using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscrit : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool birdIsAlive = true;
    public float forwardSpeed;
    public float maxSpeed;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetKeyDown(KeyCode.Space)) && birdIsAlive)
       { 
           myRigidbody.velocity = Vector2.up * flapstrength;
       }
    if (forwardSpeed < maxSpeed)
    forwardSpeed =+ 0.1f * Time.deltaTime;
    //    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
    //     {
    //         myRigidbody.velocity = Vector2.up * flapstrength;
    //     }

        if (transform.position.y > 8 || transform.position.y < -8)
        {
            Debug.Log("bird fall");
            logic.gameOver();
            birdIsAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
