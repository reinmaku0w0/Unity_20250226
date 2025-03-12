using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    [SerializeField] private GameObject ccc;
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(message:"完美落地!10分!!");
        //碰到後隱藏自己
        //gameObject.SetActive(false);
        //碰到後隱藏對方
        //col.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(message:"偵測到了!!");
        
        //偵測到的變數名稱
        Debug.Log(col.gameObject.name);
        
        //物件不隱藏才能偵測
        //GameObject CC = GameObject.Find("圓");
        
        ccc.SetActive(true);
    }
}
