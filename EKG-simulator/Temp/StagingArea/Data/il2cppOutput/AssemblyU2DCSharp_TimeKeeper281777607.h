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
// ButtonSpawner
struct ButtonSpawner_t2293950372;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TimeKeeper
struct  TimeKeeper_t281777607  : public MonoBehaviour_t1158329972
{
public:
	// System.Single TimeKeeper::gameTime
	float ___gameTime_2;
	// System.Single TimeKeeper::timeLeft
	float ___timeLeft_3;
	// UnityEngine.UI.Text TimeKeeper::text
	Text_t356221433 * ___text_4;
	// System.Single TimeKeeper::minutes
	float ___minutes_5;
	// System.Single TimeKeeper::seconds
	float ___seconds_6;
	// ButtonSpawner TimeKeeper::buttonSpawner
	ButtonSpawner_t2293950372 * ___buttonSpawner_10;

public:
	inline static int32_t get_offset_of_gameTime_2() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___gameTime_2)); }
	inline float get_gameTime_2() const { return ___gameTime_2; }
	inline float* get_address_of_gameTime_2() { return &___gameTime_2; }
	inline void set_gameTime_2(float value)
	{
		___gameTime_2 = value;
	}

	inline static int32_t get_offset_of_timeLeft_3() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___timeLeft_3)); }
	inline float get_timeLeft_3() const { return ___timeLeft_3; }
	inline float* get_address_of_timeLeft_3() { return &___timeLeft_3; }
	inline void set_timeLeft_3(float value)
	{
		___timeLeft_3 = value;
	}

	inline static int32_t get_offset_of_text_4() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___text_4)); }
	inline Text_t356221433 * get_text_4() const { return ___text_4; }
	inline Text_t356221433 ** get_address_of_text_4() { return &___text_4; }
	inline void set_text_4(Text_t356221433 * value)
	{
		___text_4 = value;
		Il2CppCodeGenWriteBarrier(&___text_4, value);
	}

	inline static int32_t get_offset_of_minutes_5() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___minutes_5)); }
	inline float get_minutes_5() const { return ___minutes_5; }
	inline float* get_address_of_minutes_5() { return &___minutes_5; }
	inline void set_minutes_5(float value)
	{
		___minutes_5 = value;
	}

	inline static int32_t get_offset_of_seconds_6() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___seconds_6)); }
	inline float get_seconds_6() const { return ___seconds_6; }
	inline float* get_address_of_seconds_6() { return &___seconds_6; }
	inline void set_seconds_6(float value)
	{
		___seconds_6 = value;
	}

	inline static int32_t get_offset_of_buttonSpawner_10() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607, ___buttonSpawner_10)); }
	inline ButtonSpawner_t2293950372 * get_buttonSpawner_10() const { return ___buttonSpawner_10; }
	inline ButtonSpawner_t2293950372 ** get_address_of_buttonSpawner_10() { return &___buttonSpawner_10; }
	inline void set_buttonSpawner_10(ButtonSpawner_t2293950372 * value)
	{
		___buttonSpawner_10 = value;
		Il2CppCodeGenWriteBarrier(&___buttonSpawner_10, value);
	}
};

struct TimeKeeper_t281777607_StaticFields
{
public:
	// System.Boolean TimeKeeper::finished
	bool ___finished_7;
	// System.Boolean TimeKeeper::paused
	bool ___paused_8;
	// System.Boolean TimeKeeper::gameStarted
	bool ___gameStarted_9;

public:
	inline static int32_t get_offset_of_finished_7() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607_StaticFields, ___finished_7)); }
	inline bool get_finished_7() const { return ___finished_7; }
	inline bool* get_address_of_finished_7() { return &___finished_7; }
	inline void set_finished_7(bool value)
	{
		___finished_7 = value;
	}

	inline static int32_t get_offset_of_paused_8() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607_StaticFields, ___paused_8)); }
	inline bool get_paused_8() const { return ___paused_8; }
	inline bool* get_address_of_paused_8() { return &___paused_8; }
	inline void set_paused_8(bool value)
	{
		___paused_8 = value;
	}

	inline static int32_t get_offset_of_gameStarted_9() { return static_cast<int32_t>(offsetof(TimeKeeper_t281777607_StaticFields, ___gameStarted_9)); }
	inline bool get_gameStarted_9() const { return ___gameStarted_9; }
	inline bool* get_address_of_gameStarted_9() { return &___gameStarted_9; }
	inline void set_gameStarted_9(bool value)
	{
		___gameStarted_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
