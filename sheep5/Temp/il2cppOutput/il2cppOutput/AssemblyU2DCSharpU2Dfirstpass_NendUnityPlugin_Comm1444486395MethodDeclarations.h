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

// NendUnityPlugin.Common.NendUtils
struct NendUtils_t1444486395_0;
// NendUnityPlugin.AD.NendAdBanner
struct NendAdBanner_t_2050322291_0;
// System.String
struct String_t;
// NendUnityPlugin.AD.NendAdIcon
struct NendAdIcon_t878522906_0;

#include "codegen/il2cpp-codegen.h"

// System.Void NendUnityPlugin.Common.NendUtils::.ctor()
extern "C"  void NendUtils__ctor_m_476445061_0 (NendUtils_t1444486395_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.AD.NendAdBanner NendUnityPlugin.Common.NendUtils::GetBannerComponent(System.String)
extern "C"  NendAdBanner_t_2050322291_0 * NendUtils_GetBannerComponent_m1055057407_0 (Object_t * __this /* static, unused */, String_t* ___gameObjectName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.AD.NendAdIcon NendUnityPlugin.Common.NendUtils::GetIconComponent(System.String)
extern "C"  NendAdIcon_t878522906_0 * NendUtils_GetIconComponent_m_1814104487_0 (Object_t * __this /* static, unused */, String_t* ___gameObjectName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
