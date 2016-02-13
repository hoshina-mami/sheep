#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// MainController
struct MainController_t1236616688_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;
// UnityEngine.Transform
struct Transform_t1584899523_0;
// uTools.uTweenPosition
struct uTweenPosition_t_1155963188_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// SheepGenerator
struct  SheepGenerator_t_1953872013_0  : public MonoBehaviour_t_92453903_0
{
	// System.Single SheepGenerator::positonTop
	float ___positonTop_2;
	// System.Single SheepGenerator::positonBottom
	float ___positonBottom_3;
	// System.Single SheepGenerator::incidence
	float ___incidence_4;
	// MainController SheepGenerator::MainController
	MainController_t1236616688_0 * ___MainController_5;
	// UnityEngine.GameObject SheepGenerator::sheep
	GameObject_t_184308134_0 * ___sheep_6;
	// UnityEngine.GameObject SheepGenerator::clone
	GameObject_t_184308134_0 * ___clone_7;
	// UnityEngine.GameObject SheepGenerator::Sheeps
	GameObject_t_184308134_0 * ___Sheeps_8;
	// UnityEngine.Transform SheepGenerator::cloneTransfrom
	Transform_t1584899523_0 * ___cloneTransfrom_9;
	// UnityEngine.Vector3 SheepGenerator::newScale
	Vector3_t_725341337_0  ___newScale_10;
	// UnityEngine.Vector3 SheepGenerator::newPosition
	Vector3_t_725341337_0  ___newPosition_11;
	// UnityEngine.Vector3 SheepGenerator::fromPosition
	Vector3_t_725341337_0  ___fromPosition_12;
	// UnityEngine.Vector3 SheepGenerator::toPosition
	Vector3_t_725341337_0  ___toPosition_13;
	// uTools.uTweenPosition SheepGenerator::tweenPos
	uTweenPosition_t_1155963188_0 * ___tweenPos_14;
	// System.Boolean SheepGenerator::isFirstSheep
	bool ___isFirstSheep_15;
	// System.Int32 SheepGenerator::currentSheepId
	int32_t ___currentSheepId_16;
};
