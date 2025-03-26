
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;
    public void SetHp(int hpValue)
    {
        hp = hpValue;
    }
    
    public void TakeDamage(int damage)
    {
        //hp = hp - damage;
        hp -= damage;
        bool isDead = hp <= 0;
        if (isDead)
        {
            hp = 0;
        }
    }
    
    public int GetHp()
    {
       return hp;
    }
}
