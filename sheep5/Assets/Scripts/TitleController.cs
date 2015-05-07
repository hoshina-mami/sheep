using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	//private
	private GameObject TitleControllerObj;
	private GameObject Background;
	private GameObject Logo;
	private GameObject Btn_start;
	private GameObject Btn_record;
	private GameObject Btn_option;
	private GameObject Pic_noti;

	// Use this for initialization
	void Start () {

		TitleControllerObj = GameObject.Find("TitleControllerObj");
		Background         = GameObject.Find("Background");
		Logo               = GameObject.Find("Logo");
		Btn_start          = GameObject.Find("Btn_start");
		Btn_record         = GameObject.Find("Btn_record");
		Btn_option         = GameObject.Find("Btn_option");
		Pic_noti           = GameObject.Find("Pic_noti");

		//クリア問題数をリセット
		PlayerPrefs.SetInt("thisStageClearCount" , 0);

		//ひつじ帳ボタンのnoti表示
		if (PlayerPrefs.GetInt("titleNotiFlg") == 0) {
			Pic_noti.SetActive(false);
		}

		//start sheep animation
		TitleControllerObj.GetComponent<CreateSheeps>().StartCreateSheep ();
	
	}


	// called from onRelease Event of GameObject"Btn_start"
	public void ClickStartBtn () {

		hideObjects ();

		Invoke("LoadStageSelectScene",  0.9f);

	}

	// called from onRelease Event of GameObject"Btn_record"
	public void ClickRecordBtn () {

		hideObjects();

		PlayerPrefs.SetInt("titleNotiFlg", 0);

		Invoke("LoadRecordScene",  0.9f);

	}

	// called from onRelease Event of GameObject"Btn_option"
	public void ClickOptionBtn () {

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
		Background.GetComponent<uTools.uTweenPosition> ().enabled = true;
		
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

}
