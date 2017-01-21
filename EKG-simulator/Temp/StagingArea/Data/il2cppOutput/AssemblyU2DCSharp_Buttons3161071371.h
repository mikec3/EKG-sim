#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// ValidationSpawner
struct ValidationSpawner_t2037593317;
// StripGenerator
struct StripGenerator_t1556666045;
// ScoreKeeper
struct ScoreKeeper_t1955354816;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Buttons
struct  Buttons_t3161071371  : public MonoBehaviour_t1158329972
{
public:
	// ValidationSpawner Buttons::validationSpawner
	ValidationSpawner_t2037593317 * ___validationSpawner_2;
	// StripGenerator Buttons::stripGenerator
	StripGenerator_t1556666045 * ___stripGenerator_3;
	// ScoreKeeper Buttons::scoreKeeper
	ScoreKeeper_t1955354816 * ___scoreKeeper_4;

public:
	inline static int32_t get_offset_of_validationSpawner_2() { return static_cast<int32_t>(offsetof(Buttons_t3161071371, ___validationSpawner_2)); }
	inline ValidationSpawner_t2037593317 * get_validationSpawner_2() const { return ___validationSpawner_2; }
	inline ValidationSpawner_t2037593317 ** get_address_of_validationSpawner_2() { return &___validationSpawner_2; }
	inline void set_validationSpawner_2(ValidationSpawner_t2037593317 * value)
	{
		___validationSpawner_2 = value;
		Il2CppCodeGenWriteBarrier(&___validationSpawner_2, value);
	}

	inline static int32_t get_offset_of_stripGenerator_3() { return static_cast<int32_t>(offsetof(Buttons_t3161071371, ___stripGenerator_3)); }
	inline StripGenerator_t1556666045 * get_stripGenerator_3() const { return ___stripGenerator_3; }
	inline StripGenerator_t1556666045 ** get_address_of_stripGenerator_3() { return &___stripGenerator_3; }
	inline void set_stripGenerator_3(StripGenerator_t1556666045 * value)
	{
		___stripGenerator_3 = value;
		Il2CppCodeGenWriteBarrier(&___stripGenerator_3, value);
	}

	inline static int32_t get_offset_of_scoreKeeper_4() { return static_cast<int32_t>(offsetof(Buttons_t3161071371, ___scoreKeeper_4)); }
	inline ScoreKeeper_t1955354816 * get_scoreKeeper_4() const { return ___scoreKeeper_4; }
	inline ScoreKeeper_t1955354816 ** get_address_of_scoreKeeper_4() { return &___scoreKeeper_4; }
	inline void set_scoreKeeper_4(ScoreKeeper_t1955354816 * value)
	{
		___scoreKeeper_4 = value;
		Il2CppCodeGenWriteBarrier(&___scoreKeeper_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
