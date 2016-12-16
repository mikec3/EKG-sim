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
// UnityEngine.UI.Text
struct Text_t356221433;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t3986656710;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Strips
struct  Strips_t1326060597  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Animator Strips::animator
	Animator_t69676727 * ___animator_2;
	// UnityEngine.UI.Text Strips::heartRateText
	Text_t356221433 * ___heartRateText_3;
	// System.Int32 Strips::hR
	int32_t ___hR_4;

public:
	inline static int32_t get_offset_of_animator_2() { return static_cast<int32_t>(offsetof(Strips_t1326060597, ___animator_2)); }
	inline Animator_t69676727 * get_animator_2() const { return ___animator_2; }
	inline Animator_t69676727 ** get_address_of_animator_2() { return &___animator_2; }
	inline void set_animator_2(Animator_t69676727 * value)
	{
		___animator_2 = value;
		Il2CppCodeGenWriteBarrier(&___animator_2, value);
	}

	inline static int32_t get_offset_of_heartRateText_3() { return static_cast<int32_t>(offsetof(Strips_t1326060597, ___heartRateText_3)); }
	inline Text_t356221433 * get_heartRateText_3() const { return ___heartRateText_3; }
	inline Text_t356221433 ** get_address_of_heartRateText_3() { return &___heartRateText_3; }
	inline void set_heartRateText_3(Text_t356221433 * value)
	{
		___heartRateText_3 = value;
		Il2CppCodeGenWriteBarrier(&___heartRateText_3, value);
	}

	inline static int32_t get_offset_of_hR_4() { return static_cast<int32_t>(offsetof(Strips_t1326060597, ___hR_4)); }
	inline int32_t get_hR_4() const { return ___hR_4; }
	inline int32_t* get_address_of_hR_4() { return &___hR_4; }
	inline void set_hR_4(int32_t value)
	{
		___hR_4 = value;
	}
};

struct Strips_t1326060597_StaticFields
{
public:
	// System.Boolean Strips::mouseOver
	bool ___mouseOver_5;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> Strips::<>f__switch$map0
	Dictionary_2_t3986656710 * ___U3CU3Ef__switchU24map0_6;

public:
	inline static int32_t get_offset_of_mouseOver_5() { return static_cast<int32_t>(offsetof(Strips_t1326060597_StaticFields, ___mouseOver_5)); }
	inline bool get_mouseOver_5() const { return ___mouseOver_5; }
	inline bool* get_address_of_mouseOver_5() { return &___mouseOver_5; }
	inline void set_mouseOver_5(bool value)
	{
		___mouseOver_5 = value;
	}

	inline static int32_t get_offset_of_U3CU3Ef__switchU24map0_6() { return static_cast<int32_t>(offsetof(Strips_t1326060597_StaticFields, ___U3CU3Ef__switchU24map0_6)); }
	inline Dictionary_2_t3986656710 * get_U3CU3Ef__switchU24map0_6() const { return ___U3CU3Ef__switchU24map0_6; }
	inline Dictionary_2_t3986656710 ** get_address_of_U3CU3Ef__switchU24map0_6() { return &___U3CU3Ef__switchU24map0_6; }
	inline void set_U3CU3Ef__switchU24map0_6(Dictionary_2_t3986656710 * value)
	{
		___U3CU3Ef__switchU24map0_6 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__switchU24map0_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
