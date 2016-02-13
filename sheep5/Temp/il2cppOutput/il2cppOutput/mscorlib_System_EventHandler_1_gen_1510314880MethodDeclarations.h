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

// System.EventHandler`1<System.Object>
struct EventHandler_1_t_1510314880_0;
// System.Object
struct Object_t;
// System.IAsyncResult
struct IAsyncResult_t_1647744885_0;
// System.AsyncCallback
struct AsyncCallback_t_266361018_0;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_IntPtr_1047952454.h"

// System.Void System.EventHandler`1<System.Object>::.ctor(System.Object,System.IntPtr)
extern "C"  void EventHandler_1__ctor_m1337593804_0_gshared (EventHandler_1_t_1510314880_0 * __this, Object_t * ___object, IntPtr_t ___method, const MethodInfo* method);
#define EventHandler_1__ctor_m1337593804_0(__this, ___object, ___method, method) ((  void (*) (EventHandler_1_t_1510314880_0 *, Object_t *, IntPtr_t, const MethodInfo*))EventHandler_1__ctor_m1337593804_0_gshared)(__this, ___object, ___method, method)
// System.Void System.EventHandler`1<System.Object>::Invoke(System.Object,TEventArgs)
extern "C"  void EventHandler_1_Invoke_m_1671727339_0_gshared (EventHandler_1_t_1510314880_0 * __this, Object_t * ___sender, Object_t * ___e, const MethodInfo* method);
#define EventHandler_1_Invoke_m_1671727339_0(__this, ___sender, ___e, method) ((  void (*) (EventHandler_1_t_1510314880_0 *, Object_t *, Object_t *, const MethodInfo*))EventHandler_1_Invoke_m_1671727339_0_gshared)(__this, ___sender, ___e, method)
// System.IAsyncResult System.EventHandler`1<System.Object>::BeginInvoke(System.Object,TEventArgs,System.AsyncCallback,System.Object)
extern "C"  Object_t * EventHandler_1_BeginInvoke_m996893970_0_gshared (EventHandler_1_t_1510314880_0 * __this, Object_t * ___sender, Object_t * ___e, AsyncCallback_t_266361018_0 * ___callback, Object_t * ___object, const MethodInfo* method);
#define EventHandler_1_BeginInvoke_m996893970_0(__this, ___sender, ___e, ___callback, ___object, method) ((  Object_t * (*) (EventHandler_1_t_1510314880_0 *, Object_t *, Object_t *, AsyncCallback_t_266361018_0 *, Object_t *, const MethodInfo*))EventHandler_1_BeginInvoke_m996893970_0_gshared)(__this, ___sender, ___e, ___callback, ___object, method)
// System.Void System.EventHandler`1<System.Object>::EndInvoke(System.IAsyncResult)
extern "C"  void EventHandler_1_EndInvoke_m_1815787556_0_gshared (EventHandler_1_t_1510314880_0 * __this, Object_t * ___result, const MethodInfo* method);
#define EventHandler_1_EndInvoke_m_1815787556_0(__this, ___result, method) ((  void (*) (EventHandler_1_t_1510314880_0 *, Object_t *, const MethodInfo*))EventHandler_1_EndInvoke_m_1815787556_0_gshared)(__this, ___result, method)
