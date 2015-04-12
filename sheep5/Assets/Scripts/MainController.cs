using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


/**
 * メインシーンを制御するクラス
 * @scene Main
 */
public class MainController : MonoBehaviour {

	private int _StageNum;//今回のステージ番号
	private StageData _StageData;//今回のステージデータ
	private GameData _GameData;
	private int ResultSheepCount;

	//GameObjects
	private GameObject Btn_plus;
	private GameObject Btn_minus;
	private GameObject Text_stage;
	private GameObject Text_readyGo;
	private GameObject Text_count;
	private GameObject Pic_tutorial;//チュートリアル画像
	private Text Text_readyGo_text;//「よーいどん」のテキスト
	private Text Text_count_text;//カウンターのテキスト

	//ひつじを生成するもの
	public GameObject SheepGenerator;


	// Use this for initializationb -----------------------------------------------------
	void Start () {

		_GameData = new GameData();

		Btn_plus          = GameObject.Find("Btn_plus");
		Btn_minus         = GameObject.Find("Btn_minus");
		Text_stage        = GameObject.Find("Text_stage");
		Text_readyGo      = GameObject.Find("Text_readyGo");
		Text_count        = GameObject.Find("Text_count");
		Pic_tutorial      = GameObject.Find("Pic_tutorial");
		Text_readyGo_text = Text_readyGo.GetComponent<Text> ();
		Text_count_text   = Text_count.GetComponent<Text> ();


		//ステージ番号を取得する
//		_StageNum = PlayerPrefs.GetInt("StageNum");
		_StageNum = 2;

		//今回のステージデータを取得する
		_StageData = _GameData.GetStageData(_StageNum);
		

		//ボタンを非アクティブにする
		switchButtonInteractable (Btn_plus, false);
		switchButtonInteractable (Btn_minus, false);


		//ゲームスタート --------------------
		showStageInfo();
	
	}


	/*
	 * ひつじのスプライトデータを返す
	 * @param {GameObject} ボタンのオブジェクト, {Bool} アクティブかどうか
	 */
	//public Sprite GetSheepSprite(string spriteName) {
	//	return System.Array.Find<Sprite>(sprites, (sprite) => sprite.name.Equals(spriteName));
	//}


	/*
	 * ボタンのアクティブ、非アクティブを切り替える
	 * @param {GameObject} ボタンのオブジェクト, {Bool} アクティブかどうか
	 */
	void switchButtonInteractable  (GameObject _target, bool _isInteractable) {

		_target.GetComponent <Button> () .interactable = _isInteractable;

	}

	/*
	 * ゲームオブジェクトのuTweenAlphaをアクティブにする
	 * 画面から消す際にアルファを1→0にするために使用する
	 * @param {GameObject} 対象のゲームオブジェクト
	 */
	void hideObjectAnimation  (GameObject _target) {
		
		_target.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		
	}


	/*
	 * ステージ開始時に情報を表示する
	 */
	void showStageInfo () {

		//ステージ番号を表示
		Text_stage.GetComponent<Text>().text = "ステージ  " + _StageNum;

		switch (_StageNum) {
			case 1:
				//ステージ1の場合、チュートリアル画像を残す＆そのための間をとる
				Invoke("hideStageNum",  2.0f);
				Invoke("showReadyGo",  2.5f);
				break;

			default:
				Destroy(Pic_tutorial);
				Invoke("hideStageNum",  1.0f);
				Invoke("showReadyGo",  1.5f);
				break;
		}

	}

	//「よーいどん！」を表示
	void showReadyGo () {

		Text_readyGo_text.text = "よーい.";

		Invoke("addDot",  0.5f);
		Invoke("addDot",  1.0f);
		Invoke("showGo",  1.5f);
		Invoke("hideReadyGo",  2.0f);

		//ひつじを動かし始める
		Invoke("startSheep",  2.0f);

	}
	void addDot () {

		Text_readyGo_text.text  += ".";

	}
	void showGo () {
		
		Text_readyGo_text.text  = "どん！";
		
	}
	void hideReadyGo () {
		
		hideObjectAnimation (Text_readyGo);
		
	}
	void hideStageNum () {
		
		hideObjectAnimation (Text_stage);
		
	}


	/*
	 * ひつじの動きを開始する
	 */
	void startSheep () {
		// カウントボタンをアクティブにする
		switchButtonInteractable (Btn_plus,  true);
		switchButtonInteractable (Btn_minus, true);

		// ひつじのアニメーションを開始
		for (int i = 0; i < _StageData.ApperingSheepIds.Length; i++) {
			//ひつじジェネレーターを複製
			GameObject _SheepGenerator = (GameObject)Instantiate(SheepGenerator);
			//ひつじidによってスプライトを設定
			_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(_StageData.ApperingSheepIds[i]);
		}

	}


	/*
	 * ひつじの出現数をカウントする
	 */
	public void CountSheepNum () {
		ResultSheepCount++;

		GameObject.Find("Text_testCount").GetComponent<Text> ().text = ResultSheepCount.ToString();
	}


	/*
	 * カウントボタン（＋）の制御
	 */
	void countUp () {
		int countNum = int.Parse (Text_count_text.text);
		if (countNum < 999) {
			countNum = countNum + 1;
			Text_count_text.text = countNum.ToString();
		}
	}

	
	/*
	 * カウントボタン（ー）の制御
	 */
	void countDown () {
		int countNum = int.Parse (Text_count_text.text);
		if (countNum > 0) {
			countNum = countNum - 1;
			Text_count_text.text = countNum.ToString();
		}
	}
}

