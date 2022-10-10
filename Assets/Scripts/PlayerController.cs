using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 15.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Player Movement
        horizontalInput = Input.GetAxis("Horizontal")*turnspeed;
        forwardInput = Input.GetAxis("Vertical")*speed;

        //Move the vehicle forward, turn
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput);
        
    }
}
