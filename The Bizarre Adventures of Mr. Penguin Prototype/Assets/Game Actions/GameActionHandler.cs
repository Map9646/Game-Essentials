﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class GameActionHandler : MonoBehaviour
{
    public GameActions gameAction;
    public UnityEvent handlerEvent;
    public float holdTime;
    private void Start()
    {
        gameAction.action += ActionHandler;  
    }
    private void ActionHandler()
    {
        Invoke(nameof(OnActionHandler), holdTime);
    }
    
    private void OnActionHandler()
    {
        handlerEvent.Invoke();
    }
}

