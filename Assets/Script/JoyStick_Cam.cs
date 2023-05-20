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

    public Camera subCamera;
    public Camera Camera;

    private void Start()
    {
        Debug.Log("ssssss");
        stickMovement = 3 * (Screen.width + Screen.height) /100;

  
    }

    public void Move(BaseEventData data)
    {

         if (subCamera.enabled == true){

         Debug.Log("uuuuuuu");
        PointerEventData pointer = data as PointerEventData;

        positionX = pointer.position.x /stickMovement;
        positionY = pointer.position.y /stickMovement;

        positionX *= aimSensitivity;
        positionY *= aimSensitivity;

       
             Rotation();
        }
        
    }

    public void Rotation()
    {
         Debug.Log("tttttt");

        if(positionX != tempPosX  && subCamera.enabled == true)
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

         if(positionY != tempPosY && subCamera.enabled == true)
        {
              Debug.Log("ggggg");
            if(tempPosY == 0)
            {
                tempPosY = positionY;
            }
            if(positionY == 0)
            {
                tempPosY = 0;
            }
            rotY += (tempPosY - positionY);
            if(rotY > viewPointValue)
            {
                rotY = viewPointValue;
            }

            if (rotY < -viewPointValue)
            {
                rotY = -viewPointValue;
            }

            tempPosY = positionY;
        }
    }
    
    public void PointerUp(BaseEventData data)
    {
        if (subCamera.enabled == true){
Debug.Log("llllllll");
        PositionInitialization();

        Rotation();
        }
        
    }

    public void PositionInitialization()
    {
        positionX = 0;
        positionY = 0;
    }
}


// using UnityEngine;
// using UnityEngine.EventSystems;

// public class JoyStick_Cam : MonoBehaviour
// {
//     private bool isTouching = false;
//     private Vector2 touchStartPosition;

//     // 回転する速度
//     public float rotationSpeed = 10f;

//     void Update()
//     {
//         // 画面左半分をタッチしているかどうかをチェック
//         if (Input.touchCount > 0 && Input.GetTouch(0).position.x < Screen.width / 2f)
//         {
//             Touch touch = Input.GetTouch(0);

//             // タッチの開始
//             if (touch.phase == TouchPhase.Began)
//             {
//                 isTouching = true;
//                 touchStartPosition = touch.position;
//             }
//             // タッチの移動
//             else if (touch.phase == TouchPhase.Moved && isTouching)
//             {
//                 // タッチした位置と現在の位置の差分を求める
//                 Vector2 deltaPosition = touch.position - touchStartPosition;

//                 // Playerオブジェクトを回転する
//                 transform.Rotate(-deltaPosition.y * rotationSpeed * Time.deltaTime,
//                                  deltaPosition.x * rotationSpeed * Time.deltaTime,
//                                  0f);
//             }
//             // タッチの終了
//             else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
//             {
//                 isTouching = false;
//             }
//         }
//     }
// }
