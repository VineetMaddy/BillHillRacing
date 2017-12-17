using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float speed = 3000f;
    public float rotationSpeed = 15f;
    public float JumpSpeed = 10;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;


    private float movement = 0f;
    private float rotation = 0f;
    

   

    void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");
        float Jump = Input.GetAxisRaw("Jump");

        transform.position += new Vector3(0, Jump, 0) * Time.deltaTime * JumpSpeed;


    }
    void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
        
    }

}