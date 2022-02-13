using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float move_Speed = 0.18f; //초기 속도 값
    float x_Speed = 0; //x축 방향의 속도 변수
    bool leftFlag = false; //방향 전환을 위한 변수 (참, 거짓)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_Speed = 0;

        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false; //참 혹은 거짓 값을 대입
        }

        else if (Input.GetKey("left"))
        {
            x_Speed = -move_Speed;
            leftFlag = true;
        }

    }

    private void FixedUpdate() //매 초마다 동일한 프레임을 위해 사용
    {
        this.transform.Translate(x_Speed, 0, 0); //오른쪽, 왼쪽, 위, 아래 오브젝트 이동 시
        this.GetComponent<SpriteRenderer>().flipX = leftFlag; //오른쪽, 왼쪽 방향 이동 시 스프라이트 방향도 함께 전환됨
    }
}
