using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{
    public Renderer objectRenderer; // 変更するオブジェクトのRendererコンポーネント
    public Color newColor; // 変更後の色

    void Start()
    {
        // 変更するオブジェクトのRendererコンポーネントを取得
        objectRenderer = GetComponent<Renderer>();
    }

    public void OnButtonClick()
    {
        // オブジェクトの色を変更
        objectRenderer.material.color = newColor;
    }
}