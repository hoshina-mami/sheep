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
// UnityEngine.Transform
struct Transform_t1584899523_0;
// uTools.uTweenPosition
struct uTweenPosition_t_1155963188_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// CreateSheeps
struct  CreateSheeps_t_786303729_0  : public MonoBehaviour_t_92453903_0
{
	// UnityEngine.GameObject CreateSheeps::sheep
	GameObject_t_184308134_0 * ___sheep_2;
	// System.Single CreateSheeps::positonTop
	float ___positonTop_3;
	// System.Single CreateSheeps::positonBottom
	float ___positonBottom_4;
	// UnityEngine.GameObject CreateSheeps::clone
	GameObject_t_184308134_0 * ___clone_5;
	// UnityEngine.GameObject CreateSheeps::Sheeps
	GameObject_t_184308134_0 * ___Sheeps_6;
	// UnityEngine.Transform CreateSheeps::cloneTransfrom
	Transform_t1584899523_0 * ___cloneTransfrom_7;
	// UnityEngine.Vector3 CreateSheeps::newScale
	Vector3_t_725341337_0  ___newScale_8;
	// UnityEngine.Vector3 CreateSheeps::newPosition
	Vector3_t_725341337_0  ___newPosition_9;
	// UnityEngine.Vector3 CreateSheeps::fromPosition
	Vector3_t_725341337_0  ___fromPosition_10;
	// UnityEngine.Vector3 CreateSheeps::toPosition
	Vector3_t_725341337_0  ___toPosition_11;
	// uTools.uTweenPosition CreateSheeps::tweenPos
	uTweenPosition_t_1155963188_0 * ___tweenPos_12;
	// System.Int32 CreateSheeps::_HighScoreStageNum
	int32_t ____HighScoreStageNum_13;
};
