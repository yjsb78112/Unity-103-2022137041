using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnemy : MonoBehaviour
{
    //�����÷��̾� �����ִ� ���ط�
    private int damage = 20;
    public ExPlayer TargetPlayer;

    //�÷��̾�� ���ظ� �ً� ȣ��Ǵ� �Լ�
    public void AtteckPlayer(ExPlayer player)
    {
        //�÷��̾� ������
        player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����.");
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AtteckPlayer(TargetPlayer);
        }
    }
}
