using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController : MonoBehaviour
{

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;

    public float gravity;
    public float speedRun;
    public int MAXtime = 60;
    int time = 0;

    // Use this for initialization
    void Start()
    {
        // 必要なコンポーネントを自動取得
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection.z = speedRun;
        moveDirection.y -= gravity * Time.deltaTime;

        if (controller.isGrounded)
            moveDirection.y = 0;

        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
        time++;
        if(time % 300 == 0)
        {
            Destroy(this.gameObject);
        }
    }

}
