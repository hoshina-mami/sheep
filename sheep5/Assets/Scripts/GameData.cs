using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameData : MonoBehaviour {
	

	void Start () {

		createGameData();

	}


	//create gamedata
	void createGameData () {
	
	//Stage data
		StageData Stage_1 = new StageData();
		Stage_1.BackgroundType = 1;
		Stage_1.AnswerNum = 5;
		Stage_1.ApperingSheepIds = new int[] { 1 };

		StageData Stage_2 = new StageData();
		Stage_2.BackgroundType = 1;
		Stage_2.AnswerNum = 10;
		Stage_2.ApperingSheepIds = new int[] { 1 };

		StageData Stage_3 = new StageData();
		Stage_3.BackgroundType = 1;
		Stage_3.AnswerNum = 13;
		Stage_3.ApperingSheepIds = new int[] { 1 };
	}

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



}
