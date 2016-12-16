#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// ButtonSpawner
struct ButtonSpawner_t2293950372;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// StripGenerator
struct  StripGenerator_t1556666045  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] StripGenerator::StripArray
	GameObjectU5BU5D_t3057952154* ___StripArray_2;
	// System.Int32 StripGenerator::StripArraySize
	int32_t ___StripArraySize_3;
	// UnityEngine.GameObject StripGenerator::grid
	GameObject_t1756533147 * ___grid_5;
	// UnityEngine.GameObject StripGenerator::gridNow
	GameObject_t1756533147 * ___gridNow_6;
	// ButtonSpawner StripGenerator::buttonSpawner
	ButtonSpawner_t2293950372 * ___buttonSpawner_7;

public:
	inline static int32_t get_offset_of_StripArray_2() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___StripArray_2)); }
	inline GameObjectU5BU5D_t3057952154* get_StripArray_2() const { return ___StripArray_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_StripArray_2() { return &___StripArray_2; }
	inline void set_StripArray_2(GameObjectU5BU5D_t3057952154* value)
	{
		___StripArray_2 = value;
		Il2CppCodeGenWriteBarrier(&___StripArray_2, value);
	}

	inline static int32_t get_offset_of_StripArraySize_3() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___StripArraySize_3)); }
	inline int32_t get_StripArraySize_3() const { return ___StripArraySize_3; }
	inline int32_t* get_address_of_StripArraySize_3() { return &___StripArraySize_3; }
	inline void set_StripArraySize_3(int32_t value)
	{
		___StripArraySize_3 = value;
	}

	inline static int32_t get_offset_of_grid_5() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___grid_5)); }
	inline GameObject_t1756533147 * get_grid_5() const { return ___grid_5; }
	inline GameObject_t1756533147 ** get_address_of_grid_5() { return &___grid_5; }
	inline void set_grid_5(GameObject_t1756533147 * value)
	{
		___grid_5 = value;
		Il2CppCodeGenWriteBarrier(&___grid_5, value);
	}

	inline static int32_t get_offset_of_gridNow_6() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___gridNow_6)); }
	inline GameObject_t1756533147 * get_gridNow_6() const { return ___gridNow_6; }
	inline GameObject_t1756533147 ** get_address_of_gridNow_6() { return &___gridNow_6; }
	inline void set_gridNow_6(GameObject_t1756533147 * value)
	{
		___gridNow_6 = value;
		Il2CppCodeGenWriteBarrier(&___gridNow_6, value);
	}

	inline static int32_t get_offset_of_buttonSpawner_7() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___buttonSpawner_7)); }
	inline ButtonSpawner_t2293950372 * get_buttonSpawner_7() const { return ___buttonSpawner_7; }
	inline ButtonSpawner_t2293950372 ** get_address_of_buttonSpawner_7() { return &___buttonSpawner_7; }
	inline void set_buttonSpawner_7(ButtonSpawner_t2293950372 * value)
	{
		___buttonSpawner_7 = value;
		Il2CppCodeGenWriteBarrier(&___buttonSpawner_7, value);
	}
};

struct StripGenerator_t1556666045_StaticFields
{
public:
	// UnityEngine.GameObject StripGenerator::Strip
	GameObject_t1756533147 * ___Strip_4;

public:
	inline static int32_t get_offset_of_Strip_4() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045_StaticFields, ___Strip_4)); }
	inline GameObject_t1756533147 * get_Strip_4() const { return ___Strip_4; }
	inline GameObject_t1756533147 ** get_address_of_Strip_4() { return &___Strip_4; }
	inline void set_Strip_4(GameObject_t1756533147 * value)
	{
		___Strip_4 = value;
		Il2CppCodeGenWriteBarrier(&___Strip_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
