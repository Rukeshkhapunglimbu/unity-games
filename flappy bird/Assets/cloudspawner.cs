using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudspawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update

    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)

        {

            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, transform.position.y, 6), transform.rotation);
    }

}
