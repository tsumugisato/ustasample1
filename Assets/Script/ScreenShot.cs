using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
 
public class ScreenShotScript : MonoBehaviour {
 
	//　スクリーンショットボタン
	[SerializeField]
	private GameObject screenShotButton;
	//　ログパネル
	[SerializeField]
	private GameObject logPanel;
	//　解像度パネル
	[SerializeField]
	private GameObject superSizePanel;
	//　解像度レベルスライダー
	[SerializeField]
	private Slider superSizeSlider;
	//　解像度レベルテキスト
	[SerializeField]
	private Text superSizeText;
	//　スクリーンショットを撮ってからの待ち時間
	[SerializeField]
	private float waitTime = 5f;
	//　データの保存先ファイルパス
	private string saveFilePath = "/Projects/ScreenShot";
	//　保存ファイル名
	private string saveFileName = "/screenshot.PNG";
 
	void Start() {
		//　UIの初期設定
		screenShotButton.SetActive (true);
		logPanel.SetActive (false);
		superSizePanel.SetActive (true);
 
		//　指定したフォルダがない時はAssetsフォルダに保存
		if (!Directory.Exists(Application.dataPath + saveFilePath)) {
			saveFilePath = "";
		}
	}
 
	//　スクリーンショットボタンを押す
	public void OnScreenShot() {
		StartCoroutine(OperationUI ());
	}
 
	//　スクリーンショット処理
	IEnumerator OperationUI() {
		//　スクリーンショットを撮る前にUIを全部非表示
		screenShotButton.SetActive (false);
		logPanel.SetActive (false);
		superSizePanel.SetActive (false);
		//　スクリーンショットを撮る
		ScreenCapture.CaptureScreenshot(Application.dataPath + saveFilePath + saveFileName, (int)superSizeSlider.value);
		//　待ち時間を入れないとlogPanelが表示されるので一定時間待つ
		yield return new WaitForSeconds (0.1f);
		logPanel.transform.GetChild (0).GetComponent<Text> ().text = "スクリーンショットを撮りました！\n" + Application.dataPath + saveFilePath + saveFileName + " に保存されました。";
		//　スクリーンショットを撮った旨を表示
		logPanel.SetActive (true);
		yield return new WaitForSeconds (waitTime);
		//　UIを元に戻す
		screenShotButton.SetActive (true);
		superSizePanel.SetActive (true);
		logPanel.SetActive (false);
 
	}
	//　画面サイズをテキストに表示
	public void ChangeSuperSizeText(Single value) {
		superSizeText.text = value.ToString();
	}
}