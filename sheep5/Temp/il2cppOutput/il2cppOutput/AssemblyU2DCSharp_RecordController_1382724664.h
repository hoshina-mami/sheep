#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t_184308134_0;
// GameData
struct GameData_t_49241417_0;
// UnityEngine.UI.Text
struct Text_t_204341102_0;
// System.String
struct String_t;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// RecordController
struct  RecordController_t_1382724664_0  : public MonoBehaviour_t_92453903_0
{
	// UnityEngine.GameObject RecordController::SheepBox
	GameObject_t_184308134_0 * ___SheepBox_2;
	// UnityEngine.GameObject RecordController::SheepImg
	GameObject_t_184308134_0 * ___SheepImg_3;
	// GameData RecordController::_GameData
	GameData_t_49241417_0 * ____GameData_4;
	// UnityEngine.GameObject RecordController::Popup_mask
	GameObject_t_184308134_0 * ___Popup_mask_5;
	// UnityEngine.GameObject RecordController::Popup
	GameObject_t_184308134_0 * ___Popup_6;
	// UnityEngine.GameObject RecordController::Text_sheepName
	GameObject_t_184308134_0 * ___Text_sheepName_7;
	// UnityEngine.GameObject RecordController::Text_SheepDescription
	GameObject_t_184308134_0 * ___Text_SheepDescription_8;
	// UnityEngine.UI.Text RecordController::Text_sheepName_text
	Text_t_204341102_0 * ___Text_sheepName_text_9;
	// UnityEngine.UI.Text RecordController::Text_SheepDescription_text
	Text_t_204341102_0 * ___Text_SheepDescription_text_10;
	// UnityEngine.GameObject RecordController::Content
	GameObject_t_184308134_0 * ___Content_11;
	// UnityEngine.GameObject RecordController::cloneBox
	GameObject_t_184308134_0 * ___cloneBox_12;
	// UnityEngine.GameObject RecordController::cloneSheep
	GameObject_t_184308134_0 * ___cloneSheep_13;
	// UnityEngine.GameObject RecordController::cloneAnimSheep
	GameObject_t_184308134_0 * ___cloneAnimSheep_14;
	// UnityEngine.Vector3 RecordController::newScale
	Vector3_t_725341337_0  ___newScale_15;
	// UnityEngine.Vector3 RecordController::newPosition
	Vector3_t_725341337_0  ___newPosition_16;
	// UnityEngine.Vector3 RecordController::sheepNewScale
	Vector3_t_725341337_0  ___sheepNewScale_17;
	// UnityEngine.UI.Text RecordController::cloneSheepNum
	Text_t_204341102_0 * ___cloneSheepNum_18;
	// System.Int32 RecordController::_HighScoreStageNum
	int32_t ____HighScoreStageNum_19;
	// UnityEngine.GameObject RecordController::sheep
	GameObject_t_184308134_0 * ___sheep_20;
	// UnityEngine.GameObject RecordController::cloneSheepAnim
	GameObject_t_184308134_0 * ___cloneSheepAnim_21;
	// UnityEngine.Vector3 RecordController::popupSheepScale
	Vector3_t_725341337_0  ___popupSheepScale_22;
	// UnityEngine.Vector3 RecordController::popupSheepPosition
	Vector3_t_725341337_0  ___popupSheepPosition_23;
	// System.Int32 RecordController::retryCoinNum
	int32_t ___retryCoinNum_24;
	// System.String RecordController::shareSheepName
	String_t* ___shareSheepName_25;
};
