using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    public float moveSpeed = 20f;
    public float gravity = -9.18f;
    private float yVar;
    public Vector3 movement; 
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float vInput = moveSpeed * (Input.GetAxis("Vertical") * Time.fixedDeltaTime);
        movement.Set(vInput, yVar, 0);

        float hInput = moveSpeed * (Input.GetAxis("Horizontal")*Time.deltaTime);
          
        
        yVar += gravity*Time.deltaTime; 

        if(rBody.useGravity && movement.y < 0)
        {
            yVar = -1f; 
            
        }
        
        movement = transform.TransformDirection(movement);
        rBody.MovePosition(movement*Time.fixedDeltaTime);
        
    }
}
