using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageSelectController : MonoBehaviour {

	//public
	public GameObject BtnBox;//ステージ選択ボタンを横に並べる用のプレハブ
	public GameObject Btn_stageNum;//ステージ選択ボタン用のプレハブ
	public GameObject Pic_btnMaru;//ボタンのまる用のプレハブ

	//private
	private GameObject Content;
	private GameObject cloneBox;
	private GameObject cloneBtn;
	private GameObject cloneMaru;
	private Vector3 newScale;
	private Vector3 newPosition;
	//private Vector3 maruNewScale;
	private Text cloneBtnNum;
	private int _HighScoreStageNum;


	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
		} else {
			AudioListener.volume = 0.7f;
		}

		Content = GameObject.Find("Content");

		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;

		//maruNewScale.x = 0.15f;
		//maruNewScale.y = 0.15f;

		//クリア問題数をリセット
		PlayerPrefs.SetInt("thisStageClearCount" , 0);

		//ユーザーのハイスコアを取得する
		_HighScoreStageNum = PlayerPrefs.GetInt("HighScoreStageNum");

		//ステージ選択ボタン生成
		CreateStageNumBtn();
	
	}

	void Update () {
		// プラットフォームがアンドロイドかチェック
		if (Application.platform == RuntimePlatform.Android)
		{
		    // エスケープキー取得
		    if (Input.GetKey(KeyCode.Escape))
		    {
		        Application.LoadLevel("Title");
		        return;
		    }
		}
	}


	/*
	 * ステージ選択ボタンを生成する処理
	 */
	 void CreateStageNumBtn(){

	 	for (int i = 0; i < 6; i++) {

			cloneBox = (GameObject)Instantiate(BtnBox);
			cloneBox.transform.SetParent(Content.transform, true );
			cloneBox.transform.localScale = newScale;

			for (int j = 1; j < 6; j++) {

				cloneBtn = (GameObject)Instantiate(Btn_stageNum);
				cloneBtn.transform.SetParent(cloneBox.transform, true );
				cloneBtn.transform.localScale = newScale;

				int thisStageNum = j + i * 5;
				cloneBtnNum = cloneBtn.GetComponentInChildren<Text>();
				cloneBtnNum.text = thisStageNum.ToString();

				//ボタンのアクティブ・非アクティブを設定
				if (thisStageNum == 1 || thisStageNum <= (_HighScoreStageNum + 1)) {
					cloneBtn.GetComponent<Button>().interactable = true;
				}

				//クリア済みステージボタンに丸を出す
				/*
				if (thisStageNum <= _HighScoreStageNum) {
					cloneMaru = (GameObject)Instantiate(Pic_btnMaru);
					cloneMaru.transform.SetParent(cloneBtn.transform, true );
					cloneMaru.transform.localScale = maruNewScale;
					cloneMaru.transform.SetAsFirstSibling();
				}
				*/

			}

		}

	}

	/*
     * タイトル画面へ飛ぶ
     */
    public void LoadTitleScene () {
        Application.LoadLevel("Title");
    }

}


