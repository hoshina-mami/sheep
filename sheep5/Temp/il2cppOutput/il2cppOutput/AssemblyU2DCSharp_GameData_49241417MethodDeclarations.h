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

// GameData
struct GameData_t_49241417_0;
// StageData
struct StageData_t_665732307_0;
// SheepData
struct SheepData_t_896671990_0;

#include "codegen/il2cpp-codegen.h"

// System.Void GameData::.ctor()
extern "C"  void GameData__ctor_m_1956549825_0 (GameData_t_49241417_0 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// StageData GameData::GetStageData(System.Int32)
extern "C"  StageData_t_665732307_0 * GameData_GetStageData_m_1286521933_0 (GameData_t_49241417_0 * __this, int32_t ___stageNum, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// SheepData GameData::GetStSheepData(System.Int32)
extern "C"  SheepData_t_896671990_0 * GameData_GetStSheepData_m_1043165070_0 (GameData_t_49241417_0 * __this, int32_t ___sheepId, const MethodInfo* method) IL2CPP_METHOD_ATTR;
