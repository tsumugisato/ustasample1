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
