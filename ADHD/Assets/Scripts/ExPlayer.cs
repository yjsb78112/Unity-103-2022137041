using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{

    private int health = 100; //플레이어 체력
    
    //플레이어가 피해를받을떄 호출되는 메서스
    public void TakeDamage(int damge)
    {
        //체력감소
        health -= damge;
        //체력이0이하로떨어졌을경우 플레이어 사망처리
        if(health <=0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        Debug.Log("플레이어가 사망했습니다.");
        //사망로직추가
    }
}
