using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    bool mInvincible;
    public float Speed = 1;
    public float ShiftSpeed = 5;
    Rigidbody2D mRigidBody2D;
    GameObject mDeathParticleEmitter;
    Vector2 mFacingDirection;
    float kDamagePushForce = 2.5f;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(horizontal, 0, 0) * Speed;

    }

    public void Die()
    {
      
        Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void TakeDamage(int dmg)
    {
        if (!mInvincible)
        {
            Vector2 forceDirection = new Vector2(-mFacingDirection.x, 1.0f) * kDamagePushForce;
            mRigidBody2D.velocity = Vector2.zero;
            mRigidBody2D.AddForce(forceDirection, ForceMode2D.Impulse);
            mInvincible = true;
            Die();
        }
    }

}      


