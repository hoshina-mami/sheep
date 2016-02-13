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

// UnityEngine.Material
struct Material_t1701708784_0;
// UnityEngine.Texture
struct Texture_t1814018354_0;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Color_388944582.h"

// System.Void UnityEngine.Material::.ctor(UnityEngine.Material)
extern "C"  void Material__ctor_m_1747999736_0 (Material_t1701708784_0 * __this, Material_t1701708784_0 * ___source, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Color UnityEngine.Material::get_color()
extern "C"  Color_t_388944582_0  Material_get_color_m_2026021769_0 (Material_t1701708784_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::set_color(UnityEngine.Color)
extern "C"  void Material_set_color_m_998110276_0 (Material_t1701708784_0 * __this, Color_t_388944582_0  ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture UnityEngine.Material::get_mainTexture()
extern "C"  Texture_t1814018354_0 * Material_get_mainTexture_m1012267054_0 (Material_t1701708784_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetColor(System.String,UnityEngine.Color)
extern "C"  void Material_SetColor_m1918430019_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, Color_t_388944582_0  ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetColor(System.Int32,UnityEngine.Color)
extern "C"  void Material_SetColor_m54957808_0 (Material_t1701708784_0 * __this, int32_t ___nameID, Color_t_388944582_0  ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::INTERNAL_CALL_SetColor(UnityEngine.Material,System.Int32,UnityEngine.Color&)
extern "C"  void Material_INTERNAL_CALL_SetColor_m_1085955819_0 (Object_t * __this /* static, unused */, Material_t1701708784_0 * ___self, int32_t ___nameID, Color_t_388944582_0 * ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Color UnityEngine.Material::GetColor(System.String)
extern "C"  Color_t_388944582_0  Material_GetColor_m1709543664_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Color UnityEngine.Material::GetColor(System.Int32)
extern "C"  Color_t_388944582_0  Material_GetColor_m317509027_0 (Material_t1701708784_0 * __this, int32_t ___nameID, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::INTERNAL_CALL_GetColor(UnityEngine.Material,System.Int32,UnityEngine.Color&)
extern "C"  void Material_INTERNAL_CALL_GetColor_m_866622047_0 (Object_t * __this /* static, unused */, Material_t1701708784_0 * ___self, int32_t ___nameID, Color_t_388944582_0 * ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture UnityEngine.Material::GetTexture(System.String)
extern "C"  Texture_t1814018354_0 * Material_GetTexture_m1284113328_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture UnityEngine.Material::GetTexture(System.Int32)
extern "C"  Texture_t1814018354_0 * Material_GetTexture_m_527498525_0 (Material_t1701708784_0 * __this, int32_t ___nameID, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetFloat(System.String,System.Single)
extern "C"  void Material_SetFloat_m981710063_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetFloat(System.Int32,System.Single)
extern "C"  void Material_SetFloat_m170145518_0 (Material_t1701708784_0 * __this, int32_t ___nameID, float ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetInt(System.String,System.Int32)
extern "C"  void Material_SetInt_m_1645572256_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, int32_t ___value, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Material::HasProperty(System.String)
extern "C"  bool Material_HasProperty_m2077312757_0 (Material_t1701708784_0 * __this, String_t* ___propertyName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Material::HasProperty(System.Int32)
extern "C"  bool Material_HasProperty_m190825214_0 (Material_t1701708784_0 * __this, int32_t ___nameID, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::Internal_CreateWithMaterial(UnityEngine.Material,UnityEngine.Material)
extern "C"  void Material_Internal_CreateWithMaterial_m_1945555625_0 (Object_t * __this /* static, unused */, Material_t1701708784_0 * ___mono, Material_t1701708784_0 * ___source, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::EnableKeyword(System.String)
extern "C"  void Material_EnableKeyword_m_492254312_0 (Material_t1701708784_0 * __this, String_t* ___keyword, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::DisableKeyword(System.String)
extern "C"  void Material_DisableKeyword_m572736419_0 (Material_t1701708784_0 * __this, String_t* ___keyword, const MethodInfo* method) IL2CPP_METHOD_ATTR;
