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
				_stage.Incidence = 10;
				_stage.ApperingSheepIds = new int[] { 1 };
				break;

			case 2:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 2 };
				break;

			case 3:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 3 };
				break;

			case 4:
				_stage.BackgroundType = 1;
				_stage.Incidence = 15;
				_stage.ApperingSheepIds = new int[] { 1, 6 };
				break;

			case 5:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 6 };
				break;

			case 6:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 6 };
				break;

			case 7:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2 };
				break;

			case 8:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2 };
				break;

			case 9:
				_stage.BackgroundType = 1;
				_stage.Incidence = 40;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2 };
				break;

			case 10:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4 };
				break;

			case 11:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4 };
				break;

			case 12:
				_stage.BackgroundType = 1;
				_stage.Incidence = 40;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4 };
				break;

			case 13:
				_stage.BackgroundType = 1;
				_stage.Incidence = 10;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4, 7 };
				break;

			case 14:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4, 7 };
				break;

			case 15:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 6, 2, 4, 7, 5 };
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
				_sheep.SheepHint = "1度あそべば出会えるかも…？";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_1");
				break;

			case 2:
				_sheep.SheepId = 2;
				_sheep.SheepName = "しろひつじ";
				_sheep.SheepDescription = "まっしろなひつじ。そのうち普通のひつじになる。";
				_sheep.SheepHint = "数ステージクリアすれば出会えるかも…？";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_2");
				_sheep.TweenDuration = 3;
				break;

			case 3:
				_sheep.SheepId = 3;
				_sheep.SheepName = "くろひつじ";
				_sheep.SheepDescription = "くろいひつじ。ちょっとこわい。";
				_sheep.SheepHint = "そのうち邪魔してくるかも…？";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_3");
				_sheep.TweenDuration = 3;
				break;

			case 4:
				_sheep.SheepId = 4;
				_sheep.SheepName = "さくらひつじ";
				_sheep.SheepDescription = "さくらもちみたいなひつじ。春がすき。";
				_sheep.SheepHint = "";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_4");
				_sheep.TweenDuration = 3;
				break;

			case 5:
				_sheep.SheepId = 5;
				_sheep.SheepName = "みかんひつじ";
				_sheep.SheepDescription = "かがみもちに憧れるひつじ。お正月がすき。";
				_sheep.SheepHint = "";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_5");
				_sheep.TweenDuration = 4;
				break;

			case 6:
				_sheep.SheepId = 6;
				_sheep.SheepName = "りぼんひつじ";
				_sheep.SheepDescription = "ちょっとオシャレをしてみたひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_6");
				_sheep.TweenDuration = 3;
				break;

			case 7:
				_sheep.SheepId = 7;
				_sheep.SheepName = "しあわせひつじ";
				_sheep.SheepDescription = "四つ葉のクローバーでしあわせになったひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockedDate = "";
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_7");
				_sheep.TweenDuration = 2.5f;
				break;
				
				
			default:
				break;
		}

		return _sheep;
		
	}



}
