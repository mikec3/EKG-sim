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

// ButtonSpawner
struct ButtonSpawner_t2293950372;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String2029220233.h"

// System.Void ButtonSpawner::.ctor()
extern "C"  void ButtonSpawner__ctor_m3673095665 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::Start()
extern "C"  void ButtonSpawner_Start_m804560745 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::Update()
extern "C"  void ButtonSpawner_Update_m2826876238 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::CreateRandomAnswerButtons()
extern "C"  void ButtonSpawner_CreateRandomAnswerButtons_m3533448547 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::CorrectAnswerLoop()
extern "C"  void ButtonSpawner_CorrectAnswerLoop_m1034253243 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::RandomAnswersLoop(System.Int32)
extern "C"  void ButtonSpawner_RandomAnswersLoop_m2467806138 (ButtonSpawner_t2293950372 * __this, int32_t ___randomNumber0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean ButtonSpawner::DuplicateAnswer(System.Int32)
extern "C"  bool ButtonSpawner_DuplicateAnswer_m669037951 (ButtonSpawner_t2293950372 * __this, int32_t ___indexer0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean ButtonSpawner::DuplicateButtons(System.Int32)
extern "C"  bool ButtonSpawner_DuplicateButtons_m1489881866 (ButtonSpawner_t2293950372 * __this, int32_t ___indexer0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::DestroyAllButtons()
extern "C"  void ButtonSpawner_DestroyAllButtons_m3608817307 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::CreateAllButtons()
extern "C"  void ButtonSpawner_CreateAllButtons_m322605169 (ButtonSpawner_t2293950372 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::CreateButtons(System.Int32)
extern "C"  void ButtonSpawner_CreateButtons_m514748465 (ButtonSpawner_t2293950372 * __this, int32_t ___index0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ButtonSpawner::buttonPressed(System.String)
extern "C"  void ButtonSpawner_buttonPressed_m3460457663 (ButtonSpawner_t2293950372 * __this, String_t* ___name0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
