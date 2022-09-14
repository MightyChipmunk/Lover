using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KANG_TurretRotate : MonoBehaviour
{
    public float rotSpeed = 30f;
    public float rotDir = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }
    bool isMove = false;
    // Update is called once per frame
    void Update()
    {

        float angle = KANG_InputRotate.instance.GetAngle(transform.parent.position, transform.GetChild(0).position);

        // 좌우
        float h = Input.GetAxisRaw("Horizontal");
        // 수직
        float v = Input.GetAxisRaw("Vertical");

        // 입력이 있을 때만 회전
        if (h != 0 || v != 0)
            isMove = true;
        else
            isMove = false;

        // 오른쪽 방향키를 눌렀을 때
        if (h > 0)
        {
            if (angle < 0.1f) isMove = false;
            rotDir = 1;
        }
        
        // 왼쪽 방향키를 눌렀을 때
        if(h < 0)
        {
            if (angle > 179.8f) isMove = false;
            rotDir = -1;
        }
        
        // 윗쪽 방향키를 눌렀을 때
        if(v > 0)
        {
            if (angle < 90) rotDir = -1;
            else rotDir = 1;

            if (Mathf.Abs(angle - 90f) < 0.1f) isMove = false;
        }

        // 아래 방향키를 눌렀을 때
        if(v < 0)
        {
            if (angle < 90) rotDir = 1;
            else rotDir = -1;

            if (angle < 0.1f || angle > 179.8f) isMove = false;
        }
        
        if (isMove)
            transform.RotateAround(transform.parent.position, -transform.forward, rotDir * rotSpeed * Time.deltaTime);
    }
}
