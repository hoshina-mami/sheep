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

// NendUnityPlugin.AD.NendAdInterstitial
struct NendAdInterstitial_t_1166267443_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialLoadEventArgs>
struct EventHandler_1_t786484606_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialClickEventArgs>
struct EventHandler_1_t_339205410_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialShowEventArgs>
struct EventHandler_1_t1326215893_0;
// NendUnityPlugin.Callback.NendAdInterstitialCallback
struct NendAdInterstitialCallback_t1952375088_0;
// NendUnityPlugin.Platform.NendAdInterstitialInterface
struct NendAdInterstitialInterface_t_1228201764_0;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"

// System.Void NendUnityPlugin.AD.NendAdInterstitial::.ctor()
extern "C"  void NendAdInterstitial__ctor_m_1353873757_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::.cctor()
extern "C"  void NendAdInterstitial__cctor_m497490282_0 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::add_AdLoaded(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialLoadEventArgs>)
extern "C"  void NendAdInterstitial_add_AdLoaded_m_653345594_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t786484606_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::remove_AdLoaded(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialLoadEventArgs>)
extern "C"  void NendAdInterstitial_remove_AdLoaded_m1372834665_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t786484606_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::add_AdClicked(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialClickEventArgs>)
extern "C"  void NendAdInterstitial_add_AdClicked_m_1668576240_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t_339205410_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::remove_AdClicked(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialClickEventArgs>)
extern "C"  void NendAdInterstitial_remove_AdClicked_m_129532429_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t_339205410_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::add_AdShown(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialShowEventArgs>)
extern "C"  void NendAdInterstitial_add_AdShown_m296950117_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t1326215893_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::remove_AdShown(System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialShowEventArgs>)
extern "C"  void NendAdInterstitial_remove_AdShown_m_191878558_0 (NendAdInterstitial_t_1166267443_0 * __this, EventHandler_1_t1326215893_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.AD.NendAdInterstitial NendUnityPlugin.AD.NendAdInterstitial::get_Instance()
extern "C"  NendAdInterstitial_t_1166267443_0 * NendAdInterstitial_get_Instance_m47298368_0 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::set_Callback(NendUnityPlugin.Callback.NendAdInterstitialCallback)
extern "C"  void NendAdInterstitial_set_Callback_m753015672_0 (NendAdInterstitial_t_1166267443_0 * __this, Object_t * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Platform.NendAdInterstitialInterface NendUnityPlugin.AD.NendAdInterstitial::get_Interface()
extern "C"  Object_t * NendAdInterstitial_get_Interface_m510606433_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Awake()
extern "C"  void NendAdInterstitial_Awake_m_1116268538_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Load(System.String,System.String)
extern "C"  void NendAdInterstitial_Load_m_388685385_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___apiKey, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Show()
extern "C"  void NendAdInterstitial_Show_m_781036034_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Show(System.String)
extern "C"  void NendAdInterstitial_Show_m741307844_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Finish()
extern "C"  void NendAdInterstitial_Finish_m710191636_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Finish(System.String)
extern "C"  void NendAdInterstitial_Finish_m29685102_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___spotId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::Dismiss()
extern "C"  void NendAdInterstitial_Dismiss_m109278155_0 (NendAdInterstitial_t_1166267443_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::NendAdInterstitial_OnFinishLoad(System.String)
extern "C"  void NendAdInterstitial_NendAdInterstitial_OnFinishLoad_m414508710_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::NendAdInterstitial_OnClickAd(System.String)
extern "C"  void NendAdInterstitial_NendAdInterstitial_OnClickAd_m_746085128_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdInterstitial::NendAdInterstitial_OnShowAd(System.String)
extern "C"  void NendAdInterstitial_NendAdInterstitial_OnShowAd_m1627109087_0 (NendAdInterstitial_t_1166267443_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
