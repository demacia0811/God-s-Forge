using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi");

        //1.����
        int level = 45728;
        float strength = 9999.9f;
        string playerName = "����";
        bool isFullLevel = false;

        Debug.Log("�̸�");
        Debug.Log(playerName);
        Debug.Log("����");
        Debug.Log(level);
        Debug.Log("��");
        Debug.Log(strength);
        Debug.Log("����?");
        Debug.Log(isFullLevel);

        string[] monsters = { "�ؿ�", "����", "����" };
        int[] monstersTall = new int[3];
        monstersTall[2] = 181;
        monstersTall[1] = 195;
        monstersTall[0] = 185;

        Debug.Log("ģ����");
        Debug.Log(monstersTall[1]);
        Debug.Log(monstersTall[2]);
        Debug.Log(monstersTall[0]);
    }

}
