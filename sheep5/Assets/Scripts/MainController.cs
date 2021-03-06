﻿using UnityEngine;
using UnityEngine.UI;
using System;
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
	private GameObject Btn_next;
	private GameObject Btn_cancel;
	private GameObject Btn_use;
	private GameObject Text_stage;
	private GameObject Text_readyGo;
	private GameObject Text_count;
	private GameObject Text_inGame;
	private GameObject Text_maruCount;//正解時の正解表示
	private GameObject Text_stageClear;//正解時の文言
	private GameObject Text_batsuCount;//不正解時の正解表示
	private GameObject Text_currentRecord;//不正解時の文言
	private GameObject Text_retryNum;//リトライコインの個数
	private GameObject Pic_tutorial;//チュートリアル画像
	private GameObject Pic_tutorial2;//チュートリアル画像
	private GameObject Pic_tutorial6;//チュートリアル画像
	private GameObject Pic_maru;//正解画像
	private GameObject Pic_batsu;//不正解画像
	private Text Text_readyGo_text;//「よーいどん」のテキスト
	private Text Text_count_text;//ユーザーのカウンターのテキスト
	private GameObject Popup_mask;
	private GameObject Popup;
	private bool isStarted;

	//ひつじを生成するもの
	public GameObject SheepGenerator;

	//シェア用
	private int retryCoinNum;


	// Use this for initializationb -----------------------------------------------------
	void Start () {
		Application.targetFrameRate = 60;

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
		} else {
			AudioListener.volume = 0.7f;
		}

		_GameData = new GameData();

		Board              = GameObject.Find("Board");
		CountBox           = GameObject.Find("CountBox");
		Btn_plus           = GameObject.Find("Btn_plus");
		Btn_minus          = GameObject.Find("Btn_minus");
		Btn_ok             = GameObject.Find("Btn_ok");
		Btn_maruEnd        = GameObject.Find("Btn_maruEnd");
		Btn_next           = GameObject.Find("Btn_next");
		Btn_cancel         = GameObject.Find("Btn_cancel");
		Btn_use            = GameObject.Find("Btn_use");
		Text_stage         = GameObject.Find("Text_stage");
		Text_readyGo       = GameObject.Find("Text_readyGo");
		Text_count         = GameObject.Find("Text_count");
		Text_inGame        = GameObject.Find("Text_inGame");
		Text_maruCount     = GameObject.Find("Text_maruCount");
		Text_stageClear    = GameObject.Find("Text_stageClear");
		Text_batsuCount    = GameObject.Find("Text_batsuCount");
		Text_currentRecord = GameObject.Find("Text_currentRecord");
		Text_retryNum      = GameObject.Find("Text_retryNum");
		Pic_tutorial       = GameObject.Find("Pic_tutorial");
		Pic_tutorial2      = GameObject.Find("Pic_tutorial2");
		Pic_tutorial6      = GameObject.Find("Pic_tutorial6");
		Pic_maru           = GameObject.Find("Pic_maru");
		Pic_batsu          = GameObject.Find("Pic_batsu");
		Popup_mask         = GameObject.Find("Popup_mask");
		Popup              = GameObject.Find("Popup");
		Text_readyGo_text  = Text_readyGo.GetComponent<Text> ();
		Text_count_text    = Text_count.GetComponent<Text> ();

		//初期表示で必要ないものを消す
		Text_inGame.SetActive (false);//「かぞえてね」
		Pic_maru.SetActive (false);//正解画像
		Pic_batsu.SetActive (false);//不正解画像
		Popup_mask.SetActive (false);//リトライポップアップマスク
		Popup.SetActive (false);//リトライポップアップ
		

		//ステージ番号を取得する
		_StageNum = PlayerPrefs.GetInt("StageNum");

		//debug
		GameObject.Find("Text_testCount").SetActive(false);

		//今回のステージデータを取得する
		_StageData = _GameData.GetStageData(_StageNum);

		//ユーザーのハイスコアを取得する
		_HighScoreStageNum = PlayerPrefs.GetInt("HighScoreStageNum");

		//今回のステージの問題数をリセットする
		thisStageClearCount = PlayerPrefs.GetInt("thisStageClearCount");
		if (thisStageClearCount == 0) {
			thisStageClearCount = 1;
		}

		//リトライコインの数を取得
		retryCoinNum = PlayerPrefs.GetInt("RetryCoinNum");

		//ゲームスタートフラグをオフ（カウントボタン制御のため）
		isStarted = false;

		//カウントボタンの見た目を非アクティブにする
		switchButtonInteractable (Btn_plus, false);
		switchButtonInteractable (Btn_minus, false);

		//チュートリアルテキスト背景設定
		if (Application.systemLanguage != SystemLanguage.Japanese) {
			Pic_tutorial.GetComponent<Image> ().enabled = false;
			Pic_tutorial2.GetComponent<Image> ().enabled = false;
		}


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

		//ステージ番号を表示
		if (Application.systemLanguage != SystemLanguage.Japanese) {
			Text_stage.GetComponent<Text>().text = "Stage  " + _StageNum.ToString() + "-" + thisStageClearCount.ToString();
		} else {
			Text_stage.GetComponent<Text>().text = "ステージ  " + _StageNum.ToString() + "-" + thisStageClearCount.ToString();
		}

		switch (_StageNum) {
			case 1:
				//チュートリアル画像を残す＆そのための間をとる
				Destroy(Pic_tutorial2);
				Destroy(Pic_tutorial6);
				Invoke("hideStageNum",  2.0f);
				Invoke("showReadyGo",  2.5f);
				break;

			case 2:
			case 3:
			case 4:
			case 5:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
				//チュートリアル画像を残す＆そのための間をとる
				Destroy(Pic_tutorial);
				Destroy(Pic_tutorial6);
				Invoke("hideStageNum",  2.0f);
				Invoke("showReadyGo",  2.5f);
				break;

			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
				//チュートリアル画像を残す＆そのための間をとる
				Destroy(Pic_tutorial);
				Destroy(Pic_tutorial2);
				Invoke("hideStageNum",  2.0f);
				Invoke("showReadyGo",  2.5f);
				break;

			default:
				Destroy(Pic_tutorial);
				Destroy(Pic_tutorial2);
				Destroy(Pic_tutorial6);
				Invoke("hideStageNum",  1.0f);
				Invoke("showReadyGo",  1.5f);
				break;
		}

	}

	//「よーいどん！」を表示
	void showReadyGo () {

		if (Application.systemLanguage != SystemLanguage.Japanese) {
			Text_readyGo_text.text = "Ready.";
		} else {
			Text_readyGo_text.text = "よーい.";
		}

		Invoke("addDot",  0.5f);
		Invoke("addDot",  1.0f);
		Invoke("showGo",  1.5f);
		Invoke("hideReadyGo",  2.0f);

		//ひつじを動かし始める
		Invoke("startSheep",  2.0f);
		Invoke("showInGameText",  2.5f);

	}
	void addDot () {

		Text_readyGo_text.text  += ".";

	}
	void showGo () {
		
		if (Application.systemLanguage != SystemLanguage.Japanese) {
			Text_readyGo_text.text = "Go!";
		} else {
			Text_readyGo_text.text  = "どん！";
		}
		
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
		isStarted = true;
		switchButtonInteractable (Btn_plus,  true);
		switchButtonInteractable (Btn_minus, true);

		// ひつじのアニメーションを開始
		for (int i = 0; i < _StageData.ApperingSheepIds.Length; i++) {
			//ひつじジェネレーターを複製
			GameObject _SheepGenerator = (GameObject)Instantiate(SheepGenerator);
			//ひつじidによってひつじの種類を設定
			_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(_StageData.ApperingSheepIds[i]);
		}

		//ステージ3~20で、曜日限定ひつじが出現
		if (_StageNum >= 3 && _StageNum <= 20) {
			float randomIncidence;
			randomIncidence = UnityEngine.Random.Range(0, 100);

			if (randomIncidence < 20) {
				DateTime thisDay = DateTime.Now;
				int today = (int)thisDay.DayOfWeek;

				GameObject _SheepGenerator = (GameObject)Instantiate(SheepGenerator);

				if (today == 0) {//日曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(3);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_3") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_3" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				} else if (today == 1) {//月曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(17);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_17") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_17" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				} else if (today == 2) {//火曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(9);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_9") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_9" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				} else if (today == 4) {//木曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(11);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_11") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_11" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				} else if (today == 5) {//金曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(18);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_18") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_18" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				} else if (today == 6) {//土曜
					_SheepGenerator.GetComponent<SheepGenerator>().InitSheep(16);
					if (PlayerPrefs.GetInt("SheepUnlockedFlg_16") != 1) {
						PlayerPrefs.SetInt("SheepUnlockedFlg_16" , 1);
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
				}
			}
			
		}
	}


	/*
	 * 「かぞえてね」を表示
	 */
	void showInGameText () {
		Text_inGame.SetActive (true);
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
		//GameObject.Find("Text_testCount").GetComponent<Text> ().text = ResultSheepCount.ToString();
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

			turnOnAlphaAnimation (Text_inGame);

			//確認画面へ
			Board.GetComponent<uTools.uTweenPosition> ().enabled = true;
			Btn_ok.GetComponent<uTools.uTweenPosition> ().enabled = true;

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

		GetComponent<AudioSource>().Play();

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

		Btn_ok.SetActive (false);
		Btn_plus.SetActive (false);
		Btn_minus.SetActive (false);
		Text_inGame.SetActive (false);

		int countNum = int.Parse (Text_count_text.text);

		if (countNum == ResultSheepCount) {
			//正解の場合
			Text_maruCount.GetComponent<Text> ().text = ResultSheepCount.ToString();

			//これまで数えたトータル数を更新
			updateTotalCount(countNum);

			//3回目クリアでステージクリア
			thisStageClearCount = thisStageClearCount + 1;
			if (thisStageClearCount > 3) {

				//ステージ30クリアの場合
				if (_StageNum == 30) {
					if (Application.systemLanguage != SystemLanguage.Japanese) {
						Text_stageClear.GetComponent<Text> ().text = "All stage complete!";
					} else {
						Text_stageClear.GetComponent<Text> ().text = "オールクリアおめでとう！";
					}
					Btn_next.SetActive(false);
				} else {
					if (Application.systemLanguage != SystemLanguage.Japanese) {
						Text_stageClear.GetComponent<Text> ().text = "Stage" + _StageNum.ToString() + "　complete！";
					} else {
						Text_stageClear.GetComponent<Text> ().text = "ステージ" + _StageNum.ToString() + "　クリア！";
					}
				}

				if (_StageNum > _HighScoreStageNum) {
					//新記録を出した時
					PlayerPrefs.SetInt("HighScoreStageNum" , _StageNum);

					//ひつじが増えた場合
					if (_StageData.newSheepFlg) {
						PlayerPrefs.SetInt("titleNotiFlg", 1);
					}
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
			Pic_maru.GetComponent<AudioSource>().Play();
		
		} else {

			//不正解の場合
			Text_batsuCount.GetComponent<Text> ().text = ResultSheepCount.ToString();
			if (Application.systemLanguage != SystemLanguage.Japanese) {
				Text_currentRecord.GetComponent<Text> ().text = "failed...";
			} else {
				Text_currentRecord.GetComponent<Text> ().text = "ざんねん...";
			}

			//不正解画像表示
			Pic_batsu.SetActive(true);
			Pic_batsu.GetComponent<AudioSource>().Play();

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
	}


	/*
	 * カウントボタン（＋）の制御
	 */
	public void countUp () {
		if (isStarted) {
			int countNum = int.Parse (Text_count_text.text);
			if (countNum < 999) {
				countNum = countNum + 1;
				Text_count_text.text = countNum.ToString();

				Btn_plus.GetComponent<AudioSource>().Play();
			}
		}
	}

	
	/*
	 * カウントボタン（ー）の制御
	 */
	public void countDown () {
		if (isStarted) {
			int countNum = int.Parse (Text_count_text.text);
			if (countNum > 0) {
				countNum = countNum - 1;
				Text_count_text.text = countNum.ToString();

				Btn_minus.GetComponent<AudioSource>().Play();
			}
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
	 * Btn_homeから呼ばれる
	 */
	public void LoadTitleScene () {		
		Application.LoadLevel("Title");
	}


	/*
	 * StageSelectに戻る関数
	 * Btn_endから呼ばれる
	 */
	public void LoadStageSelectScene () {		
		Application.LoadLevel("StageSelect");
	}


	/*
     * シェアする
     */
    public void shareSocial () {

    	string tweet;

    	PlayerPrefs.SetInt("RetryCoinNum", retryCoinNum + 1);

    	if (Application.systemLanguage != SystemLanguage.Japanese) {
			tweet = "Stage" + _StageNum + " complete！Let's count cute rolling sheeps! #HITSUJIDAMA http://hitsuji-dama.com/";
		} else {
			tweet = "ステージ" + _StageNum + " クリア！和み系ひまつぶしゲーム #ひつじだま プレイ中！ http://hitsuji-dama.com/";
		}

		Application.OpenURL("https://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweet));

    }


    /*
     * リトライポップアップを表示する
     */
    public void showRetryPopup () {

    	GetComponent<AudioSource>().Play();

    	Popup_mask.SetActive (true);
		Popup.SetActive (true);

		Text_retryNum.GetComponent<Text> ().text = "x " + retryCoinNum.ToString();

		if (retryCoinNum < 1) {
			switchButtonInteractable (Btn_use, false);
		}

    }


 	/*
     * リトライポップアップを閉じる
     */
    public void hideRetryPopup () {

    	Popup_mask.SetActive (false);
		Popup.SetActive (false);

    }


	/*
     * リトライコインを使う
     */
    public void useRetryCoin () {

    	PlayerPrefs.SetInt("RetryCoinNum", retryCoinNum - 1);

    	PlayerPrefs.SetInt("thisStageClearCount" , thisStageClearCount);

    	Application.LoadLevel("Main");

    }



   
}

