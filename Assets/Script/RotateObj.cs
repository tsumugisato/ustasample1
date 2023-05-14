
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateObj : MonoBehaviour
{
    public GameObject wallCube;
    public Button rightButton;
    public Button leftButton;
    public Button firstButton;
    public Button secondButton;

    private bool isRotating = false;

    private void Start()
    {
        firstButton.onClick.AddListener(() =>
        {
        // 右ボタンが押されたときに実行する処理を設定する
        rightButton.onClick.AddListener(() =>
        {
            if (!isRotating)
            {
                isRotating = true;
                StartCoroutine(RotateWallCube(wallCube, 90f));
            }
        });

        // 左ボタンが押されたときに実行する処理を設定する
        leftButton.onClick.AddListener(() =>
        {
            if (!isRotating )
            {
                isRotating = true;
                StartCoroutine(RotateWallCube(wallCube, -90f));
            }
        });
        }
        );
    }

    // 指定したWallCubeオブジェクトを指定した角度だけ回転させるコルーチン
    private IEnumerator RotateWallCube(GameObject wallCube, float angle)
    {
        Quaternion startRotation = wallCube.transform.rotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(0f, angle, 0f);
        float elapsedTime = 0f;
        float rotateTime = 0.5f;

        while (elapsedTime < rotateTime)
        {
            wallCube.transform.rotation = Quaternion.Slerp(startRotation, endRotation, (elapsedTime / rotateTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        wallCube.transform.rotation = endRotation;

        isRotating = false;
    }
}