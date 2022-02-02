using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Flip : MonoBehaviour
{
    public float maxCount = 50.0f; //초기 빈도값
    int count = 0; //카운트용
    bool flipFlag = false; //참, 거짓 판단을 위해 부울 데이터형 사용

    // Start is called before the first frame update
    void Start()
    {
        count = 0; //카운터를 리셋
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, 180); //rotate(x,y,z)
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag; //스프라이트 렌더 라는 컴포넌트에 있는 플립Y라는 속성에 flipFlag값을 대입한다.
        }
    }
}
