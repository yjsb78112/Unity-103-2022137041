using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ExGameData" , fileName = "New Exgame Data" , order = 50)]
public class ExGmaeData : ScriptableObject//��ũ���ͺ� ������Ʈ ���
{ 
    //���Ӱ��� ������ �߰�
    public string gameName;
    public int gameScore;
    public bool isGameActive;
}
