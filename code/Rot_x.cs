using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot_x : MonoBehaviour
{
    public int rot_a = 0; //초기 회전 값

    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(rot_a, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
