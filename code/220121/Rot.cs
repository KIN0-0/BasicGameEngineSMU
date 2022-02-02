using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour //클래스 이름 작성
{
    public int rot_a = 0; //초기 회전 값

    // Start is called before the first frame update
    void Start()
    {
       this.transform.Rotate(0, rot_a, 0); //y축 회전
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.Rotate(0, rot_a, 0); y축이 매 프레임마다 회전
}
}
