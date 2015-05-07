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
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1 };
				_stage.newSheepFlg = true;
				break;

			case 2:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 2 };
				_stage.newSheepFlg = true;
				break;

			case 3:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 2 };
				_stage.newSheepFlg = false;
				break;

			case 4:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4 };
				_stage.newSheepFlg = true;
				break;

			case 5:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4 };
				_stage.newSheepFlg = false;
				break;

			case 6:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4, 6 };
				_stage.newSheepFlg = true;
				break;

			case 7:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4, 6 };
				_stage.newSheepFlg = false;
				break;

			case 8:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4, 6, 5};
				_stage.newSheepFlg = true;
				break;

			case 9:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4, 6, 5 };
				_stage.newSheepFlg = false;
				break;

			case 10:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 2, 4, 6, 5 };
				_stage.newSheepFlg = false;
				break;

			case 11:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12 };
				_stage.newSheepFlg = true;
				break;

			case 12:
				_stage.BackgroundType = 1;
				_stage.Incidence = 40;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12 };
				_stage.newSheepFlg = false;
				break;

			case 13:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12, 8 };
				_stage.newSheepFlg = true;
				break;

			case 14:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12, 8 };
				_stage.newSheepFlg = false;
				break;

			case 15:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12, 8 };
				_stage.newSheepFlg = false;
				break;

			case 16:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 4, 7, 12, 8, 6 };
				_stage.newSheepFlg = false;
				break;

			case 17:
				_stage.BackgroundType = 1;
				_stage.Incidence = 20;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 8, 6 };
				_stage.newSheepFlg = true;
				break;

			case 18:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 8, 6 };
				_stage.newSheepFlg = false;
				break;

			case 19:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 8, 6 };
				_stage.newSheepFlg = false;
				break;

			case 20:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 8, 6 };
				_stage.newSheepFlg = false;
				break;

			case 21:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10 };
				_stage.newSheepFlg = true;
				break;

			case 22:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10 };
				_stage.newSheepFlg = false;
				break;

			case 23:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14 };
				_stage.newSheepFlg = true;
				break;

			case 24:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14 };
				_stage.newSheepFlg = false;
				break;

			case 25:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14 };
				_stage.newSheepFlg = false;
				break;

			case 26:
				_stage.BackgroundType = 1;
				_stage.Incidence = 25;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14, 6 };
				_stage.newSheepFlg = false;
				break;

			case 27:
				_stage.BackgroundType = 1;
				_stage.Incidence = 30;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14, 6, 15 };
				_stage.newSheepFlg = true;
				break;

			case 28:
				_stage.BackgroundType = 1;
				_stage.Incidence = 35;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14, 6, 15 };
				_stage.newSheepFlg = false;
				break;

			case 29:
				_stage.BackgroundType = 1;
				_stage.Incidence = 40;
				_stage.ApperingSheepIds = new int[] {  1, 13, 7, 12, 10, 14, 6, 15 };
				_stage.newSheepFlg = false;
				break;

			case 30:
				_stage.BackgroundType = 1;
				_stage.Incidence = 40;
				_stage.ApperingSheepIds = new int[] { 1, 13, 7, 12, 10, 14, 6, 15, 19 };
				_stage.newSheepFlg = true;
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
				_sheep.SheepDescription = "普通のひつじ。";
				_sheep.SheepHint = "1度あそべば出会えるかも…？";
				_sheep.UnlockStage = 1;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_1");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_1");
				break;

			case 2:
				_sheep.SheepId = 2;
				_sheep.SheepName = "りぼんひつじ";
				_sheep.SheepDescription = "ちょっとオシャレをしてみたひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 2;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_2");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_2");
				break;

			case 3:
				_sheep.SheepId = 3;
				_sheep.SheepName = "みかんひつじ";
				_sheep.SheepDescription = "かがみもちに憧れるひつじ。お正月がすき。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_3");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_3");
				break;

			case 4:
				_sheep.SheepId = 4;
				_sheep.SheepName = "さくらひつじ";
				_sheep.SheepDescription = "さくらもちみたいなひつじ。双子の弟がいる。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 4;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_4");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_4");
				break;

			case 5:
				_sheep.SheepId = 5;
				_sheep.SheepName = "しろひつじ";
				_sheep.SheepDescription = "まっしろなひつじ。そのうち普通のひつじになる。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 8;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_5");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_5");
				break;

			case 6:
				_sheep.SheepId = 6;
				_sheep.SheepName = "くろひつじ";
				_sheep.SheepDescription = "くろいひつじ。顔がちょっとこわい。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 6;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_6");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_6");
				break;

			case 7:
				_sheep.SheepId = 7;
				_sheep.SheepName = "しあわせひつじ";
				_sheep.SheepDescription = "四つ葉のクローバーを見つけてしあわせになったひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 11;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_7");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_7");
				break;

			case 8:
				_sheep.SheepId = 8;
				_sheep.SheepName = "あずきひつじ";
				_sheep.SheepDescription = "あずき色のひつじ。和菓子がすき。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 13;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_8");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_8");
				break;

			case 9:
				_sheep.SheepId = 9;
				_sheep.SheepName = "かしわひつじ";
				_sheep.SheepDescription = "かしわもちみたいなひつじ。双子のお姉ちゃんがいる。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_9");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_9");
				break;

			case 10:
				_sheep.SheepId = 10;
				_sheep.SheepName = "ぶるーはわいひつじ";
				_sheep.SheepDescription = "かき氷にありそうなひつじ。夏は元気。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 21;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_10");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_10");
				break;

			case 11:
				_sheep.SheepId = 11;
				_sheep.SheepName = "さんたひつじ";
				_sheep.SheepDescription = "年中クリスマスを楽しみにしているひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_11");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_11");
				break;

			case 12:
				_sheep.SheepId = 12;
				_sheep.SheepName = "よもぎひつじ";
				_sheep.SheepDescription = "ちょっと渋いひつじ。あずきひつじと仲良し。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 11;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_12");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_12");
				break;

			case 13:
				_sheep.SheepId = 13;
				_sheep.SheepName = "ふぉんでゅひつじ";
				_sheep.SheepDescription = "チョコレートフォンデュをしてみたひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 17;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_13");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_13");
				break;

			case 14:
				_sheep.SheepId = 14;
				_sheep.SheepName = "あじさいひつじ";
				_sheep.SheepDescription = "梅雨ごろに元気になるひつじ。カラフル。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 24;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_14");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_14");
				break;

			case 15:
				_sheep.SheepId = 15;
				_sheep.SheepName = "とまとひつじ";
				_sheep.SheepDescription = "トマトみたいなひつじ。よく熟している。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 27;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_15");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_15");
				break;

			case 16:
				_sheep.SheepId = 16;
				_sheep.SheepName = "ほしぞらひつじ";
				_sheep.SheepDescription = "ロマンティックなひつじ。流れ星に憧れている。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_16");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_16");
				break;

			case 17:
				_sheep.SheepId = 17;
				_sheep.SheepName = "あさがおひつじ";
				_sheep.SheepDescription = "朝顔をつけてオシャレをしてみたひつじ。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_17");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_17");
				break;
				
			case 18:
				_sheep.SheepId = 18;
				_sheep.SheepName = "れもんきゃんでぃーひつじ";
				_sheep.SheepDescription = "レモン色のひつじ。初恋の味かもしれない。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_18");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_18");
				break;

			case 19:
				_sheep.SheepId = 19;
				_sheep.SheepName = "きんぐひつじ";
				_sheep.SheepDescription = "ひつじの王様。全ステージクリアおめでとう！";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 30;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_19");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_19");
				break;

			case 20:
				_sheep.SheepId = 20;
				_sheep.SheepName = "はかせひつじ";
				_sheep.SheepDescription = "ひつじの博士。博士号を取得している。";
				_sheep.SheepHint = "";
				_sheep.UnlockStage = 0;
				_sheep.IsUnlocked = PlayerPrefs.GetInt("SheepUnlockedFlg_20");
				_sheep.IsChecked = PlayerPrefs.GetInt("SheepCheckedFlg_20");
				break;

			default:
				break;
		}

		return _sheep;
		
	}



}
