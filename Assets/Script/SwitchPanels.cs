using UnityEngine;
using UnityEngine.UI;

public class SwitchPanels : MonoBehaviour
{
    public GameObject wallPanel;
    public GameObject floorPanel;
    public GameObject kitchenPanel;
    public GameObject furniturePanel;
    public Button wallButton;
    public Button floorButton;
    public Button kitchenButton;
    public Button furnitureButton;
    public bool OnKitchen = false;
   

    void Start()
    {
       // wallButtonにOnClickイベントを追加する
    
       // floorButtonにOnClickイベントを追加する
       floorButton.onClick.AddListener(ShowFloorPanel);

       kitchenButton.onClick.AddListener(ShowKitchenPanel);

        //   bool exist = PlayerPrefs.HasKey("MyInt");
        //   int mySavedInt = PlayerPrefs.GetInt("MyInt");

   wallButton.onClick.AddListener(ShowWallPanel);

   furnitureButton.onClick.AddListener(ShowFurniturePanel);


//        bool exist = PlayerPrefs.HasKey("MyInt");
//        int mySavedInt = PlayerPrefs.GetInt("MyInt");

 
// if (exist) {
//     // 値が保存されているときの処理
//     Debug.Log("おおおお");
//     Debug.Log("mySavedInt=="+ mySavedInt);

// } else {
//     // 値が保存されていないときの処理
//     Debug.Log("ええええ");

// }
    }

    public void ShowWallPanel()
    {
        Debug.Log("wall");
        

        // wallPanelを表示する
        wallPanel.SetActive(true);

        // floorPanelを非表示にする
        floorPanel.SetActive(false);

        kitchenPanel.SetActive(false);

        furniturePanel.SetActive(false);

         PlayerPrefs.DeleteKey("MyInt");
   
        PlayerPrefs.SetInt("MyInt", 2);

        PlayerPrefs.Save();

       
    }

    public void ShowFloorPanel()
    {
        Debug.Log("floor");

        // wallPanelを非表示にする
        wallPanel.SetActive(false);

        // floorPanelを表示する
        floorPanel.SetActive(true);

        kitchenPanel.SetActive(false);

        furniturePanel.SetActive(false);

         PlayerPrefs.DeleteKey("MyInt");

       PlayerPrefs.SetInt("MyInt", 3);

       PlayerPrefs.Save();
     
    }

    public void ShowKitchenPanel()
    {
        Debug.Log("kitchen");

        // wallPanelを非表示にする
        wallPanel.SetActive(false);

        // floorPanelを表示する
        floorPanel.SetActive(false);

         kitchenPanel.SetActive(true);

         furniturePanel.SetActive(false);

         OnKitchen = true;

          PlayerPrefs.DeleteKey("MyInt");

        PlayerPrefs.SetInt("MyInt", 4);

        PlayerPrefs.Save();

        // Debug.Log("mySavedInt=="+ mySavedInt);
           
     
    }

      public void ShowFurniturePanel()
    {
        Debug.Log("kitchen");

        // wallPanelを非表示にする
        wallPanel.SetActive(false);

        // floorPanelを表示する
        floorPanel.SetActive(false);

         kitchenPanel.SetActive(false);

         furniturePanel.SetActive(true);

         OnKitchen = true;

        PlayerPrefs.DeleteKey("MyInt");

        PlayerPrefs.SetInt("MyInt", 5);

        PlayerPrefs.Save();

        // Debug.Log("mySavedInt=="+ mySavedInt);
    }



}