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

// System.Byte[]
struct ByteU5BU5D_t_1238178395_0;
// System.String
struct String_t;
// System.Text.Encoding
struct Encoding_t453909881_0;

#include "codegen/il2cpp-codegen.h"

// System.Void UnityEngine.WWWTranscoder::.cctor()
extern "C"  void WWWTranscoder__cctor_m1486747496_0 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Byte[] UnityEngine.WWWTranscoder::Byte2Hex(System.Byte,System.Byte[])
extern "C"  ByteU5BU5D_t_1238178395_0* WWWTranscoder_Byte2Hex_m_1879967800_0 (Object_t * __this /* static, unused */, uint8_t ___b, ByteU5BU5D_t_1238178395_0* ___hexChars, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.WWWTranscoder::URLEncode(System.String,System.Text.Encoding)
extern "C"  String_t* WWWTranscoder_URLEncode_m_993053478_0 (Object_t * __this /* static, unused */, String_t* ___toEncode, Encoding_t453909881_0 * ___e, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Byte[] UnityEngine.WWWTranscoder::Encode(System.Byte[],System.Byte,System.Byte,System.Byte[],System.Boolean)
extern "C"  ByteU5BU5D_t_1238178395_0* WWWTranscoder_Encode_m_1617530350_0 (Object_t * __this /* static, unused */, ByteU5BU5D_t_1238178395_0* ___input, uint8_t ___escapeChar, uint8_t ___space, ByteU5BU5D_t_1238178395_0* ___forbidden, bool ___uppercase, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.WWWTranscoder::ByteArrayContains(System.Byte[],System.Byte)
extern "C"  bool WWWTranscoder_ByteArrayContains_m_1050047307_0 (Object_t * __this /* static, unused */, ByteU5BU5D_t_1238178395_0* ___array, uint8_t ___b, const MethodInfo* method) IL2CPP_METHOD_ATTR;
