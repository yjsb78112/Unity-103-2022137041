using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXConstructor : MonoBehaviour
{
    private int value; //����� ��������

    //������
   public EXConstructor(int _value)
    {
        value = _value;  //�����ڸ� ȣ�� �Ҷ� ���� ������ ���� ������ �Է�
        Debug.Log("��ü�� �����Ǿ����ϴ� . �ʱⰪ : " + value);
    }
    void Start()
    {
        //������ȣ��
        EXConstructor ex = new EXConstructor(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //�����̽��ٸ��������� �̰�ü�ı�
        {
            Destroy(this.gameObject);

        }
    }

    void Ondestory()
    {
        Debug.Log("��ü�� �ı��Ǿ����ϴ�");
    }
 
}
