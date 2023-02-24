using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick_Move : MonoBehaviour

{
    public GameObject joyStick;

    private RectTransform joyStickRectTransform;
    public GameObject backGround;
    public int stickRange = 3;
    private int stickMovement = 0;
    // Start is called before the first frame update

    public static float joyStickPosX;
    public static float joyStickPosY;

    private void Start()
    {
        Initialization();
    }

     private void Initialization()
     {
         stickMovement = stickRange * (Screen.width + Screen.height) /100;

         joyStickRectTransform = GetComponent<RectTransform>();

         JoyStickDisplay(false);

     }

     private void JoyStickDisplay(bool x)
     {
         backGround.SetActive(x);
         joyStick.SetActive(x);
     }

     public void Move(BaseEventData data)
     {
         PointerEventData pointer = data as PointerEventData;

         float x = backGround.transform.position.x - pointer.position.x;
         float y = backGround.transform.position.y - pointer.position.y;

         float angle = Mathf.Atan2(y,x);

         if (Vector2.Distance(backGround.transform.position,pointer.position) > stickMovement)
         {
             y = stickMovement * Mathf.Sin(angle);
             x = stickMovement * Mathf.Cos(angle);
         }

         //プレイヤーを動かす値を保持
         joyStickPosX = -x /stickMovement;
         joyStickPosY = -y /stickMovement;

         joyStick.transform.position = new Vector2(backGround.transform.position.x - x,backGround.transform.position.y - y);
     }

     public void PointerDown(BaseEventData data)
     {
         PointerEventData pointer = data as PointerEventData;

         JoyStickDisplay(true);
         backGround.transform.position = pointer.position;
     }

     public void PointerUp(BaseEventData data)
     {
         PositionInitialization();

         JoyStickDisplay(false);
     }

     public void PositionInitialization()
     {
         joyStickRectTransform.anchoredPosition = Vector2.zero;

         joyStickPosX = 0;
         joyStickPosY = 0;
     }

   
}
