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

// uTools.uTweenColor
struct uTweenColor_t_699597664_0;
// UnityEngine.GameObject
struct GameObject_t_184308134_0;
// UnityEngine.Transform
struct Transform_t1584899523_0;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Color_388944582.h"

// System.Void uTools.uTweenColor::.ctor()
extern "C"  void uTweenColor__ctor_m2127498166_0 (uTweenColor_t_699597664_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Color uTools.uTweenColor::get_colorValue()
extern "C"  Color_t_388944582_0  uTweenColor_get_colorValue_m_1699235380_0 (uTweenColor_t_699597664_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenColor::set_colorValue(UnityEngine.Color)
extern "C"  void uTweenColor_set_colorValue_m_720592947_0 (uTweenColor_t_699597664_0 * __this, Color_t_388944582_0  ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenColor::OnUpdate(System.Single,System.Boolean)
extern "C"  void uTweenColor_OnUpdate_m_2092901560_0 (uTweenColor_t_699597664_0 * __this, float ___factor, bool ___isFinished, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// uTools.uTweenColor uTools.uTweenColor::Begin(UnityEngine.GameObject,System.Single,System.Single,UnityEngine.Color,UnityEngine.Color)
extern "C"  uTweenColor_t_699597664_0 * uTweenColor_Begin_m1656982055_0 (Object_t * __this /* static, unused */, GameObject_t_184308134_0 * ___go, float ___duration, float ___delay, Color_t_388944582_0  ___from, Color_t_388944582_0  ___to, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void uTools.uTweenColor::SetColor(UnityEngine.Transform,UnityEngine.Color)
extern "C"  void uTweenColor_SetColor_m_57480882_0 (uTweenColor_t_699597664_0 * __this, Transform_t1584899523_0 * ____transform, Color_t_388944582_0  ____color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
