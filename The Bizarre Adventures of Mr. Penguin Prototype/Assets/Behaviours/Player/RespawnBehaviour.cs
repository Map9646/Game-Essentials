using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBehaviour : MonoBehaviour
{
    public Vector3Data currentSpawnPoint;
    public FloatData health;
    //public GameObject player; 
    [SerializeField] private CharacterController controls;
        
        
    
    
    private void Start()
    {
        controls = GetComponent<CharacterController>();
        health.value = 100;
        transform.position = currentSpawnPoint.value; 
    }
    
    private void OnEnable()
    {
        //transform.position = currentSpawnPoint.value;
        health.value = 100f; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Trigger"))
        {
            transform.position = currentSpawnPoint.value; 
        }
    }


    public void Teleport()
    {
        
        
            controls.enabled = false;
            gameObject.transform.position = currentSpawnPoint.value;
            controls.enabled = true;





    }
    
}
    