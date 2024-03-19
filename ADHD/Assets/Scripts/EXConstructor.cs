using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXConstructor : MonoBehaviour
{
    private int value; //사용할 변수설정

    //생성자
   public EXConstructor(int _value)
    {
        value = _value;  //생성자를 호출 할때 받은 변수를 메인 변수에 입력
        Debug.Log("객체가 생성되었습니다 . 초기값 : " + value);
    }
    void Start()
    {
        //생성자호출
        EXConstructor ex = new EXConstructor(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //스페이스바를눌렀을때 이객체파괴
        {
            Destroy(this.gameObject);

        }
    }

    void Ondestory()
    {
        Debug.Log("객체가 파괴되었습니다");
    }
 
}
