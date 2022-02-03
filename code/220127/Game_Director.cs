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
        this.dis.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString() + "m";
    }
}
