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
	// UnityEngine.GameObject[] StripGenerator::StripArray2
	GameObjectU5BU5D_t3057952154* ___StripArray2_3;
	// System.Int32 StripGenerator::StripArraySize
	int32_t ___StripArraySize_4;
	// UnityEngine.GameObject StripGenerator::grid
	GameObject_t1756533147 * ___grid_6;
	// UnityEngine.GameObject StripGenerator::gridNow
	GameObject_t1756533147 * ___gridNow_7;
	// ButtonSpawner StripGenerator::buttonSpawner
	ButtonSpawner_t2293950372 * ___buttonSpawner_8;

public:
	inline static int32_t get_offset_of_StripArray_2() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___StripArray_2)); }
	inline GameObjectU5BU5D_t3057952154* get_StripArray_2() const { return ___StripArray_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_StripArray_2() { return &___StripArray_2; }
	inline void set_StripArray_2(GameObjectU5BU5D_t3057952154* value)
	{
		___StripArray_2 = value;
		Il2CppCodeGenWriteBarrier(&___StripArray_2, value);
	}

	inline static int32_t get_offset_of_StripArray2_3() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___StripArray2_3)); }
	inline GameObjectU5BU5D_t3057952154* get_StripArray2_3() const { return ___StripArray2_3; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_StripArray2_3() { return &___StripArray2_3; }
	inline void set_StripArray2_3(GameObjectU5BU5D_t3057952154* value)
	{
		___StripArray2_3 = value;
		Il2CppCodeGenWriteBarrier(&___StripArray2_3, value);
	}

	inline static int32_t get_offset_of_StripArraySize_4() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___StripArraySize_4)); }
	inline int32_t get_StripArraySize_4() const { return ___StripArraySize_4; }
	inline int32_t* get_address_of_StripArraySize_4() { return &___StripArraySize_4; }
	inline void set_StripArraySize_4(int32_t value)
	{
		___StripArraySize_4 = value;
	}

	inline static int32_t get_offset_of_grid_6() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___grid_6)); }
	inline GameObject_t1756533147 * get_grid_6() const { return ___grid_6; }
	inline GameObject_t1756533147 ** get_address_of_grid_6() { return &___grid_6; }
	inline void set_grid_6(GameObject_t1756533147 * value)
	{
		___grid_6 = value;
		Il2CppCodeGenWriteBarrier(&___grid_6, value);
	}

	inline static int32_t get_offset_of_gridNow_7() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___gridNow_7)); }
	inline GameObject_t1756533147 * get_gridNow_7() const { return ___gridNow_7; }
	inline GameObject_t1756533147 ** get_address_of_gridNow_7() { return &___gridNow_7; }
	inline void set_gridNow_7(GameObject_t1756533147 * value)
	{
		___gridNow_7 = value;
		Il2CppCodeGenWriteBarrier(&___gridNow_7, value);
	}

	inline static int32_t get_offset_of_buttonSpawner_8() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045, ___buttonSpawner_8)); }
	inline ButtonSpawner_t2293950372 * get_buttonSpawner_8() const { return ___buttonSpawner_8; }
	inline ButtonSpawner_t2293950372 ** get_address_of_buttonSpawner_8() { return &___buttonSpawner_8; }
	inline void set_buttonSpawner_8(ButtonSpawner_t2293950372 * value)
	{
		___buttonSpawner_8 = value;
		Il2CppCodeGenWriteBarrier(&___buttonSpawner_8, value);
	}
};

struct StripGenerator_t1556666045_StaticFields
{
public:
	// UnityEngine.GameObject StripGenerator::Strip
	GameObject_t1756533147 * ___Strip_5;

public:
	inline static int32_t get_offset_of_Strip_5() { return static_cast<int32_t>(offsetof(StripGenerator_t1556666045_StaticFields, ___Strip_5)); }
	inline GameObject_t1756533147 * get_Strip_5() const { return ___Strip_5; }
	inline GameObject_t1756533147 ** get_address_of_Strip_5() { return &___Strip_5; }
	inline void set_Strip_5(GameObject_t1756533147 * value)
	{
		___Strip_5 = value;
		Il2CppCodeGenWriteBarrier(&___Strip_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
