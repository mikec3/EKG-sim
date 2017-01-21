#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Text
struct Text_t356221433;
// TimeKeeper
struct TimeKeeper_t281777607;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ScoreKeeper
struct  ScoreKeeper_t1955354816  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text ScoreKeeper::text
	Text_t356221433 * ___text_4;
	// UnityEngine.UI.Text ScoreKeeper::stats
	Text_t356221433 * ___stats_5;
	// UnityEngine.UI.Text ScoreKeeper::instructions
	Text_t356221433 * ___instructions_6;
	// TimeKeeper ScoreKeeper::timeKeeper
	TimeKeeper_t281777607 * ___timeKeeper_7;
	// System.Single ScoreKeeper::shortTimer
	float ___shortTimer_8;

public:
	inline static int32_t get_offset_of_text_4() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816, ___text_4)); }
	inline Text_t356221433 * get_text_4() const { return ___text_4; }
	inline Text_t356221433 ** get_address_of_text_4() { return &___text_4; }
	inline void set_text_4(Text_t356221433 * value)
	{
		___text_4 = value;
		Il2CppCodeGenWriteBarrier(&___text_4, value);
	}

	inline static int32_t get_offset_of_stats_5() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816, ___stats_5)); }
	inline Text_t356221433 * get_stats_5() const { return ___stats_5; }
	inline Text_t356221433 ** get_address_of_stats_5() { return &___stats_5; }
	inline void set_stats_5(Text_t356221433 * value)
	{
		___stats_5 = value;
		Il2CppCodeGenWriteBarrier(&___stats_5, value);
	}

	inline static int32_t get_offset_of_instructions_6() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816, ___instructions_6)); }
	inline Text_t356221433 * get_instructions_6() const { return ___instructions_6; }
	inline Text_t356221433 ** get_address_of_instructions_6() { return &___instructions_6; }
	inline void set_instructions_6(Text_t356221433 * value)
	{
		___instructions_6 = value;
		Il2CppCodeGenWriteBarrier(&___instructions_6, value);
	}

	inline static int32_t get_offset_of_timeKeeper_7() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816, ___timeKeeper_7)); }
	inline TimeKeeper_t281777607 * get_timeKeeper_7() const { return ___timeKeeper_7; }
	inline TimeKeeper_t281777607 ** get_address_of_timeKeeper_7() { return &___timeKeeper_7; }
	inline void set_timeKeeper_7(TimeKeeper_t281777607 * value)
	{
		___timeKeeper_7 = value;
		Il2CppCodeGenWriteBarrier(&___timeKeeper_7, value);
	}

	inline static int32_t get_offset_of_shortTimer_8() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816, ___shortTimer_8)); }
	inline float get_shortTimer_8() const { return ___shortTimer_8; }
	inline float* get_address_of_shortTimer_8() { return &___shortTimer_8; }
	inline void set_shortTimer_8(float value)
	{
		___shortTimer_8 = value;
	}
};

struct ScoreKeeper_t1955354816_StaticFields
{
public:
	// System.Single ScoreKeeper::correct
	float ___correct_2;
	// System.Single ScoreKeeper::inCorrect
	float ___inCorrect_3;

public:
	inline static int32_t get_offset_of_correct_2() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816_StaticFields, ___correct_2)); }
	inline float get_correct_2() const { return ___correct_2; }
	inline float* get_address_of_correct_2() { return &___correct_2; }
	inline void set_correct_2(float value)
	{
		___correct_2 = value;
	}

	inline static int32_t get_offset_of_inCorrect_3() { return static_cast<int32_t>(offsetof(ScoreKeeper_t1955354816_StaticFields, ___inCorrect_3)); }
	inline float get_inCorrect_3() const { return ___inCorrect_3; }
	inline float* get_address_of_inCorrect_3() { return &___inCorrect_3; }
	inline void set_inCorrect_3(float value)
	{
		___inCorrect_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
