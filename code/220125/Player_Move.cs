using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float move_Speed = 0.1f; //�ʱ� �ӵ� ��
    float x_Speed = 0; //x�� ������ �ӵ� ����
    float y_Speed = 0; //y�� ������ �ӵ� ����
    bool leftFlag = false; //���� ��ȯ�� ���� ���� (��, ����)

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        x_Speed = 0;
        y_Speed = 0;

        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false; //�� Ȥ�� ���� ���� ����
        }

        else if (Input.GetKey("left"))
        {
            x_Speed = -move_Speed;
            leftFlag = true;
        }

        else if (Input.GetKey("up"))
        {
            y_Speed = move_Speed;
        }

        else if (Input.GetKey("down"))
        {
            y_Speed = -move_Speed;
        }
    }
    private void FixedUpdate() //�� �ʸ��� ������ �������� ���� ���
    {
        this.transform.Translate(x_Speed, y_Speed, 0); //������, ����, ��, �Ʒ� ������Ʈ �̵� ��
        this.GetComponent<SpriteRenderer>().flipX = leftFlag; //������, ���� ���� �̵� �� ��������Ʈ ���⵵ �Բ� ��ȯ��
    }
}