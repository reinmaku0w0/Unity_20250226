using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(message:"完美落地!10分!!");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(message:"偵測到了!!");
    }
}
