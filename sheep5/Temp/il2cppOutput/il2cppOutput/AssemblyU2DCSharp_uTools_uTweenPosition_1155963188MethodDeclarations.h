#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// uTools.uTweenPosition
struct uTweenPosition_t_1155963188_0;
// UnityEngine.RectTransform
struct RectTransform_t212748479_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// System.Void uTools.uTweenPosition::.ctor()
extern "C"  void uTweenPosition__ctor_m_2093824380_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.RectTransform uTools.uTweenPosition::get_cachedRectTransform()
extern "C"  RectTransform_t212748479_0 * uTweenPosition_get_cachedRectTransform_m_813214687_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 uTools.uTweenPosition::get_value()
extern "C"  Vector3_t_725341337_0  uTweenPosition_get_value_m275241860_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::set_value(UnityEngine.Vector3)
extern "C"  void uTweenPosition_set_value_m1578796675_0 (uTweenPosition_t_1155963188_0 * __this, Vector3_t_725341337_0  ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::OnUpdate(System.Single,System.Boolean)
extern "C"  void uTweenPosition_OnUpdate_m1471760058_0 (uTweenPosition_t_1155963188_0 * __this, float ___factor, bool ___isFinished, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// uTools.uTweenPosition uTools.uTweenPosition::Begin(UnityEngine.GameObject,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Single)
extern "C"  uTweenPosition_t_1155963188_0 * uTweenPosition_Begin_m1082927455_0 (Object_t * __this /* static, unused */, GameObject_t_184308134_0 * ___go, Vector3_t_725341337_0  ___from, Vector3_t_725341337_0  ___to, float ___duration, float ___delay, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::SetStartToCurrentValue()
extern "C"  void uTweenPosition_SetStartToCurrentValue_m2032348819_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::SetEndToCurrentValue()
extern "C"  void uTweenPosition_SetEndToCurrentValue_m_2106733492_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::SetCurrentValueToStart()
extern "C"  void uTweenPosition_SetCurrentValueToStart_m1278051725_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenPosition::SetCurrentValueToEnd()
extern "C"  void uTweenPosition_SetCurrentValueToEnd_m899953222_0 (uTweenPosition_t_1155963188_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
