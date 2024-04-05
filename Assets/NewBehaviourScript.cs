using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi");

        //1.변수
        int level = 45728;
        float strength = 9999.9f;
        string playerName = "민재";
        bool isFullLevel = false;

        Debug.Log("이름");
        Debug.Log(playerName);
        Debug.Log("레벨");
        Debug.Log(level);
        Debug.Log("힘");
        Debug.Log(strength);
        Debug.Log("만렙?");
        Debug.Log(isFullLevel);

        string[] monsters = { "준영", "현우", "승진" };
        int[] monstersTall = new int[3];
        monstersTall[2] = 181;
        monstersTall[1] = 195;
        monstersTall[0] = 185;

        Debug.Log("친구들");
        Debug.Log(monstersTall[1]);
        Debug.Log(monstersTall[2]);
        Debug.Log(monstersTall[0]);
    }

}
