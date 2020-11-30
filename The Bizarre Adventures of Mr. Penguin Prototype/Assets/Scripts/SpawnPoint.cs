using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data currentSpawnPoint;
    

    private void OnTriggerEnter(Collider other)
    {
        currentSpawnPoint.value = transform.position; 
    }

}
