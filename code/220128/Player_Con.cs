using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Con : MonoBehaviour
{
    float speed = 0; //변수 선언
    private AudioSource audio;
    public AudioClip Woof;
    Vector2 startPos; //마우스를 눌렀을 때의 위치값이 들어갈 변수
    Vector2 endPos; //마우스를 눌렀다 떼었을 때의 위치값이 들어갈 변수
    //2차원 좌표의 벡터(x, y). 벡터3은 (x, y, z).

    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.Woof;
        this.audio.loop = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽 버튼 클릭 시 
        {
            this.startPos = Input.mousePosition; //마우스 버튼으로 눌렀을 때의 좌표값
            GetComponent<AudioSource>().Play();
        }
  
        else if (Input.GetMouseButtonUp(0)) //마우스 눌렀다가 떼었다면
        {
            this.endPos = Input.mousePosition; //뗐을 때의 좌표값
            float length = (this.endPos.x - this.startPos.x); //마지막 좌표값 - 처음 좌표값
            this.speed = length / 5000.0f;
            GetComponent<AudioSource>().Play();
        }
        
        transform.Translate(this.speed, 0, 0); //+x방향으로 이동
        this.speed *= 0.98f; // 감속
    }
}
