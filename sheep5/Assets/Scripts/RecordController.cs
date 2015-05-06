using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RecordController : MonoBehaviour {

	//public
	public GameObject SheepBox;//ひつじを横に並べる用のプレハブ
	public GameObject SheepImg;//ひつじ用のプレハブ

	//private
	private GameData _GameData;//ゲーム全体のデータ

	private GameObject Popup_mask;
	private GameObject Popup;
	private GameObject Text_sheepName;
	private GameObject Text_SheepDescription;
	private Text Text_sheepName_text;//ポップアップ　ひつじの名前のテキスト
	private Text Text_SheepDescription_text;//ポップアップ　ひつじの説明文のテキスト

	//ひつじリスト用
	private GameObject Content;
	private GameObject cloneBox;
	private GameObject cloneSheep;
	private GameObject cloneAnimSheep;
	private Vector3 newScale;
	private Vector3 newPosition;
	private Vector3 sheepNewScale;
	private Text cloneSheepNum;
	private int _HighScoreStageNum;

	//ポップアップ用
	private GameObject sheep;//object created
	private GameObject cloneSheepAnim;
	private Vector3 popupSheepScale;
	private Vector3 popupSheepPosition;


	// Use this for initialization
	void Start () {

		_GameData = new GameData();

		Content               = GameObject.Find("Content");
		Popup_mask            = GameObject.Find("Popup_mask");
		Popup                 = GameObject.Find("Popup");
		Text_sheepName        = GameObject.Find("Text_sheepName");
		Text_SheepDescription = GameObject.Find("Text_SheepDescription");
		Text_sheepName_text   = Text_sheepName.GetComponent<Text> ();
		Text_SheepDescription_text = Text_SheepDescription.GetComponent<Text> ();

		Popup_mask.SetActive (false);
		Popup.SetActive (false);

		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;

		sheepNewScale.x = 0.86f;
		sheepNewScale.y = 0.86f;
		sheepNewScale.z = 1;

		popupSheepScale.x = 1.4f;
		popupSheepScale.y = 1.4f;
		popupSheepScale.z = 1;

		popupSheepPosition.x = 0;
		popupSheepPosition.y = 100;

		//クリア問題数をリセット
		PlayerPrefs.SetInt("thisStageClearCount" , 0);

		//ユーザーのハイスコアを取得する
		_HighScoreStageNum = PlayerPrefs.GetInt("HighScoreStageNum");

		//ひつじ一覧生成
		CreateSheepList();
	
	}


	/*
	 * ひつじ一覧を生成する処理
	 */
	 void CreateSheepList(){

	 	int unlockedSheepCount = 0;

	 	for (int i = 0; i < 5; i++) {

			cloneBox = (GameObject)Instantiate(SheepBox);
			cloneBox.transform.SetParent(Content.transform, true );
			cloneBox.transform.localScale = newScale;

			for (int j = 1; j < 5; j++) {

				int thisSheepId = j + i * 4;

				//今回のひつじデータを取得する
				SheepData thisSheepData = _GameData.GetStSheepData(thisSheepId);

				//ひつじのクローン作成
				cloneSheep = (GameObject)Instantiate(SheepImg);

				if (thisSheepData.UnlockStage != 0 && thisSheepData.UnlockStage <= _HighScoreStageNum) {
					
					//対象のひつじのスプライトに差し替える
					cloneSheep.GetComponent<Image> ().sprite = Resources.Load<Sprite>("sheepImg/pic_" + thisSheepId + "_1");
					
					//ひつじidを見えないように保存しておく
					cloneSheepNum = cloneSheep.GetComponentInChildren<Text>();
					cloneSheepNum.text = thisSheepId.ToString();

					unlockedSheepCount++;

				
				} else if (thisSheepData.UnlockStage == 0) {

					if (thisSheepId == 20 && unlockedSheepCount == 19) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_10" , 1);

						//対象のひつじのスプライトに差し替える
						cloneSheep.GetComponent<Image> ().sprite = Resources.Load<Sprite>("sheepImg/pic_" + thisSheepId + "_1");
						
						//ひつじidを見えないように保存しておく
						cloneSheepNum = cloneSheep.GetComponentInChildren<Text>();
						cloneSheepNum.text = thisSheepId.ToString();
						
					}

					if (thisSheepData.IsUnlocked == 1) {

						//対象のひつじのスプライトに差し替える
						cloneSheep.GetComponent<Image> ().sprite = Resources.Load<Sprite>("sheepImg/pic_" + thisSheepId + "_1");
						
						//ひつじidを見えないように保存しておく
						cloneSheepNum = cloneSheep.GetComponentInChildren<Text>();
						cloneSheepNum.text = thisSheepId.ToString();

						unlockedSheepCount++;

					}

				} else {

					//未開放のひつじはボタンを非アクティブにする
					cloneSheep.GetComponent<Button>().interactable = false;
					
				}

				cloneSheep.transform.SetParent(cloneBox.transform, true );
				cloneSheep.transform.localScale = sheepNewScale;

			}

		}

	}


	/*
     * ポップアップを開く
     */
    public void showSheepPopup (int _sheepId) {

    	//ポップアップに表示するひつじデータを取得
    	SheepData popupSheepData = _GameData.GetStSheepData(_sheepId);

    	//名前・説明文を表示
    	Text_sheepName_text.text = popupSheepData.SheepName;
    	Text_SheepDescription_text.text = popupSheepData.SheepDescription;

    	//ひつじアニメを表示
		sheep = (GameObject)Resources.Load("Sheep" + _sheepId);
		cloneSheepAnim = (GameObject)Instantiate(sheep);
		cloneSheepAnim.transform.SetParent(Popup.transform, true );
		cloneSheepAnim.GetComponent<uTools.uTweenPosition> ().enabled = false;
		cloneSheepAnim.transform.FindChild("Sheep_1").GetComponent<SheepRotation> ().enabled = false;
        cloneSheepAnim.transform.localScale = popupSheepScale;
		cloneSheepAnim.transform.localPosition = popupSheepPosition;

        Popup_mask.SetActive (true);
		Popup.SetActive (true);

    }


    /*
     * ポップアップを閉じる
     */
    public void closeSheepPopup () {

		Destroy(cloneSheepAnim);

        Popup_mask.SetActive (false);
		Popup.SetActive (false);

    }


	/*
     * タイトル画面へ飛ぶ
     */
    public void LoadTitleScene () {
        Application.LoadLevel("Title");
    }

}


