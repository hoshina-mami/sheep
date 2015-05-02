using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageSelectController : MonoBehaviour {

	//public
	public GameObject BtnBox;//ステージ選択ボタンを横に並べる用のプレハブ
	public GameObject Btn_stageNum;//ステージ選択ボタン用のプレハブ

	//private
	private GameObject Content;
	private GameObject cloneBox;
	private GameObject cloneBtn;
	private Vector3 newScale;
	private Vector3 newPosition;
	private Text cloneBtnNum;
	private int _HighScoreStageNum;


	// Use this for initialization
	void Start () {

		Content = GameObject.Find("Content");

		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;

		//クリア問題数をリセット
		PlayerPrefs.SetInt("thisStageClearCount" , 0);

		//ユーザーのハイスコアを取得する
		_HighScoreStageNum = PlayerPrefs.GetInt("HighScoreStageNum");

		//ステージ選択ボタン生成
		CreateStageNumBtn();
	
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


