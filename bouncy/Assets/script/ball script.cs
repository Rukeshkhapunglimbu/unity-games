using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ballscript : MonoBehaviour
{
    // Start is called before the first frame update
    public gamemanager games;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnMouseDown()
    {
  Destroy(gameObject);
        // GameObject.Find("game manager").GetComponent<gamemanager>().scoreUp();
      
    games.scoreUp();
    }
    

}
