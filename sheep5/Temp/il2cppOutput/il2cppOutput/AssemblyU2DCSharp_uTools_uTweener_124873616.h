#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AnimationCurve
struct AnimationCurve_t27601876_0;
struct AnimationCurve_t27601876_0_marshaled;
// UnityEngine.Events.UnityEvent
struct UnityEvent_t158998417_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"
#include "AssemblyU2DCSharp_uTools_EaseType657210037.h"
#include "AssemblyU2DCSharp_uTools_LoopStyle_1180254048.h"

// uTools.uTweener
struct  uTweener_t_124873616_0  : public MonoBehaviour_t_92453903_0
{
	// UnityEngine.AnimationCurve uTools.uTweener::animationCurve
	AnimationCurve_t27601876_0 * ___animationCurve_2;
	// uTools.EaseType uTools.uTweener::easeType
	int32_t ___easeType_3;
	// uTools.LoopStyle uTools.uTweener::loopStyle
	int32_t ___loopStyle_4;
	// System.Single uTools.uTweener::delay
	float ___delay_5;
	// System.Single uTools.uTweener::duration
	float ___duration_6;
	// System.Boolean uTools.uTweener::ignoreTimeScale
	bool ___ignoreTimeScale_7;
	// UnityEngine.Events.UnityEvent uTools.uTweener::onFinished
	UnityEvent_t158998417_0 * ___onFinished_8;
	// System.Single uTools.uTweener::mAmountPerDelta
	float ___mAmountPerDelta_9;
	// System.Single uTools.uTweener::mDuration
	float ___mDuration_10;
	// System.Single uTools.uTweener::mStartTime
	float ___mStartTime_11;
	// System.Single uTools.uTweener::mFactor
	float ___mFactor_12;
};
