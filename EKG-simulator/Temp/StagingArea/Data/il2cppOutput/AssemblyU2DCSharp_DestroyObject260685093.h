#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// LessonTextManager
struct LessonTextManager_t2523997030;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DestroyObject
struct  DestroyObject_t260685093  : public MonoBehaviour_t1158329972
{
public:
	// LessonTextManager DestroyObject::lessonManager
	LessonTextManager_t2523997030 * ___lessonManager_2;

public:
	inline static int32_t get_offset_of_lessonManager_2() { return static_cast<int32_t>(offsetof(DestroyObject_t260685093, ___lessonManager_2)); }
	inline LessonTextManager_t2523997030 * get_lessonManager_2() const { return ___lessonManager_2; }
	inline LessonTextManager_t2523997030 ** get_address_of_lessonManager_2() { return &___lessonManager_2; }
	inline void set_lessonManager_2(LessonTextManager_t2523997030 * value)
	{
		___lessonManager_2 = value;
		Il2CppCodeGenWriteBarrier(&___lessonManager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
