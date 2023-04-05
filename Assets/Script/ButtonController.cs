using UnityEngine;
using UnityEngine.UI;

public class  ButtonController : MonoBehaviour
{
    // 変更するGameObject
    public GameObject objectToChange;
    // glassButton
    public Button glassButton;
    // RedButton
    public Button redButton;

    public Button tileButton;

    public Button woodButton;
    // BlueMaterial
    public Material glassMaterial;
    // RedMaterial
    public Material redMaterial;

    public Material tileMaterial;

    public Material woodMaterial;

    // 初期化処理
    void Start()
    {
        
           woodButton.onClick.AddListener(OnWoodButtonClick);
        // glassButtonのOnClickイベントにOnglassButtonClick関数を追加する
        glassButton.onClick.AddListener(OnglassButtonClick);
        // RedButtonのOnClickイベントにOnRedButtonClick関数を追加する
        redButton.onClick.AddListener(OnRedButtonClick);

        glassButton.onClick.AddListener(OnTileButtonClick);

    }

    // glassButtonがクリックされたときに呼び出される関数
    public void OnglassButtonClick()
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
                renderer.material = glassMaterial;
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

     // RedButtonがクリックされたときに呼び出される関数
    public void OnTileButtonClick()
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
                renderer.material = tileMaterial;
            }
        }
    }

     // RedButtonがクリックされたときに呼び出される関数
    public void OnWoodButtonClick()
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
                renderer.material = woodMaterial;
            }
        }
    }

}
