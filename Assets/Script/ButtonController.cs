using UnityEngine;
using UnityEngine.UI;

public class  ButtonController : MonoBehaviour
{
    // 変更するGameObject
    public GameObject wallChange;

    public GameObject FloorChange;
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

    private SwitchPanels switchpanels;


    // 初期化処理
    void Start()
    {

        switchpanels = GameObject.FindObjectOfType<SwitchPanels>();
        // glassButtonのOnClickイベントにOnglassButtonClick関数を追加する
        glassButton.onClick.AddListener(OnglassButtonClick);
        // RedButtonのOnClickイベントにOnRedButtonClick関数を追加する
        redButton.onClick.AddListener(OnRedButtonClick);

        tileButton.onClick.AddListener(OnTileButtonClick);
        
        woodButton.onClick.AddListener(OnWoodButtonClick);


       // Debug.Log(switchpanels.Onwall);

        

    }


    // glassButtonがクリックされたときに呼び出される関数
    public void OnglassButtonClick()
    {
        // objectToChangeがnullでないことを確認する
        if (wallChange != null)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = glassMaterial;
            }
        }
        if (FloorChange != null && switchpanels.OnWall == false)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

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
        if (wallChange != null && switchpanels.OnWall == true);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = redMaterial;
            }
        } 
        if (FloorChange != null && switchpanels.OnWall == false);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

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
        if (wallChange != null && switchpanels.OnWall == true);
        {
            Debug.Log("ああああ");
           // Debug.Log(switchpanels.Onwall);
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = tileMaterial;
            }
        }
         if (FloorChange != null && switchpanels.OnWall == false)
        {
            Debug.Log("いいいい");
            //Debug.Log(switchpanels.Onwall);
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

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
        if (wallChange != null)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = woodMaterial;
            }
        }
        if (FloorChange != null && switchpanels.OnWall == false)
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null)
            {
                // Materialを変更する
                renderer.material = woodMaterial;
            }
        }
    }

}
