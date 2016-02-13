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

// NendUnityPlugin.Platform.iOS.IOSInterstitialInterface
struct IOSInterstitialInterface_t_28288574_0;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"

// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::.ctor()
extern "C"  void IOSInterstitialInterface__ctor_m1232536142_0 (IOSInterstitialInterface_t_28288574_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::LoadInterstitialAd(System.String,System.String,System.Boolean)
extern "C"  void IOSInterstitialInterface_LoadInterstitialAd_m_402720662_0 (IOSInterstitialInterface_t_28288574_0 * __this, String_t* ___apiKey, String_t* ___spotId, bool ___isOutputLog, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::ShowInterstitialAd(System.String)
extern "C"  void IOSInterstitialInterface_ShowInterstitialAd_m922564608_0 (IOSInterstitialInterface_t_28288574_0 * __this, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::ShowFinishInterstitialAd(System.String)
extern "C"  void IOSInterstitialInterface_ShowFinishInterstitialAd_m994471341_0 (IOSInterstitialInterface_t_28288574_0 * __this, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::DismissInterstitialAd()
extern "C"  void IOSInterstitialInterface_DismissInterstitialAd_m1571211461_0 (IOSInterstitialInterface_t_28288574_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::_LoadInterstitialAd(System.String,System.String,System.Boolean)
extern "C"  void IOSInterstitialInterface__LoadInterstitialAd_m1411106047_0 (Object_t * __this /* static, unused */, String_t* ___apiKey, String_t* ___spotId, bool ___isOutputLog, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::_ShowInterstitialAd(System.String)
extern "C"  void IOSInterstitialInterface__ShowInterstitialAd_m5804875_0 (Object_t * __this /* static, unused */, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.Platform.iOS.IOSInterstitialInterface::_DismissInterstitialAd()
extern "C"  void IOSInterstitialInterface__DismissInterstitialAd_m158512592_0 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
