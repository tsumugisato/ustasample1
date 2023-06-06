using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
 
public class GameManager: MonoBehaviour {
 
    //カメラを格納する変数
    public Camera Camera;
    public Camera SubCamera;
    public Camera ThirdCamera;
    public Button CameraButton;
    public Button SubCameraButton;
    public Button ThirdCameraButton;
    // public Camera ThirdCamera;
 
    //キャンバスを格納
    public GameObject Canvas;
 
    // Use this for initialization
    void Start () {
 
        //初めはサブカメラをオフにしておく
        Camera.enabled = true;
        SubCamera.enabled = false;
        ThirdCamera.enabled = false;
      //  ThirdCamera.enabled = false;
    }
     
    // Update is called once per frame
    void Update () {
        
        if(EventSystem.current.IsPointerOverGameObject()){
            return;
        }

        if (Input.GetMouseButtonDown (0)){
            
        }
         
    }
 
    // //ボタンを押した時の処理
    // public void PushButton(Button anybutton)
    // {
    //     Debug.Log("ボタンを押す");
    //     //もしサブカメラがオフだったら
    //     if (!ThirdCamera.enabled)
    //     {
    //         Debug.Log("サブカメラつけろ");
    //         //サブカメラをオンにして
    //         // subCamera.enabled = true;
    //         ThirdCamera.enabled = true;
 
    //         //カメラをオフにする
    //         Camera.enabled = false;
 
    //         //キャンバスを映すカメラをサブカメラオブジェクトにする
    //         Canvas.GetComponent<Canvas>().worldCamera = ThirdCamera;
    //     }
    //     //もしサブカメラがオンだったら
    //     else
    //     {
    //         Debug.Log("サブカメラオフにしろ");
    //         //サブカメラをオフにして
    //         ThirdCamera.enabled = true;
    //        // ThirdCamera.enabled = false;
 
    //         //カメラをオンにする
    //         Camera.enabled = true;
 
    //         //キャンバスを映すカメラをカメラオブジェクトにする
    //         Canvas.GetComponent<Canvas>().worldCamera = Camera;
    //     }
    // }

     public void OnCameraButtonPress()
    {
        Debug.Log("1");
        Camera.enabled = true;
        SubCamera.enabled = false;
        ThirdCamera.enabled = false;

        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = Camera;
    }

    public void OnSubCameraButtonPress()
    {
        Debug.Log("2");
        Camera.enabled = false;
        SubCamera.enabled = true;
        ThirdCamera.enabled = false;
        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = SubCamera;
    }

    public void OnThirdCameraButtonPress()
    {
        Debug.Log("3");
        Camera.enabled = false;
        SubCamera.enabled = false;
        ThirdCamera.enabled = true;
        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = ThirdCamera;
    }
}