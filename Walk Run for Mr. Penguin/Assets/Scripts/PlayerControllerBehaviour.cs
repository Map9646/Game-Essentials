using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(CharacterController))]
public class PlayerControllerBehaviour : MonoBehaviour
{
    public CharacterController controls;

    public Vector3 movement;

    public float gravity = -9.18f,
        rotateSpeed = 100f,
        moveSpeed = 10f,
        fastSpeed = 20f,
        normalSpeed = 10f,
        jumpCount,
        jumpForce = 5f;
    
        

    public FloatData playerJumpCount; 

    private float yVar;

    void Start()
    {

        controls = GetComponent<CharacterController>();

    
        
    }
    
    private void Update()
    {
        yVar += gravity * Time.deltaTime;
        
        var vInput = Input.GetAxis("Vertical") * moveSpeed;
        movement.Set(vInput, yVar, 0);

        var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, hInput, 0);
        
        if (controls.isGrounded && movement.y < 0)
        {
            movement.y = -1f;
            jumpCount = 0f; 
        }

        movement = transform.TransformDirection(movement);
        controls.Move(movement * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
            print(" Jump");
        }
        
        
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {

            moveSpeed = fastSpeed; 

        }
        else
        {
            moveSpeed = normalSpeed; 
        }

        
        
        
    }

    
}
    
    





