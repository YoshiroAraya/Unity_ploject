using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    Vector3 moveDirection = Vector3.zero;

    public int controllset = 1;

    public float gravity;
    public float speedRun;
    public float speedJump;

    public GameObject gameController;
    public int life = 3;
    public int hittime = 0;
    void Start()
    {
        // 必要なコンポーネントを自動取得
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (controllset == 1)
        {
            if (Input.GetAxis("Vertical") != 0.0f)
            {
                moveDirection.z = Input.GetAxis("Vertical") * speedRun;

            }
            else
            {
                moveDirection.z = 0;

            }

            transform.Rotate(0, Input.GetAxis("Horizontal") * 3, 0);

            animator.SetBool("run", moveDirection.z != 0.0f);

            if (controller.isGrounded)
            {
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = speedJump;
                    animator.SetTrigger("jump");
                }
            }

            moveDirection.y -= gravity * Time.deltaTime;

            Vector3 globalDirection = transform.TransformDirection(moveDirection);
            controller.Move(globalDirection * Time.deltaTime);

            if (controller.isGrounded)
                moveDirection.y = 0;
        }
        if (hittime > 0)
        {
            hittime++;
            if (hittime > 30)
            {
                hittime = 0;
            }
        }
        if (controllset == 2)
        {
            if (hittime == 0)
            {
                moveDirection.x = Input.GetAxis("Vertical") * speedRun;
                moveDirection.z = Input.GetAxis("Horizontal") * speedRun * -1;
            }
            else
            {
                moveDirection.x = 0;
                moveDirection.z = 0;
            }

            Vector3 targetDirection = new Vector3(moveDirection.x, 0, moveDirection.z);

            if (moveDirection.z != 0.0f || moveDirection.x != 0.0f)
            {
                transform.rotation = Quaternion.LookRotation(targetDirection);
            }
            animator.SetBool("run", targetDirection.magnitude > 0.1f);

            if (controller.isGrounded)
            {
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = speedJump;
                    animator.SetTrigger("jump");
                }
            }
            moveDirection.y -= gravity * Time.deltaTime;


            //Vector3 globalDirection = transform.TransformDirection (moveDirection);
            controller.Move(moveDirection * Time.deltaTime);

        }

       

    }

   


    public void EnemyHit()
    {  
        // ダメージトリガーを設定
        animator.SetTrigger("damage");
        hittime = 1;
    }

   
}