using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //속도값 이 변수는 퍼블릭변수이기 때문에 인스펙터에서 변경이 가능하다.
 
    void Start()
    {
        
    }

    void Update() //매 프레임마다 계속 실행. 속도차 존재. 일정히 하려면 FixedUpdate
    {
        this.transform.Translate(speed / 50, 0, 0); //수평이동(+x축 방향으로 이동)
    }
}
