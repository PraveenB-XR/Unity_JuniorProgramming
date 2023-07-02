using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float forwardSpeed = 0.0f;
    public float inclineSpeed = 0.0f;
    public float flipSpeed = 0.0f;
    public Transform Propeler;


    private float _horizontalInput;
    private float _verticalInput;
    private float _rotateInput;

    private void Update()
    {
           // Getting Axis Input and storing value in Float
         _horizontalInput = Input.GetAxis("Horizontal");
         _verticalInput = Input.GetAxis("Vertical");
        _rotateInput = Input.GetAxis("Horizontal");

         // Moving plane forward at certain Speed
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

        // Rotating Plane up and down, side flip using turn angle and input axes on x axis
        // then soring on float _vertical Input & _roatateinput
        transform.Rotate(Vector3.right, Time.deltaTime * inclineSpeed * _verticalInput);
        transform.Rotate(Vector3.back, Time.deltaTime * flipSpeed*  _rotateInput);
        PropelerSpin();
    }

    public void PropelerSpin()
    {
        Propeler.Rotate(new Vector3(0,0, 720f * Time.deltaTime * 2));
    }


}
