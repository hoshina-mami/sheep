#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// NendUnityPlugin.AD.NendAdInterstitial
struct NendAdInterstitial_t_1166267443_0;
// NendUnityPlugin.Callback.NendAdInterstitialCallback
struct NendAdInterstitialCallback_t1952375088_0;
// NendUnityPlugin.Platform.NendAdInterstitialInterface
struct NendAdInterstitialInterface_t_1228201764_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialLoadEventArgs>
struct EventHandler_1_t786484606_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialClickEventArgs>
struct EventHandler_1_t_339205410_0;
// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialShowEventArgs>
struct EventHandler_1_t1326215893_0;

#include "UnityEngine_UnityEngine_MonoBehaviour_92453903.h"

// NendUnityPlugin.AD.NendAdInterstitial
struct  NendAdInterstitial_t_1166267443_0  : public MonoBehaviour_t_92453903_0
{
	// System.Boolean NendUnityPlugin.AD.NendAdInterstitial::outputLog
	bool ___outputLog_2;
	// NendUnityPlugin.Callback.NendAdInterstitialCallback NendUnityPlugin.AD.NendAdInterstitial::_callback
	Object_t * ____callback_4;
	// NendUnityPlugin.Platform.NendAdInterstitialInterface NendUnityPlugin.AD.NendAdInterstitial::_interface
	Object_t * ____interface_5;
	// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialLoadEventArgs> NendUnityPlugin.AD.NendAdInterstitial::AdLoaded
	EventHandler_1_t786484606_0 * ___AdLoaded_6;
	// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialClickEventArgs> NendUnityPlugin.AD.NendAdInterstitial::AdClicked
	EventHandler_1_t_339205410_0 * ___AdClicked_7;
	// System.EventHandler`1<NendUnityPlugin.AD.NendAdInterstitialShowEventArgs> NendUnityPlugin.AD.NendAdInterstitial::AdShown
	EventHandler_1_t1326215893_0 * ___AdShown_8;
};
struct NendAdInterstitial_t_1166267443_0_StaticFields{
	// NendUnityPlugin.AD.NendAdInterstitial NendUnityPlugin.AD.NendAdInterstitial::_instance
	NendAdInterstitial_t_1166267443_0 * ____instance_3;
};
