using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    //protected로 선언된 변수는 같은 클래스및 파생클래스에서 접근 가능
    protected int protectedVale;
}

public class ExChildClass : ExParentClass //ExParentClass를상속
{
    void Start()
    {
        //ExParentClass의 Protected변수에 접근가능
        Debug.Log("Protected Value from Child Class : ");
    }
}