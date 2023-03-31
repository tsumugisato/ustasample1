using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
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
         
    }
 
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!subCamera.enabled)
        {
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
            //サブカメラをオフにして
            subCamera.enabled = false;
 
            //カメラをオンにする
            Camera.enabled = true;
 
            //キャンバスを映すカメラをカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}