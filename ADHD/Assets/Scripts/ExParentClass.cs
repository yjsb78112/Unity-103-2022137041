using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    //protected�� ����� ������ ���� Ŭ������ �Ļ�Ŭ�������� ���� ����
    protected int protectedVale;
}

public class ExChildClass : ExParentClass //ExParentClass�����
{
    void Start()
    {
        //ExParentClass�� Protected������ ���ٰ���
        Debug.Log("Protected Value from Child Class : ");
    }
}