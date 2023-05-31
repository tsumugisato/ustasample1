// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.IO;
// using UnityEngine;

// /// <summary>
// /// 指定されたカメラの内容をキャプチャするサンプル
// /// </summary>
// public class ScreenShot : MonoBehaviour
// {
//     [SerializeField] private Camera _camera;
//     [SerializeField] private Button _button;

//      private void Start()
//     {
//         _button.onClick.AddListener(SaveScreenShot);
//     }

//     public void SaveScreenShot()
//     {
//         CaptureScreenShot("Assets/CameraScreenShot.png");
//         Debug.Log("スクリーンショットが保存されました。");
//     }

//     // カメラのスクリーンショットを保存する
//     private void CaptureScreenShot(string filePath)
//     {
//         var rt = new RenderTexture(_camera.pixelWidth, _camera.pixelHeight, 24);
//         var prev = _camera.targetTexture;
//         _camera.targetTexture = rt;
//         _camera.Render();
//         _camera.targetTexture = prev;
//         RenderTexture.active = rt;
        
//         var screenShot = new Texture2D(
//             _camera.pixelWidth,
//             _camera.pixelHeight,
//             TextureFormat.RGB24,
//             false);
//         screenShot.ReadPixels(new Rect(0, 0, screenShot.width, screenShot.height), 0, 0);
//         screenShot.Apply();
            
//         var bytes = screenShot.EncodeToPNG();
//         Destroy(screenShot);
            
//         File.WriteAllBytes(filePath, bytes);
//     }


// }