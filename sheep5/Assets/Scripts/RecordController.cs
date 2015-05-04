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
	//private GameObject Text_sheepName;
	//private GameObject Text_SheepDescription;
	//private Text Text_sheepName_text;//ポップアップ　ひつじの名前のテキスト
	//private Text Text_SheepDescription_text;//ポップアップ　ひつじの説明文のテキスト

	private GameObject Content;
	private GameObject cloneBox;
	private GameObject cloneSheep;
	private GameObject cloneAnimSheep;
	private Vector3 newScale;
	private Vector3 newPosition;
	private Vector3 sheepNewScale;
	private Text cloneSheepNum;
	private int _HighScoreStageNum;


	// Use this for initialization
	void Start () {

		_GameData = new GameData();

		Content               = GameObject.Find("Content");
		Popup_mask            = GameObject.Find("Popup_mask");
		Popup                 = GameObject.Find("Popup");
		//Text_sheepName        = GameObject.Find("Text_sheepName");
		//Text_SheepDescription = GameObject.Find("Text_SheepDescription");
		//Text_sheepName_text   = Text_sheepName.GetComponent<Text> ();
		//Text_SheepDescription_text = Text_SheepDescription.GetComponent<Text> ();

		Popup_mask.SetActive (false);
		Popup.SetActive (false);

		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;

		sheepNewScale.x = 0.86f;
		sheepNewScale.y = 0.86f;
		sheepNewScale.z = 1;

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

				
				} else {
					
					
				}

				cloneSheep.transform.SetParent(cloneBox.transform, true );
				cloneSheep.transform.localScale = sheepNewScale;

			

				//ボタンのアクティブ・非アクティブを設定
				//if (thisStageNum == 1 || thisStageNum <= (_HighScoreStageNum + 1)) {
				//	cloneBtn.GetComponent<Button>().interactable = true;
				//}
			}

		}

	}


	/*
     * ポップアップを開く
     */
    public void showSheepPopup () {
        
        Popup_mask.SetActive (true);
		Popup.SetActive (true);

    }


    /*
     * ポップアップを閉じる
     */
    public void closeSheepPopup () {
        
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


