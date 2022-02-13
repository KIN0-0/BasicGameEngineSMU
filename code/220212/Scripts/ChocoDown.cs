using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoDown : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("mongmong"); //이름이 mongmong인 GameObject를 변수 player에 대입

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.03f, 0);

        if (transform.position.y < -4.5f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.2f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameObject");
        }

    }
}
