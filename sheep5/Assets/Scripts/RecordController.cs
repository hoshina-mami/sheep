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

	//シェア用
	private int retryCoinNum;
	private string shareSheepName;


	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
		} else {
			AudioListener.volume = 0.7f;
		}

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
		popupSheepPosition.y = 140;

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
					cloneSheepNum = cloneSheep.transform.FindChild("Text_sheepId").GetComponent<Text>();
					cloneSheepNum.text = thisSheepId.ToString();

					unlockedSheepCount++;

					//notiの設定
					if (thisSheepData.IsChecked == 1) {
						cloneSheep.transform.FindChild("Pic_noti").gameObject.SetActive(false);
					}

				
				} else if (thisSheepData.UnlockStage == 0) {

					if (thisSheepId == 20 && unlockedSheepCount == 19) {

						//はかせひつじの出現
						PlayerPrefs.SetInt("SheepUnlockedFlg_20" , 1);

						//対象のひつじのスプライトに差し替える
						cloneSheep.GetComponent<Image> ().sprite = Resources.Load<Sprite>("sheepImg/pic_" + thisSheepId + "_1");
						
						//ひつじidを見えないように保存しておく
						cloneSheepNum = cloneSheep.transform.FindChild("Text_sheepId").GetComponentInChildren<Text>();
						cloneSheepNum.text = thisSheepId.ToString();

						//notiの設定
						if (thisSheepData.IsChecked == 1) {
							cloneSheep.transform.FindChild("Pic_noti").gameObject.SetActive(false);
						}

					} else if (thisSheepData.IsUnlocked == 1) {

						//対象のひつじのスプライトに差し替える
						cloneSheep.GetComponent<Image> ().sprite = Resources.Load<Sprite>("sheepImg/pic_" + thisSheepId + "_1");
						
						//ひつじidを見えないように保存しておく
						cloneSheepNum = cloneSheep.transform.FindChild("Text_sheepId").GetComponentInChildren<Text>();
						cloneSheepNum.text = thisSheepId.ToString();

						unlockedSheepCount++;

						//notiの設定
						if (thisSheepData.IsChecked == 1) {
							cloneSheep.transform.FindChild("Pic_noti").gameObject.SetActive(false);
						}

					} else {

						//未開放のひつじはボタンを非アクティブにする
						cloneSheep.GetComponent<Button>().interactable = false;
						cloneSheep.transform.FindChild("Pic_noti").gameObject.SetActive(false);

					}

				} else {

					//未開放のひつじはボタンを非アクティブにする
					cloneSheep.GetComponent<Button>().interactable = false;
					cloneSheep.transform.FindChild("Pic_noti").gameObject.SetActive(false);
					
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

    	GetComponent<AudioSource>().Play();

    	//ポップアップに表示するひつじデータを取得
    	SheepData popupSheepData = _GameData.GetStSheepData(_sheepId);

    	shareSheepName = popupSheepData.SheepName;

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

    	GetComponent<AudioSource>().Play();

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



    /*
     * シェアする
     */
    public void shareSocial () {

    	retryCoinNum = PlayerPrefs.GetInt("RetryCoinNum");
    	PlayerPrefs.SetInt("RetryCoinNum", retryCoinNum + 1);

    	string tweet = "" + shareSheepName + "を見つけたよ！ #ひつじだま http://hitsuji-dama.com/";
    	//string tweet = "" + shareSheepName + "を見つけたよ！ http://hitsuji-dama.com/";

		Application.OpenURL("https://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweet));

    }

}


