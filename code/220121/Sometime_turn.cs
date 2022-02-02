using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_turn : MonoBehaviour
{
    public float angle = 90.0f; //초기 각도값
    public float maxCount = 50.0f; //초기 빈도값
    int count = 0; //카운트용 

    // Start is called before the first frame update
    void Start()
    {
        count = 0; //카운터를 리셋
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1;
        Debug.Log(count); // count값이 증가하는 것을 확인하기 위한 코드
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle); //rotate(x,y,z)
            count = 0;
        }
    }
}
