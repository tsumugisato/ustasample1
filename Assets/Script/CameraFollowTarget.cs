using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Player")]
    private Transform target;
    // public Camera camera;
    // public Camera subCam;
    


    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時点のカメラとターゲットの距離（オフセット）を取得
        offset = gameObject.transform.position - target.transform.position;
        
    }

    /// <summary>
    /// プレイヤーが移動した後にカメラが移動するようにするためにLateUpdateにする。
    /// </summary>
    void LateUpdate()
    {
        int CameraSavedInt = PlayerPrefs.GetInt("CameraBox");
        // // カメラの位置をターゲットの位置にオフセットを足した場所にする。
         gameObject.transform.position = target.transform.position + offset;

        // if (subCam.enabled = true){
    // カメラの位置をキャラクターの位置に設定
      // transform.position = target.position;

      if (CameraSavedInt == 2 || CameraSavedInt == 3){
          // カメラの回転をキャラクターの回転に設定
        transform.rotation = target.rotation;
      }else{
          return;
      }
    
    }
}