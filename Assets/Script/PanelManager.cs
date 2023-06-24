using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject panel;
    private bool isPanelVisible = false;

    private RectTransform panelRectTransform;
    private Vector3 initialPosition;
    private Vector3 targetPosition;

    public float animationDuration = 0.5f;

    private void Start()
    {
        panelRectTransform = panel.GetComponent<RectTransform>();
        initialPosition = panelRectTransform.anchoredPosition;
        targetPosition = targetPosition = new Vector3(650, 0, 0);
;
    }


    public void TogglePanelVisibility()
{
    isPanelVisible = !isPanelVisible;

    // if (isPanelVisible)
    // {
    //     panelRectTransform.anchoredPosition = targetPosition;
    //     LeanTween.move(panelRectTransform, initialPosition, animationDuration).setEase(LeanTweenType.easeOutExpo);
    // }
    // else
    // {
    //     LeanTween.move(panelRectTransform, targetPosition, animationDuration).setEase(LeanTweenType.easeOutExpo);
    // }
    if (isPanelVisible)
{
    panelRectTransform.anchoredPosition = initialPosition;
    LeanTween.move(panelRectTransform, targetPosition, animationDuration).setEase(LeanTweenType.easeOutExpo);
}
else
{
    LeanTween.move(panelRectTransform, initialPosition, animationDuration).setEase(LeanTweenType.easeOutExpo);
}

}


    private void HidePanel()
    {
        panelRectTransform.anchoredPosition = initialPosition;
    }
}
