using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    // Update is called once per frame
    private void Update()
    {
        Vector3 moveDir = ((transform.forward * JoyStick_Move.joyStickPosY) +
         (transform.right * JoyStick_Move.joyStickPosX)).normalized;

         transform.position += moveDir * speed * Time.deltaTime;

         transform.rotation = Quaternion.Euler(JoyStick_Cam.rotY,JoyStick_Cam.rotX,0);
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class PlayerScript : MonoBehaviour
// {
//     public FloatingJoystick inputMove; //左画面JoyStick
//     public FloatingJoystick inputRotate; //右画面JoyStick
    
//     float moveSpeed=5.0f; //移動する速度
//     float rotateSpeed=5.0f;  //回転する速度
//     void Start()
//     {

//     }

//     void Update()
//     {
//         //左スティックでの縦移動
//         this.transform.position += this.transform.forward * inputMove.Vertical *moveSpeed* Time.deltaTime;
//         //左スティックでの横移動
//         this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed*Time.deltaTime; 
//         //右スティックでの回転
//         transform.Rotate(new Vector3(0,rotateSpeed*inputRotate.Horizontal,0));
//     }
// }
