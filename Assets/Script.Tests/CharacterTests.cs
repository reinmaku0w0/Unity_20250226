
using NUnit.Framework;
using UnityEngine;

public class CharacterTests : MonoBehaviour
{
    [Test(Description = "角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {
        //arrange(安排+宣告)
        //建立玩家角色的元件
        var cc = new GameObject();
        cc.AddComponent<Character>();
        var character = cc.GetComponent<Character>();
        character.SetAtk(atkValue:10);
        
        //建立敵人的元件
        var ee = new GameObject();
        ee.AddComponent<Enemy>();
        var enemy = ee.GetComponent<Enemy>();
        enemy.SetHp(hpValue:100);
        
        //act(動作執行)
        character.Attack(enemy);
        
        //assert(驗證)
        var hp = enemy.GetHp();
        Assert.AreEqual(90, hp);
    }
    
    
    [Test(Description = "攻擊已死亡的敵人，血量最低為0")]
    public void Character_Attack_Dead_Enemy()
    {
        //arrange(安排+宣告)
        //建立玩家角色的元件
        var cc = new GameObject();
        cc.AddComponent<Character>();
        var character = cc.GetComponent<Character>();
        character.SetAtk(atkValue:90);
        
        //建立敵人的元件
        //var ee = new GameObject();
        //ee.AddComponent<Enemy>();
        //var enemy = ee.GetComponent<Enemy>();
        //enemy.SetHp(hpValue:100);
        
        var enemy = new GameObject().AddComponent<Enemy>();
        enemy.SetHp(hpValue:100);
        
        //act(動作執行)
        character.Attack(enemy);
        character.Attack(enemy);
        
        //assert(驗證)
        var hp = enemy.GetHp();
        Assert.AreEqual(0, hp);
    }

}
