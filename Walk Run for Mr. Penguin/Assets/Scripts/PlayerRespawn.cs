using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerRespawn : MonoBehaviour
{
    public Vector3Data currentSpawnPoint;
    public FloatData health;
    [SerializeField] private CharacterController controls;
    
    


    private void Start()
    {
        controls = GetComponent<CharacterController>();
        StartCoroutine(Time()); 
    }

    private void OnEnable()
    {
        transform.position = currentSpawnPoint.value;
        health.value = 100f; 
    }
    private void Update()
    {
        if (health.value <= 0)
        {
            controls.enabled = false;
            transform.position = currentSpawnPoint.value; 
        }

        if (transform.position == currentSpawnPoint.value)
        {
            health.value = 100;
            controls.enabled = true; 
        }
    }




    IEnumerator Time()
    {
        yield return new  WaitForSeconds(5);
    }
    

}



   


