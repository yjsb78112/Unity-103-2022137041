using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    //public ����Ⱥ����� �ٸ���ũ��Ʈ���� ���� ���� ����
    public int publicVlaue;

    //private���� ����� ������ ���� Ŭ���� �������� ���� ����
    private int privateValue;

    //protecte�� ����� ������ ���� Ŭ���� �� �Ļ� Ŭ�������� ���� ����
    protected int protectedValue;

    //internal�� ����� ������ ���� ������Ʈ ������ ���ٰ���
    internal int internalValue;

    //Start �Լ���Unity��ȣ���ϴ� �޼����̹Ƿ� public���� �����ؾ���

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
