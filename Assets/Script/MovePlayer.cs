using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour
{
    private float speed = 5.0f;
    // Update is called once per frame


    Animator animator;
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    private void Update()
    {
        Vector3 moveDir = ((transform.forward * JoyStick_Move.joyStickPosY) +
         (transform.right * JoyStick_Move.joyStickPosX)).normalized;
//移動
         transform.position += moveDir * speed * Time.deltaTime;
//角度
       // transform.rotation = Quaternion.Euler(JoyStick_Cam.rotY,JoyStick_Cam.rotX,0);

         //Playerの左右移動のコードの下に追記
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("Running", true);
            
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("Running", false);
        }
        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("Running", true);
        }
        if (Input.GetKeyUp("left"))
        {   
            animator.SetBool("Running", false);
        }
    }
}