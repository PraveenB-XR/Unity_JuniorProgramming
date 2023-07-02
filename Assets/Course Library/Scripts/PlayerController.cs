using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 35.0f;

    private float _horizontalInput;
    private float _forwardInput;

   
    // Update is called once per frame
    void Update()
    {
        //This is for getting Inputs controls for hori and Vert axes
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward       
        transform.Translate(Vector3.forward * Time.deltaTime * speed * _forwardInput);

        // Turn the vehicle with horiz axes input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _horizontalInput);
    }
}
