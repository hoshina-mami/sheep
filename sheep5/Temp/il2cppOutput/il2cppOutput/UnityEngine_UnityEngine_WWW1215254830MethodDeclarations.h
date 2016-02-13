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

// UnityEngine.WWW
struct WWW_t1215254830_0;
// System.String
struct String_t;
// System.Text.Encoding
struct Encoding_t453909881_0;

#include "codegen/il2cpp-codegen.h"

// System.Void UnityEngine.WWW::Dispose()
extern "C"  void WWW_Dispose_m_1848288929_0 (WWW_t1215254830_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::Finalize()
extern "C"  void WWW_Finalize_m1793349504_0 (WWW_t1215254830_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::DestroyWWW(System.Boolean)
extern "C"  void WWW_DestroyWWW_m300967382_0 (WWW_t1215254830_0 * __this, bool ___cancel, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.WWW::EscapeURL(System.String)
extern "C"  String_t* WWW_EscapeURL_m1167392721_0 (Object_t * __this /* static, unused */, String_t* ___s, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.WWW::EscapeURL(System.String,System.Text.Encoding)
extern "C"  String_t* WWW_EscapeURL_m1690274784_0 (Object_t * __this /* static, unused */, String_t* ___s, Encoding_t453909881_0 * ___e, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Text.Encoding UnityEngine.WWW::get_DefaultEncoding()
extern "C"  Encoding_t453909881_0 * WWW_get_DefaultEncoding_m_1787603003_0 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
