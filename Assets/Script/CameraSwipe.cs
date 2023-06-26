using UnityEngine;
using UnityEngine.EventSystems;

public class CameraSwipe: MonoBehaviour, IDragHandler
{
    public float sensitivity = 1f;  // 傾きの感度

    private Vector2 lastPointerPosition;  // 前回のポインター位置

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.position.x < Screen.width / 2)  // 画面の左半分でのみ処理を行う
        {
            if (eventData.delta != Vector2.zero)
            {
                // 上下の移動量を取得
                float deltaY = eventData.delta.y;

                // カメラの傾きを計算
                float rotationX = -deltaY * sensitivity;

                // カメラをキャラクターの子要素として取得
                Transform player = transform.parent;

                // キャラクターの傾きを更新
                player.Rotate(Vector3.right, rotationX, Space.Self);
            }
        }
    }
}



