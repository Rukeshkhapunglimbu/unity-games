using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playercontroller : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    public GameObject GameOverScreen;
    public GameManager gameManager;
    bool canJump;
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && IsGrounded())

        // if(Input.GetMouseButtonDown(0) && IsGrounded())
        {
            //jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            GameOver();
            // SceneManager.LoadScene("Game");
            Debug.Log("Collision with obstacle detected!");
        }
        if(other.gameObject.tag == "pass")
        {
            gameManager.ScoreUp();
        }
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;

    }
    public void RestartGame()
    {
        // Resume time
        Time.timeScale = 1;

        // Reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

}