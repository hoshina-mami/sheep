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

// uTools.EaseManager/EaseDelegate
struct EaseDelegate_t_324320176_0;
// System.Object
struct Object_t;
// System.IAsyncResult
struct IAsyncResult_t_1647744885_0;
// System.AsyncCallback
struct AsyncCallback_t_266361018_0;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_IntPtr_1047952454.h"

// System.Void uTools.EaseManager/EaseDelegate::.ctor(System.Object,System.IntPtr)
extern "C"  void EaseDelegate__ctor_m_2014350622_0 (EaseDelegate_t_324320176_0 * __this, Object_t * ___object, IntPtr_t ___method, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single uTools.EaseManager/EaseDelegate::Invoke(System.Single,System.Single,System.Single)
extern "C"  float EaseDelegate_Invoke_m259134405_0 (EaseDelegate_t_324320176_0 * __this, float ___start, float ___end, float ___t, const MethodInfo* method) IL2CPP_METHOD_ATTR;
extern "C" float pinvoke_delegate_wrapper_EaseDelegate_t_324320176_0(Il2CppObject* delegate, float ___start, float ___end, float ___t);
// System.IAsyncResult uTools.EaseManager/EaseDelegate::BeginInvoke(System.Single,System.Single,System.Single,System.AsyncCallback,System.Object)
extern "C"  Object_t * EaseDelegate_BeginInvoke_m1889025344_0 (EaseDelegate_t_324320176_0 * __this, float ___start, float ___end, float ___t, AsyncCallback_t_266361018_0 * ___callback, Object_t * ___object, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single uTools.EaseManager/EaseDelegate::EndInvoke(System.IAsyncResult)
extern "C"  float EaseDelegate_EndInvoke_m824713126_0 (EaseDelegate_t_324320176_0 * __this, Object_t * ___result, const MethodInfo* method) IL2CPP_METHOD_ATTR;
