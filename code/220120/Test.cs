using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour //클래스 이름은 스트립트 파일 이름과 동일해야 함
{
    // Start is called before the first frame update
    void Start() //매번 프레임이 갱신되어도 스타트 메소드 안에 있는 내용은 한번만 실행됨,
    {
        this.transform.Translate(10.0f, 0, 0); //이 스크립트가 속해 있는 게임 오브젝트를 이동시킨다. => Translate(x,y,z);
    }

    // Update is called once per frame
    void Update() //매 프레임마다 계속적으로 갱신, 추가되는 메소드로 계속적으로 실행됨.
    {
        
    }
}
