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

// uTools.uTweenScale
struct uTweenScale_t_685189497_0;
// UnityEngine.RectTransform
struct RectTransform_t212748479_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Vector3_725341337.h"

// System.Void uTools.uTweenScale::.ctor()
extern "C"  void uTweenScale__ctor_m_209951313_0 (uTweenScale_t_685189497_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.RectTransform uTools.uTweenScale::get_cachedRectTransform()
extern "C"  RectTransform_t212748479_0 * uTweenScale_get_cachedRectTransform_m_1389309688_0 (uTweenScale_t_685189497_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 uTools.uTweenScale::get_value()
extern "C"  Vector3_t_725341337_0  uTweenScale_get_value_m520991099_0 (uTweenScale_t_685189497_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenScale::set_value(UnityEngine.Vector3)
extern "C"  void uTweenScale_set_value_m_139393288_0 (uTweenScale_t_685189497_0 * __this, Vector3_t_725341337_0  ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenScale::OnUpdate(System.Single,System.Boolean)
extern "C"  void uTweenScale_OnUpdate_m_166297041_0 (uTweenScale_t_685189497_0 * __this, float ___factor, bool ___isFinished, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// uTools.uTweenScale uTools.uTweenScale::Begin(UnityEngine.GameObject,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Single)
extern "C"  uTweenScale_t_685189497_0 * uTweenScale_Begin_m1727018477_0 (Object_t * __this /* static, unused */, GameObject_t_184308134_0 * ___go, Vector3_t_725341337_0  ___from, Vector3_t_725341337_0  ___to, float ___duration, float ___delay, const MethodInfo* method) IL2CPP_METHOD_ATTR;
