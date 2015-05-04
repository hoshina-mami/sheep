using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


/**
 * メインシーンを制御するクラス
 * @scene Main
 */
public class MainController : MonoBehaviour {


	private GameData _GameData;//ゲーム全体のデータ
	private StageData _StageData;//今回のステージデータ
	private int _StageNum;//今回のステージ番号
	private int _HighScoreStageNum;//ユーザーのハイスコア

	private int thisStageClearCount;//現在のステージで何問正解したか
	private int GenerateSheepCount;//出現したひつじを数える変数
	private int ResultSheepCount;//正解数のひつじを数える変数
	private int DestroySheepCount;//通り終わったひつじを数える変数
	private int[] SheepIndex;//ひつじの表示順序を管理する配列

	//GameObjects
	private GameObject Board;
	private GameObject CountBox;
	private GameObject Btn_plus;
	private GameObject Btn_minus;
	private GameObject Btn_ok;
	private GameObject Btn_maruEnd;
	private GameObject Text_stage;
	private GameObject Text_readyGo;
	private GameObject Text_count;
	private GameObject Text_maruCount;//正解時の正解表示
	private GameObject Text_stageClear;//正解時の文言
	private GameObject Text_batsuCount;//不正解時の正解表示
	private GameObject Text_currentRecord;//不正解時の文言
	private GameObject Pic_tutorial;//チュートリアル画像
	private GameObject Pic_maru;//正解画像
	private GameObject Pic_batsu;//不正解画像
	private Text Text_readyGo_text;//「よーいどん」のテキスト
	private Text Text_count_text;//ユーザーのカウンターのテキスト

	//ひつじを生成するもの
	public GameObject SheepGenerator;


	// Use this for initializationb -----------------------------------------------------
	void Start () {

		_GameData = new GameData();

		Board              = GameObject.Find("Board");
		CountBox           = GameObject.Find("CountBox");
		Btn_plus           = GameObject.Find("Btn_plus");
		Btn_minus          = GameObject.Find("Btn_minus");
		Btn_ok             = GameObject.Find("Btn_ok");
		Btn_maruEnd        = GameObject.Find("Btn_maruEnd");
		Text_stage         = GameObject.Find("Text_stage");
		Text_readyGo       = GameObject.Find("Text_readyGo");
		Text_count         = GameObject.Find("Text_count");
		Text_maruCount     = GameObject.Find("Text_maruCount");
		Text_stageClear    = GameObject.Find("Text_stageClear");
		Text_batsuCount    = GameObject.Find("Text_batsuCount");
		Text_currentRecord = GameObject.Find("Text_currentRecord");
		Pic_tutorial       = GameObject.Find("Pic_tutorial");
		Pic_maru           = GameObject.Find("Pic_maru");
		Pic_batsu          = GameObject.Find("Pic_batsu");
		Text_readyGo_text  = Text_readyGo.GetComponent<Text> ();
		Text_count_text    = Text_count.GetComponent<Text> ();


		//初期表示で必要ないものを消す
		Btn_ok.SetActive (false);//okボタン
		Pic_maru.SetActive (false);//正解画像
		Pic_batsu.SetActive (false);//不正解画像

		//ステージ番号を取得する
		_StageNum = PlayerPrefs.GetInt("StageNum");

		//debug
		//GameObject.Find("Text_testCount").SetActive(false);

		//今回のステージデータを取得する
		_StageData = _GameData.GetStageData(_StageNum);

		//ユーザーのハイスコアを取得する
		_HighScoreStageNum = PlayerPrefs.GetInt("HighScoreStageNum");

		//今回のステージの問題数をリセットする
		thisStageClearCount = PlayerPrefs.GetInt("thisStageClearCount");
		if (thisStageClearCount == 0) {
			thisStageClearCount = 1;
		}
		

		//ボタンを非アクティブにする
		switchButtonInteractable (Btn_plus, false);
		switchButtonInteractable (Btn_minus, false);


		//ゲームスタート --------------------
		showStageInfo();
	
	}


	/*
	 * 今回のステージでのひつじの出現率を返す
	 * @return {int} ひつじの出現率(%)
	 */
	public int GetStageIncidence() {
		return _StageData.Incidence;
	}


	/*
	 * ボタンのアクティブ、非アクティブを切り替える
	 * @param {GameObject} ボタンのオブジェクト, {Bool} アクティブかどうか
	 */
	void switchButtonInteractable  (GameObject _target, bool _isInteractable) {

		_target.GetComponent <Button> () .interactable = _isInteractable;

	}

	/*
	 * ゲームオブジェクトのuTweenAlphaをアクティブにする
	 * @param {GameObject} 対象のゲームオブジェクト
	 */
	void turnOnAlphaAnimation  (GameObject _target) {
		
		_target.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		
	}


	/*
	 * ステージ開始時に情報を表示する
	 */
	void showStageInfo () {

		Debug.Log(thisStageClearCount);

		//ステージ番号を表示
		Text_stage.GetComponent<Text>().text = "ステージ  " + _StageNum.ToString() + "-" + thisStageClearCount.ToString();

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
		
		turnOnAlphaAnimation (Text_readyGo);
		
	}
	void hideStageNum () {
		
		turnOnAlphaAnimation (Text_stage);
		
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
			//ひつじidによってひつじの種類を設定
			_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(_StageData.ApperingSheepIds[i]);
		}

	}


	/*
	 * ひつじの出現数をカウントする（くろひつじ含む）
	 */
	public void CountSheepNum () {
		GenerateSheepCount++;
	}

	/*
	 * ひつじの正解出現数をカウントする（くろひつじ含まない）
	 */
	public void CountResultSheepNum () {
		ResultSheepCount++;

		//Debug
		GameObject.Find("Text_testCount").GetComponent<Text> ().text = ResultSheepCount.ToString();
	}


	/*
	 * 流れ終わったひつじを数え、
	 * 全てのひつじが流れたら確認画面へ進む
	 */
	public void CountDetroySheepNum () {
		DestroySheepCount++;

		if (DestroySheepCount == GenerateSheepCount) {
			//ひつじジェネレータを消す
			GameObject[] generators = GameObject.FindGameObjectsWithTag("generator");
			foreach(GameObject generator in generators) {
				Destroy(generator);
			}

			//確認画面へ
			Board.GetComponent<uTools.uTweenPosition> ().enabled = true;

		}
	}


	/*
	 * okボタンを表示させる
	 * BoardのTweenPositionが終わったら呼ばれる
	 */
	public void showOkBtn () {
		Btn_ok.SetActive (true);
	}


	/*
	 * 解答画面を表示する
	 * Btn_okを押すと呼ばれる
	 */
	public void showResult () {

		//Btn_okを消す
		switchButtonInteractable (Btn_ok,  false);
		turnOnAlphaAnimation (Btn_ok);

		//Boardのカウント部分以外を消す
		switchButtonInteractable (Btn_plus,  false);
		switchButtonInteractable (Btn_minus, false);
		turnOnAlphaAnimation (Board);
		turnOnAlphaAnimation (Btn_plus);
		turnOnAlphaAnimation (Btn_minus);

		//カウント部分を上にずらす
		CountBox.GetComponent<uTools.uTweenPosition> ().enabled = true;

		//正解・不正解のチェックと表示
		Invoke("checkAnswer",  1.0f);
		
	}


	/*
	 * 正解・不正解のチェックをする
	 */
	void checkAnswer () {
		int countNum = int.Parse (Text_count_text.text);

		if (countNum == ResultSheepCount) {
			//正解の場合
			Text_maruCount.GetComponent<Text> ().text = ResultSheepCount.ToString();

			//これまで数えたトータル数を更新
			updateTotalCount(countNum);

			//3回目クリアでステージクリア
			thisStageClearCount = thisStageClearCount + 1;
			if (thisStageClearCount > 3) {
				Text_stageClear.GetComponent<Text> ().text = "ステージ" + _StageNum.ToString() + "　クリア！";

				if (_StageNum > _HighScoreStageNum) {
					//新記録を出した時
					PlayerPrefs.SetInt("HighScoreStageNum" , _StageNum);
				}

				//次のステージ番号をセット＆クリア問題数をリセット
				PlayerPrefs.SetInt("StageNum" ,  _StageNum + 1);
				PlayerPrefs.SetInt("thisStageClearCount" , 0);

			} else {

				//おわるボタンを非表示
				Btn_maruEnd.SetActive(false);

				//クリア問題数を更新
				PlayerPrefs.SetInt("thisStageClearCount", thisStageClearCount);

			}

			//正解画像表示
			Pic_maru.SetActive(true);
		
		} else {

			//不正解の場合
			Text_batsuCount.GetComponent<Text> ().text = ResultSheepCount.ToString();
			Text_currentRecord.GetComponent<Text> ().text = "ざんねん...";
			//Text_currentRecord.GetComponent<Text> ().text = "きろく　ステージ" + (_StageNum - 1).ToString();

			//不正解画像表示
			Pic_batsu.SetActive(true);

			//クリア問題数をリセット
			PlayerPrefs.SetInt("thisStageClearCount" , 0);

		}
	}


	

	/*
	 * これまで数えたひつじのトータル数を加算
	 */
	void updateTotalCount (int currentCount) {
		int countNum = PlayerPrefs.GetInt("TotalCountNum");
		PlayerPrefs.SetInt("TotalCountNum" , countNum + currentCount);

		//bebug
		Debug.Log(PlayerPrefs.GetInt("TotalCountNum"));
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


	/*
	 * Mainを再度読み込む関数
	 * Btn_nextから呼ばれる
	 */
	public void LoadMainScene () {
		Application.LoadLevel("Main");
	}


	/*
	 * Titleに戻る関数
	 * Btn_endから呼ばれる
	 */
	public void LoadTitleScene () {
		Application.LoadLevel("Title");
	}
}

