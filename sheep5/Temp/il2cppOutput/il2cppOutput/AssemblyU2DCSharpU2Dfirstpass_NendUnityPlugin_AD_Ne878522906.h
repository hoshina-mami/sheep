#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// NendUnityPlugin.Common.Gravity[]
struct GravityU5BU5D_t_20339673_0;
// NendUnityPlugin.AD.NendAd/Margin
struct Margin_t597349788_0;
// NendUnityPlugin.AD.NendAdIcon/Icon[]
struct IconU5BU5D_t1495463760_0;
// NendUnityPlugin.Callback.NendAdIconCallback
struct NendAdIconCallback_t_723244931_0;
// NendUnityPlugin.Platform.NendAdIconInterface
struct NendAdIconInterface_t_606613201_0;
// System.EventHandler
struct EventHandler_t_1938407861_0;
// System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs>
struct EventHandler_1_t2039357842_0;

#include "AssemblyU2DCSharpU2Dfirstpass_NendUnityPlugin_AD_N1056008705.h"
#include "AssemblyU2DCSharpU2Dfirstpass_NendUnityPlugin_Comm_578890233.h"

// NendUnityPlugin.AD.NendAdIcon
struct  NendAdIcon_t878522906_0  : public NendAd_t1056008705_0
{
	// NendUnityPlugin.Common.Orientation NendUnityPlugin.AD.NendAdIcon::orientation
	int32_t ___orientation_5;
	// NendUnityPlugin.Common.Gravity[] NendUnityPlugin.AD.NendAdIcon::gravity
	GravityU5BU5D_t_20339673_0* ___gravity_6;
	// NendUnityPlugin.AD.NendAd/Margin NendUnityPlugin.AD.NendAdIcon::margin
	Margin_t597349788_0 * ___margin_7;
	// NendUnityPlugin.AD.NendAdIcon/Icon[] NendUnityPlugin.AD.NendAdIcon::icon
	IconU5BU5D_t1495463760_0* ___icon_8;
	// NendUnityPlugin.Callback.NendAdIconCallback NendUnityPlugin.AD.NendAdIcon::_callback
	Object_t * ____callback_9;
	// NendUnityPlugin.Platform.NendAdIconInterface NendUnityPlugin.AD.NendAdIcon::_interface
	Object_t * ____interface_10;
	// System.EventHandler NendUnityPlugin.AD.NendAdIcon::AdLoaded
	EventHandler_t_1938407861_0 * ___AdLoaded_11;
	// System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs> NendUnityPlugin.AD.NendAdIcon::AdFailedToReceive
	EventHandler_1_t2039357842_0 * ___AdFailedToReceive_12;
	// System.EventHandler NendUnityPlugin.AD.NendAdIcon::AdReceived
	EventHandler_t_1938407861_0 * ___AdReceived_13;
	// System.EventHandler NendUnityPlugin.AD.NendAdIcon::AdClicked
	EventHandler_t_1938407861_0 * ___AdClicked_14;
};
