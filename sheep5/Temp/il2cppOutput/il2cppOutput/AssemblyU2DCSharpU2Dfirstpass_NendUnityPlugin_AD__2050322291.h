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
// NendUnityPlugin.Callback.NendAdBannerCallback
struct NendAdBannerCallback_t_1917428624_0;
// NendUnityPlugin.Platform.NendAdBannerInterface
struct NendAdBannerInterface_t1619494940_0;
// System.EventHandler
struct EventHandler_t_1938407861_0;
// System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs>
struct EventHandler_1_t2039357842_0;

#include "AssemblyU2DCSharpU2Dfirstpass_NendUnityPlugin_AD_N1056008705.h"
#include "AssemblyU2DCSharpU2Dfirstpass_NendUnityPlugin_AD__1859940305.h"

// NendUnityPlugin.AD.NendAdBanner
struct  NendAdBanner_t_2050322291_0  : public NendAd_t1056008705_0
{
	// NendUnityPlugin.AD.NendAdBanner/BannerSize NendUnityPlugin.AD.NendAdBanner::size
	int32_t ___size_5;
	// NendUnityPlugin.Common.Gravity[] NendUnityPlugin.AD.NendAdBanner::gravity
	GravityU5BU5D_t_20339673_0* ___gravity_6;
	// NendUnityPlugin.AD.NendAd/Margin NendUnityPlugin.AD.NendAdBanner::margin
	Margin_t597349788_0 * ___margin_7;
	// NendUnityPlugin.Callback.NendAdBannerCallback NendUnityPlugin.AD.NendAdBanner::_callback
	Object_t * ____callback_8;
	// NendUnityPlugin.Platform.NendAdBannerInterface NendUnityPlugin.AD.NendAdBanner::_interface
	Object_t * ____interface_9;
	// System.EventHandler NendUnityPlugin.AD.NendAdBanner::AdLoaded
	EventHandler_t_1938407861_0 * ___AdLoaded_10;
	// System.EventHandler`1<NendUnityPlugin.Common.NendAdErrorEventArgs> NendUnityPlugin.AD.NendAdBanner::AdFailedToReceive
	EventHandler_1_t2039357842_0 * ___AdFailedToReceive_11;
	// System.EventHandler NendUnityPlugin.AD.NendAdBanner::AdReceived
	EventHandler_t_1938407861_0 * ___AdReceived_12;
	// System.EventHandler NendUnityPlugin.AD.NendAdBanner::AdClicked
	EventHandler_t_1938407861_0 * ___AdClicked_13;
	// System.EventHandler NendUnityPlugin.AD.NendAdBanner::AdBacked
	EventHandler_t_1938407861_0 * ___AdBacked_14;
};
