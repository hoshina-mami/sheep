using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameData : MonoBehaviour {
	

	public StageData GetStageData (int stageNum) {

		StageData _stage = new StageData();

		switch (stageNum) {
			case 1:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 5;
				_stage.ApperingSheepIds = new int[] { 1 };
				return _stage;
				break;

			case 2:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 10;
				_stage.ApperingSheepIds = new int[] { 1 };
				return _stage;
				break;

			case 3:
				_stage.BackgroundType = 1;
				_stage.AnswerNum = 13;
				_stage.ApperingSheepIds = new int[] { 1 };
				return _stage;
				break;

			default:
				return _stage;
				break;
		}

	}


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
			return _sheep;
			break;

			
		default:
			return _sheep;
			break;
		}
		
	}



}
