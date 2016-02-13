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

// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"

// System.Boolean UnityEngine.PlayerPrefs::TrySetInt(System.String,System.Int32)
extern "C"  bool PlayerPrefs_TrySetInt_m2066630347_0 (Object_t * __this /* static, unused */, String_t* ___key, int32_t ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.PlayerPrefs::SetInt(System.String,System.Int32)
extern "C"  void PlayerPrefs_SetInt_m_809795300_0 (Object_t * __this /* static, unused */, String_t* ___key, int32_t ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.PlayerPrefs::GetInt(System.String,System.Int32)
extern "C"  int32_t PlayerPrefs_GetInt_m_662221016_0 (Object_t * __this /* static, unused */, String_t* ___key, int32_t ___defaultValue, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.PlayerPrefs::GetInt(System.String)
extern "C"  int32_t PlayerPrefs_GetInt_m1334009359_0 (Object_t * __this /* static, unused */, String_t* ___key, const MethodInfo* method) IL2CPP_METHOD_ATTR;
