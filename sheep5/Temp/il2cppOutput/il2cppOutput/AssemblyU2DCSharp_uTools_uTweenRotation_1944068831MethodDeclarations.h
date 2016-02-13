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

// uTools.uTweenRotation
struct uTweenRotation_t_1944068831_0;
// UnityEngine.RectTransform
struct RectTransform_t212748479_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Quaternion1989680039.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// System.Void uTools.uTweenRotation::.ctor()
extern "C"  void uTweenRotation__ctor_m1869848527_0 (uTweenRotation_t_1944068831_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.RectTransform uTools.uTweenRotation::get_cacheRectTransfrom()
extern "C"  RectTransform_t212748479_0 * uTweenRotation_get_cacheRectTransfrom_m547109000_0 (uTweenRotation_t_1944068831_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion uTools.uTweenRotation::get_value()
extern "C"  Quaternion_t1989680039_0  uTweenRotation_get_value_m660084061_0 (uTweenRotation_t_1944068831_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenRotation::set_value(UnityEngine.Quaternion)
extern "C"  void uTweenRotation_set_value_m_1258987924_0 (uTweenRotation_t_1944068831_0 * __this, Quaternion_t1989680039_0  ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenRotation::OnUpdate(System.Single,System.Boolean)
extern "C"  void uTweenRotation_OnUpdate_m_1346370545_0 (uTweenRotation_t_1944068831_0 * __this, float ____factor, bool ____isFinished, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// uTools.uTweenRotation uTools.uTweenRotation::Begin(UnityEngine.GameObject,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Single)
extern "C"  uTweenRotation_t_1944068831_0 * uTweenRotation_Begin_m438891061_0 (Object_t * __this /* static, unused */, GameObject_t_184308134_0 * ___go, Vector3_t_725341337_0  ___from, Vector3_t_725341337_0  ___to, float ___duration, float ___delay, const MethodInfo* method) IL2CPP_METHOD_ATTR;
