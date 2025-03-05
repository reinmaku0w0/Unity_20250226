using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message:"你好，我在Start!");
    }
    
    private void Awake()
    {
        Debug.Log(message:"你好，我在Awake!");
    }
    
    private void OnEnable()
    {
        Debug.Log(message:"你好，我在OnEnable!");
    }
    
    private void OnDisable()
    {
        Debug.Log(message:"你好，我在OnDisable!");
    }
}
