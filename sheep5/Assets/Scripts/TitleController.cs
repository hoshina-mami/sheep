﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleController : MonoBehaviour {

	//public
	public GameObject bgm;//生成したいプレハブ
	public Sprite btnSprite;

	//private
	private GameObject cloneBgm;
	private GameObject TitleControllerObj;
	private GameObject Background;
	private GameObject Logo;
	private GameObject Btn_start;
	private GameObject Btn_record;
	private GameObject Btn_option;
	private GameObject Btn_line;
	private GameObject Pic_noti;
	private GameObject Pic_noti2;
	private GameObject Text_version;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;

		TitleControllerObj = GameObject.Find("TitleControllerObj");
		Background         = GameObject.Find("Background");
		Logo               = GameObject.Find("Logo");
		Btn_start          = GameObject.Find("Btn_start");
		Btn_record         = GameObject.Find("Btn_record");
		Btn_option         = GameObject.Find("Btn_option");
		Btn_line           = GameObject.Find("Btn_line");
		Pic_noti           = GameObject.Find("Pic_noti");
		Pic_noti2          = GameObject.Find("Pic_noti2");
		Text_version       = GameObject.Find("Text_version");

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
		} else {
			AudioListener.volume = 0.7f;
		}

		//BGMを流す
		if (GameObject.Find("BGM(Clone)") == null) {
			cloneBgm = (GameObject)Instantiate(bgm);
		}

		//クリア問題数をリセット
		PlayerPrefs.SetInt("thisStageClearCount" , 0);

		//ひつじ帳ボタン背景設定
		if (Application.systemLanguage != SystemLanguage.Japanese) {
			Btn_record.GetComponent<Image> ().sprite = btnSprite;
		}

		//ひつじ帳ボタンのnoti表示
		if (PlayerPrefs.GetInt("titleNotiFlg") == 0) {
			Pic_noti.SetActive(false);
		}

		//infoボタンのnoti表示
		if (PlayerPrefs.GetInt("infoNotiFlg") == 1) {
			Pic_noti2.SetActive(false);
		}

		//start sheep animation
		TitleControllerObj.GetComponent<CreateSheeps>().StartCreateSheep ();
	
	}

	void Update () {
		// プラットフォームがアンドロイドかチェック
		if (Application.platform == RuntimePlatform.Android)
		{
		    // エスケープキー取得
		    if (Input.GetKey(KeyCode.Escape))
		    {
		        // アプリケーション終了
		        Application.Quit();
		        return;
		    }
		}
	}


	// called from onRelease Event of GameObject"Btn_start"
	public void ClickStartBtn () {

		GetComponent<AudioSource>().Play();

		hideObjects ();

		Invoke("LoadStageSelectScene",  0.9f);

	}

	// called from onRelease Event of GameObject"Btn_record"
	public void ClickRecordBtn () {

		GetComponent<AudioSource>().Play();

		hideObjects();

		PlayerPrefs.SetInt("titleNotiFlg", 0);

		Invoke("LoadRecordScene",  0.9f);

	}

	// called from onRelease Event of GameObject"Btn_option"
	public void ClickOptionBtn () {

		GetComponent<AudioSource>().Play();

		hideObjects();

		Invoke("LoadOptionScene",  0.9f);

	}

	//画面遷移のさいにオブジェクトを消す
	void hideObjects () {

		//makes object's alpha 0
		Logo.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_start.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_record.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_option.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_line.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Background.GetComponent<uTools.uTweenPosition> ().enabled = true;
		Text_version.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		
		//remove clouds
		GameObject[] clouds = GameObject.FindGameObjectsWithTag("cloud");
		foreach(GameObject cloud in clouds) {
			cloud.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		}
		
		//remove sheeps
		GameObject[] sheeps = GameObject.FindGameObjectsWithTag("sheep");
		foreach(GameObject sheep in sheeps) {
			sheep.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		}
	}
	
	// ステージ選択画面へとぶ
	public void LoadStageSelectScene () {
		Application.LoadLevel("StageSelect");
	}

	// ステージ選択画面へとぶ
	public void LoadRecordScene () {
		Application.LoadLevel("Record");
	}

	// オプション画面へとぶ
	public void LoadOptionScene () {
		Application.LoadLevel("Option");
	}

	/*
     * LINEストアへ飛ぶ
     */
    public void GoLineStore () { 
    	if (Application.systemLanguage != SystemLanguage.Japanese) {
			Application.OpenURL("http://line.me/S/sticker/1243998");
		} else {
			Application.OpenURL("http://line.me/S/shop/sticker/author/85999");
		}
    }	

}
