using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{

    private int health = 100; //�÷��̾� ü��
    
    //�÷��̾ ���ظ������� ȣ��Ǵ� �޼���
    public void TakeDamage(int damge)
    {
        //ü�°���
        health -= damge;
        //ü����0���Ϸζ���������� �÷��̾� ���ó��
        if(health <=0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        Debug.Log("�÷��̾ ����߽��ϴ�.");
        //��������߰�
    }
}
