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

// NendUnityPlugin.AD.NendAdIcon
struct NendAdIcon_t878522906_0;
// System.EventHandler
struct EventHandler_t_1938407861_0;
// System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs>
struct EventHandler_1_t2039357842_0;
// NendUnityPlugin.Callback.NendAdIconCallback
struct NendAdIconCallback_t_723244931_0;
// NendUnityPlugin.Platform.NendAdIconInterface
struct NendAdIconInterface_t_606613201_0;
// NendUnityPlugin.Layout.NendAdLayoutBuilder
struct NendAdLayoutBuilder_t718549303_0;
// System.String
struct String_t;
// NendUnityPlugin.AD.NendAdIcon/Icon[]
struct IconU5BU5D_t1495463760_0;

#include "codegen/il2cpp-codegen.h"

// System.Void NendUnityPlugin.AD.NendAdIcon::.ctor()
extern "C"  void NendAdIcon__ctor_m461693942_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::add_AdLoaded(System.EventHandler)
extern "C"  void NendAdIcon_add_AdLoaded_m1879505839_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::remove_AdLoaded(System.EventHandler)
extern "C"  void NendAdIcon_remove_AdLoaded_m_1216295284_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::add_AdFailedToReceive(System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs>)
extern "C"  void NendAdIcon_add_AdFailedToReceive_m_66028941_0 (NendAdIcon_t878522906_0 * __this, EventHandler_1_t2039357842_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::remove_AdFailedToReceive(System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs>)
extern "C"  void NendAdIcon_remove_AdFailedToReceive_m1689784912_0 (NendAdIcon_t878522906_0 * __this, EventHandler_1_t2039357842_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::add_AdReceived(System.EventHandler)
extern "C"  void NendAdIcon_add_AdReceived_m_410761517_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::remove_AdReceived(System.EventHandler)
extern "C"  void NendAdIcon_remove_AdReceived_m936695408_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::add_AdClicked(System.EventHandler)
extern "C"  void NendAdIcon_add_AdClicked_m1553052905_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::remove_AdClicked(System.EventHandler)
extern "C"  void NendAdIcon_remove_AdClicked_m72498604_0 (NendAdIcon_t878522906_0 * __this, EventHandler_t_1938407861_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::set_Callback(NendUnityPlugin.Callback.NendAdIconCallback)
extern "C"  void NendAdIcon_set_Callback_m1275621214_0 (NendAdIcon_t878522906_0 * __this, Object_t * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Platform.NendAdIconInterface NendUnityPlugin.AD.NendAdIcon::get_Interface()
extern "C"  Object_t * NendAdIcon_get_Interface_m426996225_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Create()
extern "C"  void NendAdIcon_Create_m_642673334_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Show()
extern "C"  void NendAdIcon_Show_m385909323_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Hide()
extern "C"  void NendAdIcon_Hide_m71567184_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Resume()
extern "C"  void NendAdIcon_Resume_m1496101947_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Pause()
extern "C"  void NendAdIcon_Pause_m515819914_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Destroy()
extern "C"  void NendAdIcon_Destroy_m_1354556978_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::Layout(NendUnityPlugin.Layout.NendAdLayoutBuilder)
extern "C"  void NendAdIcon_Layout_m550391016_0 (NendAdIcon_t878522906_0 * __this, Object_t * ___builder, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String NendUnityPlugin.AD.NendAdIcon::MakeParams()
extern "C"  String_t* NendAdIcon_MakeParams_m1645441503_0 (NendAdIcon_t878522906_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::NendAdIconLoader_OnFinishLoad(System.String)
extern "C"  void NendAdIcon_NendAdIconLoader_OnFinishLoad_m1594001395_0 (NendAdIcon_t878522906_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::NendAdIconLoader_OnFailToReceiveAd(System.String)
extern "C"  void NendAdIcon_NendAdIconLoader_OnFailToReceiveAd_m1732139305_0 (NendAdIcon_t878522906_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::NendAdIconLoader_OnReceiveAd(System.String)
extern "C"  void NendAdIcon_NendAdIconLoader_OnReceiveAd_m1753440656_0 (NendAdIcon_t878522906_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void NendUnityPlugin.AD.NendAdIcon::NendAdIconLoader_OnClickAd(System.String)
extern "C"  void NendAdIcon_NendAdIconLoader_OnClickAd_m_397586741_0 (NendAdIcon_t878522906_0 * __this, String_t* ___message, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean NendUnityPlugin.AD.NendAdIcon::hasDuplicatedTag(NendUnityPlugin.AD.NendAdIcon/Icon[])
extern "C"  bool NendAdIcon_hasDuplicatedTag_m1934653616_0 (NendAdIcon_t878522906_0 * __this, IconU5BU5D_t1495463760_0* ___icon, const MethodInfo* method) IL2CPP_METHOD_ATTR;
