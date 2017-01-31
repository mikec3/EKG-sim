#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Animator
struct Animator_t69676727;
// TimeKeeper
struct TimeKeeper_t281777607;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TimeRemainingController
struct  TimeRemainingController_t2373581983  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Animator TimeRemainingController::animator
	Animator_t69676727 * ___animator_2;
	// TimeKeeper TimeRemainingController::timeKeeper
	TimeKeeper_t281777607 * ___timeKeeper_3;

public:
	inline static int32_t get_offset_of_animator_2() { return static_cast<int32_t>(offsetof(TimeRemainingController_t2373581983, ___animator_2)); }
	inline Animator_t69676727 * get_animator_2() const { return ___animator_2; }
	inline Animator_t69676727 ** get_address_of_animator_2() { return &___animator_2; }
	inline void set_animator_2(Animator_t69676727 * value)
	{
		___animator_2 = value;
		Il2CppCodeGenWriteBarrier(&___animator_2, value);
	}

	inline static int32_t get_offset_of_timeKeeper_3() { return static_cast<int32_t>(offsetof(TimeRemainingController_t2373581983, ___timeKeeper_3)); }
	inline TimeKeeper_t281777607 * get_timeKeeper_3() const { return ___timeKeeper_3; }
	inline TimeKeeper_t281777607 ** get_address_of_timeKeeper_3() { return &___timeKeeper_3; }
	inline void set_timeKeeper_3(TimeKeeper_t281777607 * value)
	{
		___timeKeeper_3 = value;
		Il2CppCodeGenWriteBarrier(&___timeKeeper_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
