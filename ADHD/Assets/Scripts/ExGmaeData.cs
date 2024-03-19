using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ExGameData" , fileName = "New Exgame Data" , order = 50)]
public class ExGmaeData : ScriptableObject//스크립터블 오브젝트 상속
{ 
    //게임관련 변수들 추가
    public string gameName;
    public int gameScore;
    public bool isGameActive;
}
