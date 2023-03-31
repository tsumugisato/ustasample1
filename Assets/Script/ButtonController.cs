using UnityEngine;
using UnityEngine.UI;

public class  ButtonController : MonoBehaviour
{
    // 変更するGameObject
    public GameObject objectToChange;

    // BlueButton
    public Button blueButton;

    // RedButton
    public Button redButton;

    // BlueMaterial
    public Material blueMaterial;

    // RedMaterial
    public Material redMaterial;

    // 初期化処理
    void Start()
    {
        // BlueButtonのOnClickイベントにOnBlueButtonClick関数を追加する
        blueButton.onClick.AddListener(OnBlueButtonClick);

        // RedButtonのOnClickイベントにOnRedButtonClick関数を追加する
        redButton.onClick.AddListener(OnRedButtonClick);
    }

    // BlueButtonがクリックされたときに呼び出される関数
    public void OnBlueButtonClick()
    {
        // objectToChangeがnullでないことを確認する
        if (objectToChange != null)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = objectToChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = blueMaterial;
            }
        }
    }

    // RedButtonがクリックされたときに呼び出される関数
    public void OnRedButtonClick()
    {
        // objectToChangeがnullでないことを確認する
        if (objectToChange != null)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = objectToChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = redMaterial;
            }
        }
    }
}
