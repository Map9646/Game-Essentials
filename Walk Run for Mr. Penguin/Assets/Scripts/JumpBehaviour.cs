using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    public CharacterController controls;
    public float jumpCount= 2f, jumpForce = 10f, gravity = -9.81f, moveSpeed = 10f;
    public  Vector3 movement;
    public FloatData playerJumpCount; 

    void Start()
    {
        controls = GetComponent<CharacterController>();
    }


    void Update()
    {
       
        
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        controls.Move((movement) * Time.deltaTime);
        movement.y += gravity*Time.deltaTime;
        
        
        if (controls.isGrounded && movement.y < 0)
        {
            movement.y = -1f;
            jumpCount = 0f; 
        }

        
        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            movement.y = jumpForce;
            jumpCount ++; 
            print(" Jump");
        }







    }
}
