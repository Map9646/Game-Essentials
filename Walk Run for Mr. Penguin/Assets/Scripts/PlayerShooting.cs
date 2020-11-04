using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int ammo = 10;
    public int maxAmmo = 10; 
    public GameObject prefab;
    public Transform instancer;
    public float reloadTime;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    
    private void Start()
    {
        ammo = maxAmmo; 
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            Fire();
        }
        
        
        if(Input.GetKeyDown(KeyCode.R))
        
        {
            StartCoroutine(Reload());
        }
    }

    private void Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        ammo--;

        if (ammo <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        
        var CountDown = reloadTime;
        while (CountDown > 0)
        {
            yield return wffu;
            CountDown = -0.1f; 
        }

        ammo = maxAmmo;
        
    }
}
