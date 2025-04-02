
using System;
using NUnit.Framework;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int atk;
    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(atk);
    }
    
    public void SetAtk(int atkValue)
    {
        atk = atkValue;
    }

    //攻擊偵測到的所有敵人
    public void AttackAllTriggeredEnemies()
    {
        foreach (var enemy in enemies)
        {
            enemy.TakeDamage(atk);
        }
    }

    //偵測到的敵人
    private List<Enemy> enemies = new List<Enemy>();
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        var enemy = collider2D.GetComponent<Enemy>();
        enemies.Add(enemy);
    }
}
