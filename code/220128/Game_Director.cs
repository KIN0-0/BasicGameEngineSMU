using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI를 쓸 때 필수 사용

public class Game_Director : MonoBehaviour
{
    GameObject player; //플레이어 오브젝트 대입할 변수 (데이터형 : GameObject)
    GameObject obj; //목표물 오브젝트를 대입할 변수 (데이터형 : GameObject)
    GameObject dis; //플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI오브젝트를 대입할 변수

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("mongmong");
        this.obj = GameObject.Find("choco");
        this.dis = GameObject.Find("Dis");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.obj.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.dis.GetComponent<Text>().text = "Goal " + ": " + lengthDis.ToString("F3") + "m";
        }
        //ToString("D숫자") 정수형, 숫자는 자리수 ToStrimg("D숫자") ToString("F숫자") 소수점 이하 자리수


        else //lengthDis가 0보다 작아졌다면
        {
            this.dis.GetComponent<Text>().text = "OMG!\nyou got the chocolate!"; //메세지 출력
        }
    }
}
