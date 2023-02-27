using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick_Cam : MonoBehaviour
{
    // Start is called before the first frame update
    public float aimSensitivity = 10;

    private int stickMovement = 0;

    public float positionX, positionY;

    public float viewPointValue = 45;

    private float tempPosX = 0, tempPosY = 0;

    public static float rotX = 0,rotY = 0;

    private void Start()
    {
        stickMovement = 3 * (Screen.width + Screen.height) /100;
    }

    public void Move(BaseEventData data)
    {
        PointerEventData pointer = data as PointerEventData;

        positionX = pointer.position.x /stickMovement;
        positionY = pointer.position.y /stickMovement;

        positionX *= aimSensitivity;
        positionY *= aimSensitivity;

        // Rotation();
    }


    public void Rotation()
    {
        if(positionX != tempPosX)
        {
            if(tempPosX == 0)
            {
                tempPosX = positionX;
            }
            if(positionX == 0)
            {
                tempPosX = 0;
            }
            rotX -= (tempPosX - positionX);
            if(rotX > 360)
            {
                rotX -= 360;
            }

            if (rotX < -360)
            {
                rotX += 360;
            }

            tempPosX = positionX;
        }

        //  if(positionY != tempPosY)
        // {
        //     if(tempPosY == 0)
        //     {
        //         tempPosY = positionY;
        //     }
        //     if(positionY == 0)
        //     {
        //         tempPosY = 0;
        //     }
        //     rotY += (tempPosY - positionY);
        //     if(rotY > viewPointValue)
        //     {
        //         rotY = viewPointValue;
        //     }

        //     if (rotY < -viewPointValue)
        //     {
        //         rotY = -viewPointValue;
        //     }

        //     tempPosY = positionY;
        // }
    }
    
    public void PointerUp(BaseEventData data)
    {
        PositionInitialization();

        Rotation();
    }

    public void PositionInitialization()
    {
        positionX = 0;
        positionY = 0;
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
 
// public class JoyStick_Cam : MonoBehaviour
// {
 
//     private GameObject mainCamera;              //メインカメラ格納用
//     private GameObject playerObject;            //回転の中心となるプレイヤー格納用
//     public float rotateSpeed = 2.0f;            //回転の速さ
 
//     //呼び出し時に実行される関数
//     void Start()
//     {
//         //メインカメラとユニティちゃんをそれぞれ取得
//         mainCamera = Camera.main.gameObject;
//         playerObject = GameObject.Find("Avater");
//     }
 
//     //単位時間ごとに実行される関数
//     void Update()
//     {
//         //rotateCameraの呼び出し
//         rotateCamera();
//     }
 
//     //カメラを回転させる関数
//     private void rotateCamera()
//     {
//         //Vector3でX,Y方向の回転の度合いを定義
//         Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed,Input.GetAxis("Mouse Y") * rotateSpeed, 0);
 
//         //transform.RotateAround()をしようしてメインカメラを回転させる
//         mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
//         mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
//     }
// }
