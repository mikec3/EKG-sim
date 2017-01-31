#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LessonTextManager
struct  LessonTextManager_t2523997030  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject LessonTextManager::lessonPreFab
	GameObject_t1756533147 * ___lessonPreFab_2;
	// UnityEngine.GameObject LessonTextManager::lessonClone
	GameObject_t1756533147 * ___lessonClone_3;

public:
	inline static int32_t get_offset_of_lessonPreFab_2() { return static_cast<int32_t>(offsetof(LessonTextManager_t2523997030, ___lessonPreFab_2)); }
	inline GameObject_t1756533147 * get_lessonPreFab_2() const { return ___lessonPreFab_2; }
	inline GameObject_t1756533147 ** get_address_of_lessonPreFab_2() { return &___lessonPreFab_2; }
	inline void set_lessonPreFab_2(GameObject_t1756533147 * value)
	{
		___lessonPreFab_2 = value;
		Il2CppCodeGenWriteBarrier(&___lessonPreFab_2, value);
	}

	inline static int32_t get_offset_of_lessonClone_3() { return static_cast<int32_t>(offsetof(LessonTextManager_t2523997030, ___lessonClone_3)); }
	inline GameObject_t1756533147 * get_lessonClone_3() const { return ___lessonClone_3; }
	inline GameObject_t1756533147 ** get_address_of_lessonClone_3() { return &___lessonClone_3; }
	inline void set_lessonClone_3(GameObject_t1756533147 * value)
	{
		___lessonClone_3 = value;
		Il2CppCodeGenWriteBarrier(&___lessonClone_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
