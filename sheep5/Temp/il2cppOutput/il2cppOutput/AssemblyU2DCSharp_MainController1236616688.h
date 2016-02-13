#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// GameData
struct GameData_t_49241417_0;
// StageData
struct StageData_t_665732307_0;
// System.Int32[]
struct Int32U5BU5D_t1872284309_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;
// UnityEngine.UI.Text
struct Text_t_204341102_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"

// MainController
struct  MainController_t1236616688_0  : public MonoBehaviour_t_92453903_0
{
	// GameData MainController::_GameData
	GameData_t_49241417_0 * ____GameData_2;
	// StageData MainController::_StageData
	StageData_t_665732307_0 * ____StageData_3;
	// System.Int32 MainController::_StageNum
	int32_t ____StageNum_4;
	// System.Int32 MainController::_HighScoreStageNum
	int32_t ____HighScoreStageNum_5;
	// System.Int32 MainController::thisStageClearCount
	int32_t ___thisStageClearCount_6;
	// System.Int32 MainController::GenerateSheepCount
	int32_t ___GenerateSheepCount_7;
	// System.Int32 MainController::ResultSheepCount
	int32_t ___ResultSheepCount_8;
	// System.Int32 MainController::DestroySheepCount
	int32_t ___DestroySheepCount_9;
	// System.Int32[] MainController::SheepIndex
	Int32U5BU5D_t1872284309_0* ___SheepIndex_10;
	// UnityEngine.GameObject MainController::Board
	GameObject_t_184308134_0 * ___Board_11;
	// UnityEngine.GameObject MainController::CountBox
	GameObject_t_184308134_0 * ___CountBox_12;
	// UnityEngine.GameObject MainController::Btn_plus
	GameObject_t_184308134_0 * ___Btn_plus_13;
	// UnityEngine.GameObject MainController::Btn_minus
	GameObject_t_184308134_0 * ___Btn_minus_14;
	// UnityEngine.GameObject MainController::Btn_ok
	GameObject_t_184308134_0 * ___Btn_ok_15;
	// UnityEngine.GameObject MainController::Btn_maruEnd
	GameObject_t_184308134_0 * ___Btn_maruEnd_16;
	// UnityEngine.GameObject MainController::Btn_next
	GameObject_t_184308134_0 * ___Btn_next_17;
	// UnityEngine.GameObject MainController::Btn_cancel
	GameObject_t_184308134_0 * ___Btn_cancel_18;
	// UnityEngine.GameObject MainController::Btn_use
	GameObject_t_184308134_0 * ___Btn_use_19;
	// UnityEngine.GameObject MainController::Text_stage
	GameObject_t_184308134_0 * ___Text_stage_20;
	// UnityEngine.GameObject MainController::Text_readyGo
	GameObject_t_184308134_0 * ___Text_readyGo_21;
	// UnityEngine.GameObject MainController::Text_count
	GameObject_t_184308134_0 * ___Text_count_22;
	// UnityEngine.GameObject MainController::Text_inGame
	GameObject_t_184308134_0 * ___Text_inGame_23;
	// UnityEngine.GameObject MainController::Text_maruCount
	GameObject_t_184308134_0 * ___Text_maruCount_24;
	// UnityEngine.GameObject MainController::Text_stageClear
	GameObject_t_184308134_0 * ___Text_stageClear_25;
	// UnityEngine.GameObject MainController::Text_batsuCount
	GameObject_t_184308134_0 * ___Text_batsuCount_26;
	// UnityEngine.GameObject MainController::Text_currentRecord
	GameObject_t_184308134_0 * ___Text_currentRecord_27;
	// UnityEngine.GameObject MainController::Text_retryNum
	GameObject_t_184308134_0 * ___Text_retryNum_28;
	// UnityEngine.GameObject MainController::Pic_tutorial
	GameObject_t_184308134_0 * ___Pic_tutorial_29;
	// UnityEngine.GameObject MainController::Pic_tutorial2
	GameObject_t_184308134_0 * ___Pic_tutorial2_30;
	// UnityEngine.GameObject MainController::Pic_tutorial6
	GameObject_t_184308134_0 * ___Pic_tutorial6_31;
	// UnityEngine.GameObject MainController::Pic_maru
	GameObject_t_184308134_0 * ___Pic_maru_32;
	// UnityEngine.GameObject MainController::Pic_batsu
	GameObject_t_184308134_0 * ___Pic_batsu_33;
	// UnityEngine.UI.Text MainController::Text_readyGo_text
	Text_t_204341102_0 * ___Text_readyGo_text_34;
	// UnityEngine.UI.Text MainController::Text_count_text
	Text_t_204341102_0 * ___Text_count_text_35;
	// UnityEngine.GameObject MainController::Popup_mask
	GameObject_t_184308134_0 * ___Popup_mask_36;
	// UnityEngine.GameObject MainController::Popup
	GameObject_t_184308134_0 * ___Popup_37;
	// System.Boolean MainController::isStarted
	bool ___isStarted_38;
	// UnityEngine.GameObject MainController::SheepGenerator
	GameObject_t_184308134_0 * ___SheepGenerator_39;
	// System.Int32 MainController::retryCoinNum
	int32_t ___retryCoinNum_40;
};
