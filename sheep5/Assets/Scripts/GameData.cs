using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/**
 * ゲームデータを生成するクラス
 * @scene Main
 */
public class GameData {
	

	/*
	 * ステージデータを返却する関数
	 * @param {Int} stageNum ステージ番号
	 */
	public StageData GetStageData (int stageNum) {

		StageData _stage = new StageData();

		switch (stageNum) {
			case 1:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 5;
				_stage.ApperingSheepIds = new int[] { 1 };
				break;

			case 2:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 10;
				_stage.ApperingSheepIds = new int[] { 1, 2 };
				break;

			case 3:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 13;
				_stage.ApperingSheepIds = new int[] { 1 };
				break;

			default:
				break;
		}

		return _stage;

	}


	
	/*
	 * ひつじデータを返却する関数
	 * @param {Int} sheepId ひつじId
	 */
	public SheepData GetStSheepData (int sheepId) {
		
		SheepData _sheep = new SheepData();
		
		switch (sheepId) {
			case 1:
				_sheep.SheepId = 1;
				_sheep.SheepName = "ひつじ";
				_sheep.SheepDescription = "ふつうのひつじ。";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_1");
				_sheep.TweenSpeed = 4;
				break;

			case 12:
				_sheep.SheepId = 2;
				_sheep.SheepName = "しろひつじ";
				_sheep.SheepDescription = "まっしろなひつじ。";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_2");
				_sheep.TweenSpeed = 3;
				break;
				
				
			default:
				break;
		}

		return _sheep;
		
	}



}
