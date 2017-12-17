using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireRotation : MonoBehaviour {
    bool mRotation;

    Animator mAnimator;
    Rigidbody2D mRigidBody2D;
    
    
    void Start () {
        mAnimator = GetComponent<Animator>();
	}


    void Update()
    {
        mRotation = false;
        if (Input.GetButton("Left"))
        {
            transform.Translate(-Vector2.right * Time.deltaTime, Space.World);
            mRotation = true;
        }
        if (Input.GetButton("Right"))
        {
            transform.Translate(Vector2.right * Time.deltaTime, Space.World);
            mRotation = true;
        }
        UpdateAnimator();
    }
        public void UpdateAnimator()
    {
        mAnimator.SetBool("isRotating", mRotation);

    }
}
