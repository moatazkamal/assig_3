using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class Playercontroller : MonoBehaviour
{
    public float speed = 19.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("the game has started");
        
    }

    // Update is called once per frame
    void Update()
    {   // get player input 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // craete a movement vector 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // move the player 
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
