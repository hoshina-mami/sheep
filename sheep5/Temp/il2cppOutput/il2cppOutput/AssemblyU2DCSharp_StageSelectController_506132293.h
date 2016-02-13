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
// UnityEngine.UI.Text
struct Text_t_204341102_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// StageSelectController
struct  StageSelectController_t_506132293_0  : public MonoBehaviour_t_92453903_0
{
	// UnityEngine.GameObject StageSelectController::BtnBox
	GameObject_t_184308134_0 * ___BtnBox_2;
	// UnityEngine.GameObject StageSelectController::Btn_stageNum
	GameObject_t_184308134_0 * ___Btn_stageNum_3;
	// UnityEngine.GameObject StageSelectController::Pic_btnMaru
	GameObject_t_184308134_0 * ___Pic_btnMaru_4;
	// UnityEngine.GameObject StageSelectController::Content
	GameObject_t_184308134_0 * ___Content_5;
	// UnityEngine.GameObject StageSelectController::cloneBox
	GameObject_t_184308134_0 * ___cloneBox_6;
	// UnityEngine.GameObject StageSelectController::cloneBtn
	GameObject_t_184308134_0 * ___cloneBtn_7;
	// UnityEngine.GameObject StageSelectController::cloneMaru
	GameObject_t_184308134_0 * ___cloneMaru_8;
	// UnityEngine.Vector3 StageSelectController::newScale
	Vector3_t_725341337_0  ___newScale_9;
	// UnityEngine.Vector3 StageSelectController::newPosition
	Vector3_t_725341337_0  ___newPosition_10;
	// UnityEngine.UI.Text StageSelectController::cloneBtnNum
	Text_t_204341102_0 * ___cloneBtnNum_11;
	// System.Int32 StageSelectController::_HighScoreStageNum
	int32_t ____HighScoreStageNum_12;
};
