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

    public bool OnKitchen = false;

    private GameObject furniture;

    private bool selectVisible = false;

    private bool tableVisible = false;

    private SwitchPanels switchPanels; 

    private RotateObj rotateObj; 

    // private bool chareCubeVisible = false;
    // private bool deskCubeVisible = false;
    // private bool tileCubeVisible = false;


      // int mySavedInt = PlayerPrefs.GetInt("MyInt");

    // 初期化処理
    void Start()
    {
        // glassButtonのOnClickイベントにOnglassButtonClick関数を追加する
        glassButton.onClick.AddListener(OnglassButtonClick);
        // RedButtonのOnClickイベントにOnRedButtonClick関数を追加する
        redButton.onClick.AddListener(OnRedButtonClick);

        tileButton.onClick.AddListener(OnTileButtonClick);
        
        woodButton.onClick.AddListener(OnWoodButtonClick);
        //Debug.Log(switchpanels.Onwall)
       SwitchPanels switchPanels = FindObjectOfType<SwitchPanels>();
    }


    // glassButtonがクリックされたときに呼び出される関数
    void OnglassButtonClick()
    {
        int mySavedInt = PlayerPrefs.GetInt("MyInt");
  
    Debug.Log("glassmySavedInt=="+ mySavedInt);

      
        //Debug.Log("mySavedInt=="+ mySavedInt);
        // objectToChangeがnullでないことを確認する
        if (wallChange != null);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 2)
            {
                // Materialを変更する
                renderer.material = glassMaterial;
              //  PlayerPrefs.DeleteKey("MyInt");
                
            }
        }
        if (FloorChange != null);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 3)
            {
                // Materialを変更する
                renderer.material = glassMaterial;
             //   PlayerPrefs.DeleteKey("MyInt");
            }
        }

    }

    // RedButtonがクリックされたときに呼び出される関数
    void OnRedButtonClick()
    {
        int mySavedInt = PlayerPrefs.GetInt("MyInt");
  
    Debug.Log("redmySavedInt=="+ mySavedInt);

        // Debug.Log("OnKitchen = " + switchPanels.OnKitchen);
        // objectToChangeがnullでないことを確認する
        if (wallChange != null);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 2)
            {
                // Materialを変更する
                renderer.material = redMaterial;
              //  PlayerPrefs.DeleteKey("MyInt");
            }
        }
        if (FloorChange != null);
        {

            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 3)
            {
                // Materialを変更する
                renderer.material = redMaterial;
               // PlayerPrefs.DeleteKey("MyInt");
            }
        }
    }



     // RedButtonがクリックされたときに呼び出される関数
    void OnTileButtonClick()
    {
        int mySavedInt = PlayerPrefs.GetInt("MyInt");
  
    Debug.Log("tilemySavedInt=="+ mySavedInt);

      //  Debug.Log("OnKitchen = " + switchPanels.OnKitchen);
        // objectToChangeがnullでないことを確認する
        if (wallChange != null);
        {
            Debug.Log("ああああ");
           // Debug.Log(switchpanels.Onwall);
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 2)
            {
                // Materialを変更する
                renderer.material = tileMaterial;
               // PlayerPrefs.DeleteKey("MyInt");
            }
        }
         if (FloorChange != null);
        {
            Debug.Log("いいいい");
            //Debug.Log(switchpanels.Onwall);
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 3)
            {
                // Materialを変更する
                renderer.material = tileMaterial;
               // PlayerPrefs.DeleteKey("MyInt");
            }
        }
    }

     // RedButtonがクリックされたときに呼び出される関数
    void OnWoodButtonClick()
    {
    int mySavedInt = PlayerPrefs.GetInt("MyInt");
  
    Debug.Log("woodmySavedInt=="+ mySavedInt);
      

        if (wallChange != null);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = wallChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 2)
            {
                // Materialを変更する
                renderer.material = woodMaterial;
               // PlayerPrefs.DeleteKey("MyInt");
            }
        }
        if (FloorChange != null);
        {
            // Rendererコンポーネントを取得する
            Renderer renderer = FloorChange.GetComponent<Renderer>();

            // Rendererコンポーネントがnullでないことを確認する
            if (renderer != null && mySavedInt == 3)
            {
                // Materialを変更する
                renderer.material = woodMaterial;
            }
        }
        if (mySavedInt == 4){
            selectVisible = !selectVisible;
            Debug.Log(selectVisible + "選択状態");
        }
    }

    public void RotateOption(GameObject selectfurniture){

        furniture = selectfurniture;
        rotateObj = furniture.GetComponent<RotateObj>();

         Debug.Log(selectVisible + "状態");
        if (selectVisible == true){
            Debug.Log("aaa");
            rotateObj.isOption = true;
             
        }else{
            Debug.Log("bbb");
            rotateObj.isOption = false;
        }
         furniture.SetActive(selectVisible);
    }
}
