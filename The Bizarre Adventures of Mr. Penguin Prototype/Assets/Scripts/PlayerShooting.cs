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
    public WaitForFixedUpdate wfs = new WaitForFixedUpdate();
    private bool canShoot; 
    
    private void Start()
    {
        ammo = maxAmmo; 
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0 && canShoot)
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

        if (ammo == 0)
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        canShoot = false; 
        
        var countDown = reloadTime;
        while (countDown > 0)
        {
            yield return wfs;
            countDown = .01f; 
        }

        ammo = maxAmmo;
        canShoot = true; 
    }
}
