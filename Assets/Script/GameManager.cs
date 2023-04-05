using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 
public class GameManager: MonoBehaviour {
 
    //カメラを格納する変数
    public Camera Camera;
    public Camera subCamera;
 
    //キャンバスを格納
    public GameObject Canvas;
 
    // Use this for initialization
    void Start () {
 
        //初めはサブカメラをオフにしておく
        subCamera.enabled = false;
    }
     
    // Update is called once per frame
    void Update () {
        
        if(EventSystem.current.IsPointerOverGameObject()){
            return;
        }

        if (Input.GetMouseButtonDown (0)){
            
        }
         
    }
 
    //ボタンを押した時の処理
    public void PushButton()
    {
        Debug.Log("ボタンを押す");
        //もしサブカメラがオフだったら
        if (!subCamera.enabled)
        {
            Debug.Log("サブカメラつけろ");
            //サブカメラをオンにして
            subCamera.enabled = true;
 
            //カメラをオフにする
            Camera.enabled = false;
 
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;
        }
        //もしサブカメラがオンだったら
        else
        {
            Debug.Log("サブカメラオフにしろ");
            //サブカメラをオフにして
            subCamera.enabled = false;
 
            //カメラをオンにする
            Camera.enabled = true;
 
            //キャンバスを映すカメラをカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}