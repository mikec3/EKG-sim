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

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ValidationSpawner
struct  ValidationSpawner_t2037593317  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] ValidationSpawner::validation
	GameObjectU5BU5D_t3057952154* ___validation_2;
	// UnityEngine.GameObject ValidationSpawner::indicator
	GameObject_t1756533147 * ___indicator_3;

public:
	inline static int32_t get_offset_of_validation_2() { return static_cast<int32_t>(offsetof(ValidationSpawner_t2037593317, ___validation_2)); }
	inline GameObjectU5BU5D_t3057952154* get_validation_2() const { return ___validation_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_validation_2() { return &___validation_2; }
	inline void set_validation_2(GameObjectU5BU5D_t3057952154* value)
	{
		___validation_2 = value;
		Il2CppCodeGenWriteBarrier(&___validation_2, value);
	}

	inline static int32_t get_offset_of_indicator_3() { return static_cast<int32_t>(offsetof(ValidationSpawner_t2037593317, ___indicator_3)); }
	inline GameObject_t1756533147 * get_indicator_3() const { return ___indicator_3; }
	inline GameObject_t1756533147 ** get_address_of_indicator_3() { return &___indicator_3; }
	inline void set_indicator_3(GameObject_t1756533147 * value)
	{
		___indicator_3 = value;
		Il2CppCodeGenWriteBarrier(&___indicator_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
