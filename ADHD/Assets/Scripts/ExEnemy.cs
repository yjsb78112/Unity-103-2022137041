using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnemy : MonoBehaviour
{
    //적이플레이어 에게주는 피해량
    private int damage = 20;
    public ExPlayer TargetPlayer;

    //플레이어에게 피해를 줄떄 호출되는 함수
    public void AtteckPlayer(ExPlayer player)
    {
        //플레이어 데미지
        player.TakeDamage(damage);
        Debug.Log("플레이어 공격.");
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AtteckPlayer(TargetPlayer);
        }
    }
}
