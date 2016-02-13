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
// RecordController
struct RecordController_t_1382724664_0;
// UnityEngine.UI.Text
struct Text_t_204341102_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"

// RecordSheepBtn
struct  RecordSheepBtn_t_938022355_0  : public MonoBehaviour_t_92453903_0
{
	// UnityEngine.GameObject RecordSheepBtn::RecordControllerObj
	GameObject_t_184308134_0 * ___RecordControllerObj_2;
	// RecordController RecordSheepBtn::RecordController
	RecordController_t_1382724664_0 * ___RecordController_3;
	// UnityEngine.UI.Text RecordSheepBtn::sheepIdText
	Text_t_204341102_0 * ___sheepIdText_4;
	// System.Int32 RecordSheepBtn::sheepId
	int32_t ___sheepId_5;
};
