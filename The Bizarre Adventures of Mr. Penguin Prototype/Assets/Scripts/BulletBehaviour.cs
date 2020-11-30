using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    public float bulletForce;
    //private float lifeTime;
    //private WaitForSeconds wfs; 

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        
        rBody.AddRelativeForce(Vector3.right * bulletForce);
        //yield break;
        //yield return new WaitForSeconds(lifeTime);
        //Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
        }
    }
}


