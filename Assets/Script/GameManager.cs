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
    public Camera ForthCamera;
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
        ForthCamera.enabled = false;
    }
     
    // Update is called once per frame
    void Update () {
        
        if(EventSystem.current.IsPointerOverGameObject()){
            return;
        }

        if (Input.GetMouseButtonDown (0)){
            
        }
         
    }

     public void OnCameraButtonPress()
    {
        Debug.Log("1");
        int CameraSavedInt = PlayerPrefs.GetInt("CameraBox");  

        if (CameraSavedInt == 2){
            Camera.enabled = true;
        SubCamera.enabled = false;
        ThirdCamera.enabled = false;
        ForthCamera.enabled = false;
         PlayerPrefs.DeleteKey("CameraBox");
        }else if (CameraSavedInt == 3){
            Camera.enabled = false;
        SubCamera.enabled = false;
        ThirdCamera.enabled = false;
       ForthCamera.enabled = true;
         PlayerPrefs.DeleteKey("CameraBox");
        }

        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = Camera;
        PlayerPrefs.SetInt("CameraBox", 1);
        PlayerPrefs.Save();
    }

    public void OnSubCameraButtonPress()
    {
        PlayerPrefs.DeleteKey("CameraBox");
        Debug.Log("2");
        Camera.enabled = false;
        SubCamera.enabled = true;
        ThirdCamera.enabled = false;
       ForthCamera.enabled = false;
        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = SubCamera;
        PlayerPrefs.SetInt("CameraBox", 2);
        PlayerPrefs.Save();
    }

    public void OnThirdCameraButtonPress()
    {
        PlayerPrefs.DeleteKey("CameraBox");
        Debug.Log("3");
        Camera.enabled = false;
        SubCamera.enabled = false;
        ThirdCamera.enabled = true;
       ForthCamera.enabled = false;
        //キャンバスを映すカメラをサブカメラオブジェクトにする
        Canvas.GetComponent<Canvas>().worldCamera = ThirdCamera;
        PlayerPrefs.SetInt("CameraBox", 3);
        PlayerPrefs.Save();
    }
}