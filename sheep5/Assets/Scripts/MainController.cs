﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MainController : MonoBehaviour {

	private int  _StageNum;
	private StageData _StageData;

	//GameObjects
	private GameObject GameData;
	private GameObject Btn_plus;
	private GameObject Btn_minus;
	private GameObject Text_stage;
	private GameObject Text_readyGo;
	private GameObject Text_count;
	private GameObject Pic_tutorial;
	private Text Text_readyGo_text;
	private Text Text_count_text;
	private MainCreateSheeps createSheeps;


	// Use this for initializationb -----------------------------------------------------
	void Start () {

		GameData          = GameObject.Find("GameData");
		Btn_plus          = GameObject.Find("Btn_plus");
		Btn_minus         = GameObject.Find("Btn_minus");
		Text_stage        = GameObject.Find("Text_stage");
		Text_readyGo      = GameObject.Find("Text_readyGo");
		Text_count        = GameObject.Find("Text_count");
		Pic_tutorial      = GameObject.Find("Pic_tutorial");
		Text_readyGo_text = Text_readyGo.GetComponent<Text> ();
		Text_count_text   = Text_count.GetComponent<Text> ();
		createSheeps      = GetComponent<MainCreateSheeps> ();

		//get stageNum
//		_StageNum = PlayerPrefs.GetInt("StageNum");
		_StageNum = 2;

		//set current stage data
		_StageData = GameData.GetComponent <GameData> ().GetStageData(_StageNum);

		//make buttons unenable
		switchButtonInteractable (Btn_plus, false);
		switchButtonInteractable (Btn_minus, false);


		//start game --------------------
		showStageInfo();
	
	}


	//function switch button's interactable
	void switchButtonInteractable  (GameObject _target, bool _isInteractable) {

		_target.GetComponent <Button> () .interactable = _isInteractable;

	}

	//function turn on GameObject's TweenAlpha for hide
	void hideObjectAnimation  (GameObject _target) {
		
		_target.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		
	}


	//show information when stage starts -----------------------------------------------------
	void showStageInfo () {

		//show text
		Text_stage.GetComponent<Text>().text = "ステージ  " + _StageNum;

		switch (_StageNum) {
			case 1:
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

	//show text "readygo"
	void showReadyGo () {

		Text_readyGo_text.text = "よーい.";

		Invoke("addDot",  0.5f);
		Invoke("addDot",  1.0f);
		Invoke("showGo",  1.5f);
		Invoke("hideReadyGo",  2.0f);

		//start sheep moving
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


	//start sheep moving ---------------------------------------------------------------------------
	void startSheep () {
		//make buttons enable
		switchButtonInteractable (Btn_plus,  true);
		switchButtonInteractable (Btn_minus, true);

		// start sheep animation
		createSheeps.StartCreateSheep ();

	}


	// control count buttons --------------------------------------------------------------------------
	void countUp () {
		int countNum = int.Parse (Text_count_text.text);
		if (countNum < 999) {
			countNum = countNum + 1;
			Text_count_text.text = countNum.ToString();
		}
	}

	void countDown () {
		int countNum = int.Parse (Text_count_text.text);
		if (countNum > 0) {
			countNum = countNum - 1;
			Text_count_text.text = countNum.ToString();
		}
	}
}

