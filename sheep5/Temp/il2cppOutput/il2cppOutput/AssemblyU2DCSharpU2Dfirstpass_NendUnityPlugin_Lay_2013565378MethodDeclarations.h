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

// NendUnityPlugin.Layout.NendAdIconLayoutBuilder
struct NendAdIconLayoutBuilder_t_2013565378_0;
// System.String
struct String_t;
// NendUnityPlugin.Layout.NendAdIconLayoutParams
struct NendAdIconLayoutParams_t1980209795_0;
// System.Int32[]
struct Int32U5BU5D_t1872284309_0;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharpU2Dfirstpass_NendUnityPlugin_Comm_578890233.h"

// System.Void NendUnityPlugin.Layout.NendAdIconLayoutBuilder::.ctor()
extern "C"  void NendAdIconLayoutBuilder__ctor_m_257592488_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::Orientation(NendUnityPlugin.Common.Orientation)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_Orientation_m_1206121096_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___orientation, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::Gravity(System.Int32,System.Int32)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_Gravity_m_705923568_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, int32_t ___gravity, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::MarginLeft(System.Int32,System.Single)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_MarginLeft_m_729401115_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::MarginTop(System.Int32,System.Single)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_MarginTop_m_924455419_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::MarginRight(System.Int32,System.Single)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_MarginRight_m1994912780_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::MarginBottom(System.Int32,System.Single)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_MarginBottom_m_503470263_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::Size(System.Int32,System.Int32)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_Size_m766343019_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, int32_t ___size, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::SpaceEnabled(System.Int32,System.Boolean)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_SpaceEnabled_m_1237985033_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, bool ___enabled, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::TitleVisible(System.Int32,System.Boolean)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_TitleVisible_m_331424328_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, bool ___titleVisible, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutBuilder NendUnityPlugin.Layout.NendAdIconLayoutBuilder::TitleColor(System.Int32,System.String)
extern "C"  NendAdIconLayoutBuilder_t_2013565378_0 * NendAdIconLayoutBuilder_TitleColor_m_445859246_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, String_t* ___titleColor, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// NendUnityPlugin.Layout.NendAdIconLayoutParams NendUnityPlugin.Layout.NendAdIconLayoutBuilder::GetLayoutParams(System.Int32)
extern "C"  NendAdIconLayoutParams_t1980209795_0 * NendAdIconLayoutBuilder_GetLayoutParams_m_1096460764_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, int32_t ___tag, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String NendUnityPlugin.Layout.NendAdIconLayoutBuilder::Build(System.Int32[])
extern "C"  String_t* NendAdIconLayoutBuilder_Build_m646563664_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, Int32U5BU5D_t1872284309_0* ___tags, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String NendUnityPlugin.Layout.NendAdIconLayoutBuilder::Build()
extern "C"  String_t* NendAdIconLayoutBuilder_Build_m1221392609_0 (NendAdIconLayoutBuilder_t_2013565378_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
