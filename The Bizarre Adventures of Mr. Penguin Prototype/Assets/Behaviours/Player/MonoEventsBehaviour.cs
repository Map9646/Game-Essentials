﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnableEvent, onDisableEvent;
    public float holdTime = 0f;
    public bool repeatOnStart;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    public void Restart()
    {
        StartCoroutine(Start());
    }
       
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();

        while (repeatOnStart)
        { 
            yield return new WaitForSeconds(holdTime);
            startEvent.Invoke();
        }
    }
    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    private void OnDisable()
    {
        onEnableEvent.Invoke();
    }
}
