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
    public bool OnWall = true;

    void Start()
    {
        // wallButtonにOnClickイベントを追加する
       // wallButton.onClick.AddListener(ShowWallPanel);

        // floorButtonにOnClickイベントを追加する
       // floorButton.onClick.AddListener(ShowFloorPanel);
        // kitchenButton.onClick.AddListener(ShowFloorPanel);
        // furnitureButton.onClick.AddListener(ShowFloorPanel);
        OnWall = true;

    }

    public void ShowWallPanel()
    {
        Debug.Log("wall");

        // wallPanelを表示する
        wallPanel.SetActive(true);

        // floorPanelを非表示にする
        floorPanel.SetActive(false);
        OnWall = true;
    }

    public void ShowFloorPanel()
    {
        Debug.Log("floor");
        // wallPanelを非表示にする
        wallPanel.SetActive(false);

        // floorPanelを表示する
        floorPanel.SetActive(true);
        OnWall = false;
    }
}
