#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// UnityEngine.Store.AppInfo
struct AppInfo_t2433711276;
// System.String
struct String_t;
// UnityEngine.Store.MainThreadDispatcher
struct MainThreadDispatcher_t3211665238;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t3962482529;
// System.Action
struct Action_t1264377477;
// System.Collections.Generic.List`1<System.Action>
struct List_1_t2736452219;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t257213610;
// UnityEngine.Component
struct Component_t1923634451;
// UnityEngine.GameObject
struct GameObject_t1113636619;
// UnityEngine.Object
struct Object_t631007953;
// System.Action[]
struct ActionU5BU5D_t388269512;
// System.Object[]
struct ObjectU5BU5D_t2843939325;
// System.Char[]
struct CharU5BU5D_t3528271667;
// System.Void
struct Void_t1185182177;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.DelegateData
struct DelegateData_t1677132599;
// System.IAsyncResult
struct IAsyncResult_t767004451;
// System.AsyncCallback
struct AsyncCallback_t3962456242;

extern RuntimeClass* MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1_Add_m437696916_RuntimeMethod_var;
extern const uint32_t MainThreadDispatcher_RunOnMainThread_m850509864_MetadataUsageId;
extern RuntimeClass* Object_t631007953_il2cpp_TypeInfo_var;
extern const uint32_t MainThreadDispatcher_Start_m2263864666_MetadataUsageId;
extern RuntimeClass* ActionU5BU5D_t388269512_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1_get_Count_m808340314_RuntimeMethod_var;
extern const RuntimeMethod* List_1_CopyTo_m2569245864_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Clear_m2936844859_RuntimeMethod_var;
extern const uint32_t MainThreadDispatcher_Update_m670448704_MetadataUsageId;
extern RuntimeClass* List_1_t2736452219_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1__ctor_m2543424368_RuntimeMethod_var;
extern String_t* _stringLiteral2183561488;
extern const uint32_t MainThreadDispatcher__cctor_m320126332_MetadataUsageId;

struct ActionU5BU5D_t388269512;


#ifndef U3CMODULEU3E_T692745544_H
#define U3CMODULEU3E_T692745544_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct  U3CModuleU3E_t692745544 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CMODULEU3E_T692745544_H
#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
struct Il2CppArrayBounds;
#ifndef RUNTIMEARRAY_H
#define RUNTIMEARRAY_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Array

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEARRAY_H
#ifndef LIST_1_T2736452219_H
#define LIST_1_T2736452219_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<System.Action>
struct  List_1_t2736452219  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ActionU5BU5D_t388269512* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t2736452219, ____items_1)); }
	inline ActionU5BU5D_t388269512* get__items_1() const { return ____items_1; }
	inline ActionU5BU5D_t388269512** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ActionU5BU5D_t388269512* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t2736452219, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t2736452219, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}
};

struct List_1_t2736452219_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::EmptyArray
	ActionU5BU5D_t388269512* ___EmptyArray_4;

public:
	inline static int32_t get_offset_of_EmptyArray_4() { return static_cast<int32_t>(offsetof(List_1_t2736452219_StaticFields, ___EmptyArray_4)); }
	inline ActionU5BU5D_t388269512* get_EmptyArray_4() const { return ___EmptyArray_4; }
	inline ActionU5BU5D_t388269512** get_address_of_EmptyArray_4() { return &___EmptyArray_4; }
	inline void set_EmptyArray_4(ActionU5BU5D_t388269512* value)
	{
		___EmptyArray_4 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyArray_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T2736452219_H
#ifndef VALUETYPE_T3640485471_H
#define VALUETYPE_T3640485471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3640485471  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_com
{
};
#endif // VALUETYPE_T3640485471_H
#ifndef STRING_T_H
#define STRING_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::length
	int32_t ___length_0;
	// System.Char System.String::start_char
	Il2CppChar ___start_char_1;

public:
	inline static int32_t get_offset_of_length_0() { return static_cast<int32_t>(offsetof(String_t, ___length_0)); }
	inline int32_t get_length_0() const { return ___length_0; }
	inline int32_t* get_address_of_length_0() { return &___length_0; }
	inline void set_length_0(int32_t value)
	{
		___length_0 = value;
	}

	inline static int32_t get_offset_of_start_char_1() { return static_cast<int32_t>(offsetof(String_t, ___start_char_1)); }
	inline Il2CppChar get_start_char_1() const { return ___start_char_1; }
	inline Il2CppChar* get_address_of_start_char_1() { return &___start_char_1; }
	inline void set_start_char_1(Il2CppChar value)
	{
		___start_char_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_2;
	// System.Char[] System.String::WhiteChars
	CharU5BU5D_t3528271667* ___WhiteChars_3;

public:
	inline static int32_t get_offset_of_Empty_2() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_2)); }
	inline String_t* get_Empty_2() const { return ___Empty_2; }
	inline String_t** get_address_of_Empty_2() { return &___Empty_2; }
	inline void set_Empty_2(String_t* value)
	{
		___Empty_2 = value;
		Il2CppCodeGenWriteBarrier((&___Empty_2), value);
	}

	inline static int32_t get_offset_of_WhiteChars_3() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___WhiteChars_3)); }
	inline CharU5BU5D_t3528271667* get_WhiteChars_3() const { return ___WhiteChars_3; }
	inline CharU5BU5D_t3528271667** get_address_of_WhiteChars_3() { return &___WhiteChars_3; }
	inline void set_WhiteChars_3(CharU5BU5D_t3528271667* value)
	{
		___WhiteChars_3 = value;
		Il2CppCodeGenWriteBarrier((&___WhiteChars_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRING_T_H
#ifndef APPINFO_T2433711276_H
#define APPINFO_T2433711276_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Store.AppInfo
struct  AppInfo_t2433711276  : public RuntimeObject
{
public:
	// System.String UnityEngine.Store.AppInfo::<appId>k__BackingField
	String_t* ___U3CappIdU3Ek__BackingField_0;
	// System.String UnityEngine.Store.AppInfo::<appKey>k__BackingField
	String_t* ___U3CappKeyU3Ek__BackingField_1;
	// System.String UnityEngine.Store.AppInfo::<clientId>k__BackingField
	String_t* ___U3CclientIdU3Ek__BackingField_2;
	// System.String UnityEngine.Store.AppInfo::<clientKey>k__BackingField
	String_t* ___U3CclientKeyU3Ek__BackingField_3;
	// System.Boolean UnityEngine.Store.AppInfo::<debug>k__BackingField
	bool ___U3CdebugU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CappIdU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(AppInfo_t2433711276, ___U3CappIdU3Ek__BackingField_0)); }
	inline String_t* get_U3CappIdU3Ek__BackingField_0() const { return ___U3CappIdU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CappIdU3Ek__BackingField_0() { return &___U3CappIdU3Ek__BackingField_0; }
	inline void set_U3CappIdU3Ek__BackingField_0(String_t* value)
	{
		___U3CappIdU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((&___U3CappIdU3Ek__BackingField_0), value);
	}

	inline static int32_t get_offset_of_U3CappKeyU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(AppInfo_t2433711276, ___U3CappKeyU3Ek__BackingField_1)); }
	inline String_t* get_U3CappKeyU3Ek__BackingField_1() const { return ___U3CappKeyU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3CappKeyU3Ek__BackingField_1() { return &___U3CappKeyU3Ek__BackingField_1; }
	inline void set_U3CappKeyU3Ek__BackingField_1(String_t* value)
	{
		___U3CappKeyU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CappKeyU3Ek__BackingField_1), value);
	}

	inline static int32_t get_offset_of_U3CclientIdU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(AppInfo_t2433711276, ___U3CclientIdU3Ek__BackingField_2)); }
	inline String_t* get_U3CclientIdU3Ek__BackingField_2() const { return ___U3CclientIdU3Ek__BackingField_2; }
	inline String_t** get_address_of_U3CclientIdU3Ek__BackingField_2() { return &___U3CclientIdU3Ek__BackingField_2; }
	inline void set_U3CclientIdU3Ek__BackingField_2(String_t* value)
	{
		___U3CclientIdU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((&___U3CclientIdU3Ek__BackingField_2), value);
	}

	inline static int32_t get_offset_of_U3CclientKeyU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(AppInfo_t2433711276, ___U3CclientKeyU3Ek__BackingField_3)); }
	inline String_t* get_U3CclientKeyU3Ek__BackingField_3() const { return ___U3CclientKeyU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CclientKeyU3Ek__BackingField_3() { return &___U3CclientKeyU3Ek__BackingField_3; }
	inline void set_U3CclientKeyU3Ek__BackingField_3(String_t* value)
	{
		___U3CclientKeyU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((&___U3CclientKeyU3Ek__BackingField_3), value);
	}

	inline static int32_t get_offset_of_U3CdebugU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(AppInfo_t2433711276, ___U3CdebugU3Ek__BackingField_4)); }
	inline bool get_U3CdebugU3Ek__BackingField_4() const { return ___U3CdebugU3Ek__BackingField_4; }
	inline bool* get_address_of_U3CdebugU3Ek__BackingField_4() { return &___U3CdebugU3Ek__BackingField_4; }
	inline void set_U3CdebugU3Ek__BackingField_4(bool value)
	{
		___U3CdebugU3Ek__BackingField_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // APPINFO_T2433711276_H
#ifndef BOOLEAN_T97287965_H
#define BOOLEAN_T97287965_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Boolean
struct  Boolean_t97287965 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Boolean_t97287965, ___m_value_2)); }
	inline bool get_m_value_2() const { return ___m_value_2; }
	inline bool* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(bool value)
	{
		___m_value_2 = value;
	}
};

struct Boolean_t97287965_StaticFields
{
public:
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_0;
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_1;

public:
	inline static int32_t get_offset_of_FalseString_0() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___FalseString_0)); }
	inline String_t* get_FalseString_0() const { return ___FalseString_0; }
	inline String_t** get_address_of_FalseString_0() { return &___FalseString_0; }
	inline void set_FalseString_0(String_t* value)
	{
		___FalseString_0 = value;
		Il2CppCodeGenWriteBarrier((&___FalseString_0), value);
	}

	inline static int32_t get_offset_of_TrueString_1() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___TrueString_1)); }
	inline String_t* get_TrueString_1() const { return ___TrueString_1; }
	inline String_t** get_address_of_TrueString_1() { return &___TrueString_1; }
	inline void set_TrueString_1(String_t* value)
	{
		___TrueString_1 = value;
		Il2CppCodeGenWriteBarrier((&___TrueString_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOOLEAN_T97287965_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef VOID_T1185182177_H
#define VOID_T1185182177_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Void
struct  Void_t1185182177 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VOID_T1185182177_H
#ifndef INT32_T2950945753_H
#define INT32_T2950945753_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int32
struct  Int32_t2950945753 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Int32_t2950945753, ___m_value_2)); }
	inline int32_t get_m_value_2() const { return ___m_value_2; }
	inline int32_t* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(int32_t value)
	{
		___m_value_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT32_T2950945753_H
#ifndef OBJECT_T631007953_H
#define OBJECT_T631007953_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t631007953  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t631007953, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t631007953_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t631007953_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T631007953_H
#ifndef DELEGATE_T1188392813_H
#define DELEGATE_T1188392813_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Delegate
struct  Delegate_t1188392813  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_5;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_6;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_7;
	// System.DelegateData System.Delegate::data
	DelegateData_t1677132599 * ___data_8;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_target_2), value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_method_code_5() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_code_5)); }
	inline intptr_t get_method_code_5() const { return ___method_code_5; }
	inline intptr_t* get_address_of_method_code_5() { return &___method_code_5; }
	inline void set_method_code_5(intptr_t value)
	{
		___method_code_5 = value;
	}

	inline static int32_t get_offset_of_method_info_6() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_info_6)); }
	inline MethodInfo_t * get_method_info_6() const { return ___method_info_6; }
	inline MethodInfo_t ** get_address_of_method_info_6() { return &___method_info_6; }
	inline void set_method_info_6(MethodInfo_t * value)
	{
		___method_info_6 = value;
		Il2CppCodeGenWriteBarrier((&___method_info_6), value);
	}

	inline static int32_t get_offset_of_original_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___original_method_info_7)); }
	inline MethodInfo_t * get_original_method_info_7() const { return ___original_method_info_7; }
	inline MethodInfo_t ** get_address_of_original_method_info_7() { return &___original_method_info_7; }
	inline void set_original_method_info_7(MethodInfo_t * value)
	{
		___original_method_info_7 = value;
		Il2CppCodeGenWriteBarrier((&___original_method_info_7), value);
	}

	inline static int32_t get_offset_of_data_8() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___data_8)); }
	inline DelegateData_t1677132599 * get_data_8() const { return ___data_8; }
	inline DelegateData_t1677132599 ** get_address_of_data_8() { return &___data_8; }
	inline void set_data_8(DelegateData_t1677132599 * value)
	{
		___data_8 = value;
		Il2CppCodeGenWriteBarrier((&___data_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DELEGATE_T1188392813_H
#ifndef GAMEOBJECT_T1113636619_H
#define GAMEOBJECT_T1113636619_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.GameObject
struct  GameObject_t1113636619  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMEOBJECT_T1113636619_H
#ifndef COMPONENT_T1923634451_H
#define COMPONENT_T1923634451_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t1923634451  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T1923634451_H
#ifndef MULTICASTDELEGATE_T_H
#define MULTICASTDELEGATE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t1188392813
{
public:
	// System.MulticastDelegate System.MulticastDelegate::prev
	MulticastDelegate_t * ___prev_9;
	// System.MulticastDelegate System.MulticastDelegate::kpm_next
	MulticastDelegate_t * ___kpm_next_10;

public:
	inline static int32_t get_offset_of_prev_9() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___prev_9)); }
	inline MulticastDelegate_t * get_prev_9() const { return ___prev_9; }
	inline MulticastDelegate_t ** get_address_of_prev_9() { return &___prev_9; }
	inline void set_prev_9(MulticastDelegate_t * value)
	{
		___prev_9 = value;
		Il2CppCodeGenWriteBarrier((&___prev_9), value);
	}

	inline static int32_t get_offset_of_kpm_next_10() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___kpm_next_10)); }
	inline MulticastDelegate_t * get_kpm_next_10() const { return ___kpm_next_10; }
	inline MulticastDelegate_t ** get_address_of_kpm_next_10() { return &___kpm_next_10; }
	inline void set_kpm_next_10(MulticastDelegate_t * value)
	{
		___kpm_next_10 = value;
		Il2CppCodeGenWriteBarrier((&___kpm_next_10), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULTICASTDELEGATE_T_H
#ifndef BEHAVIOUR_T1437897464_H
#define BEHAVIOUR_T1437897464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t1437897464  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T1437897464_H
#ifndef ACTION_T1264377477_H
#define ACTION_T1264377477_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Action
struct  Action_t1264377477  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ACTION_T1264377477_H
#ifndef MONOBEHAVIOUR_T3962482529_H
#define MONOBEHAVIOUR_T3962482529_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t3962482529  : public Behaviour_t1437897464
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T3962482529_H
#ifndef MAINTHREADDISPATCHER_T3211665238_H
#define MAINTHREADDISPATCHER_T3211665238_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Store.MainThreadDispatcher
struct  MainThreadDispatcher_t3211665238  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct MainThreadDispatcher_t3211665238_StaticFields
{
public:
	// System.String UnityEngine.Store.MainThreadDispatcher::OBJECT_NAME
	String_t* ___OBJECT_NAME_2;
	// System.Collections.Generic.List`1<System.Action> UnityEngine.Store.MainThreadDispatcher::s_Callbacks
	List_1_t2736452219 * ___s_Callbacks_3;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) UnityEngine.Store.MainThreadDispatcher::s_CallbacksPending
	bool ___s_CallbacksPending_4;

public:
	inline static int32_t get_offset_of_OBJECT_NAME_2() { return static_cast<int32_t>(offsetof(MainThreadDispatcher_t3211665238_StaticFields, ___OBJECT_NAME_2)); }
	inline String_t* get_OBJECT_NAME_2() const { return ___OBJECT_NAME_2; }
	inline String_t** get_address_of_OBJECT_NAME_2() { return &___OBJECT_NAME_2; }
	inline void set_OBJECT_NAME_2(String_t* value)
	{
		___OBJECT_NAME_2 = value;
		Il2CppCodeGenWriteBarrier((&___OBJECT_NAME_2), value);
	}

	inline static int32_t get_offset_of_s_Callbacks_3() { return static_cast<int32_t>(offsetof(MainThreadDispatcher_t3211665238_StaticFields, ___s_Callbacks_3)); }
	inline List_1_t2736452219 * get_s_Callbacks_3() const { return ___s_Callbacks_3; }
	inline List_1_t2736452219 ** get_address_of_s_Callbacks_3() { return &___s_Callbacks_3; }
	inline void set_s_Callbacks_3(List_1_t2736452219 * value)
	{
		___s_Callbacks_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Callbacks_3), value);
	}

	inline static int32_t get_offset_of_s_CallbacksPending_4() { return static_cast<int32_t>(offsetof(MainThreadDispatcher_t3211665238_StaticFields, ___s_CallbacksPending_4)); }
	inline bool get_s_CallbacksPending_4() const { return ___s_CallbacksPending_4; }
	inline bool* get_address_of_s_CallbacksPending_4() { return &___s_CallbacksPending_4; }
	inline void set_s_CallbacksPending_4(bool value)
	{
		___s_CallbacksPending_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MAINTHREADDISPATCHER_T3211665238_H
// System.Action[]
struct ActionU5BU5D_t388269512  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Action_t1264377477 * m_Items[1];

public:
	inline Action_t1264377477 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Action_t1264377477 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Action_t1264377477 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Action_t1264377477 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Action_t1264377477 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Action_t1264377477 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};


// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
extern "C"  void List_1_Add_m3338814081_gshared (List_1_t257213610 * __this, RuntimeObject * p0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
extern "C"  int32_t List_1_get_Count_m2934127733_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::CopyTo(!0[])
extern "C"  void List_1_CopyTo_m133310179_gshared (List_1_t257213610 * __this, ObjectU5BU5D_t2843939325* p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Clear()
extern "C"  void List_1_Clear_m3697625829_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
extern "C"  void List_1__ctor_m2321703786_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
extern "C"  void Object__ctor_m297566312 (RuntimeObject * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C"  void MonoBehaviour__ctor_m1579109191 (MonoBehaviour_t3962482529 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Threading.Monitor::Enter(System.Object)
extern "C"  void Monitor_Enter_m2249409497 (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<System.Action>::Add(!0)
#define List_1_Add_m437696916(__this, p0, method) ((  void (*) (List_1_t2736452219 *, Action_t1264377477 *, const RuntimeMethod*))List_1_Add_m3338814081_gshared)(__this, p0, method)
// System.Void System.Threading.Monitor::Exit(System.Object)
extern "C"  void Monitor_Exit_m3585316909 (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
extern "C"  GameObject_t1113636619 * Component_get_gameObject_m442555142 (Component_t1923634451 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Object::DontDestroyOnLoad(UnityEngine.Object)
extern "C"  void Object_DontDestroyOnLoad_m166252750 (RuntimeObject * __this /* static, unused */, Object_t631007953 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Collections.Generic.List`1<System.Action>::get_Count()
#define List_1_get_Count_m808340314(__this, method) ((  int32_t (*) (List_1_t2736452219 *, const RuntimeMethod*))List_1_get_Count_m2934127733_gshared)(__this, method)
// System.Void System.Collections.Generic.List`1<System.Action>::CopyTo(!0[])
#define List_1_CopyTo_m2569245864(__this, p0, method) ((  void (*) (List_1_t2736452219 *, ActionU5BU5D_t388269512*, const RuntimeMethod*))List_1_CopyTo_m133310179_gshared)(__this, p0, method)
// System.Void System.Collections.Generic.List`1<System.Action>::Clear()
#define List_1_Clear_m2936844859(__this, method) ((  void (*) (List_1_t2736452219 *, const RuntimeMethod*))List_1_Clear_m3697625829_gshared)(__this, method)
// System.Void System.Action::Invoke()
extern "C"  void Action_Invoke_m937035532 (Action_t1264377477 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<System.Action>::.ctor()
#define List_1__ctor_m2543424368(__this, method) ((  void (*) (List_1_t2736452219 *, const RuntimeMethod*))List_1__ctor_m2321703786_gshared)(__this, method)
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Store.AppInfo::.ctor()
extern "C"  void AppInfo__ctor_m2735043516 (AppInfo_t2433711276 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m297566312(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Store.AppInfo::set_appId(System.String)
extern "C"  void AppInfo_set_appId_m2055658561 (AppInfo_t2433711276 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___value0;
		__this->set_U3CappIdU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Store.AppInfo::set_appKey(System.String)
extern "C"  void AppInfo_set_appKey_m3602781371 (AppInfo_t2433711276 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___value0;
		__this->set_U3CappKeyU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Void UnityEngine.Store.AppInfo::set_clientId(System.String)
extern "C"  void AppInfo_set_clientId_m1938777246 (AppInfo_t2433711276 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___value0;
		__this->set_U3CclientIdU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Void UnityEngine.Store.AppInfo::set_clientKey(System.String)
extern "C"  void AppInfo_set_clientKey_m2324748463 (AppInfo_t2433711276 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___value0;
		__this->set_U3CclientKeyU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Void UnityEngine.Store.AppInfo::set_debug(System.Boolean)
extern "C"  void AppInfo_set_debug_m3225992108 (AppInfo_t2433711276 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_U3CdebugU3Ek__BackingField_4(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Store.MainThreadDispatcher::.ctor()
extern "C"  void MainThreadDispatcher__ctor_m2242845350 (MainThreadDispatcher_t3211665238 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Store.MainThreadDispatcher::RunOnMainThread(System.Action)
extern "C"  void MainThreadDispatcher_RunOnMainThread_m850509864 (RuntimeObject * __this /* static, unused */, Action_t1264377477 * ___runnable0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainThreadDispatcher_RunOnMainThread_m850509864_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = 0;
	NO_UNUSED_WARNING (__leave_target);
	{
		IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
		List_1_t2736452219 * L_0 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
		V_0 = L_0;
		RuntimeObject * L_1 = V_0;
		Monitor_Enter_m2249409497(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
	}

IL_000d:
	try
	{ // begin try (depth: 1)
		IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
		List_1_t2736452219 * L_2 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
		Action_t1264377477 * L_3 = ___runnable0;
		NullCheck(L_2);
		List_1_Add_m437696916(L_2, L_3, /*hidden argument*/List_1_Add_m437696916_RuntimeMethod_var);
		il2cpp_codegen_memory_barrier();
		((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->set_s_CallbacksPending_4(1);
		IL2CPP_LEAVE(0x2E, FINALLY_0027);
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0027;
	}

FINALLY_0027:
	{ // begin finally (depth: 1)
		RuntimeObject * L_4 = V_0;
		Monitor_Exit_m3585316909(NULL /*static, unused*/, L_4, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(39)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(39)
	{
		IL2CPP_JUMP_TBL(0x2E, IL_002e)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_002e:
	{
		return;
	}
}
// System.Void UnityEngine.Store.MainThreadDispatcher::Start()
extern "C"  void MainThreadDispatcher_Start_m2263864666 (MainThreadDispatcher_t3211665238 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainThreadDispatcher_Start_m2263864666_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		GameObject_t1113636619 * L_0 = Component_get_gameObject_m442555142(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		Object_DontDestroyOnLoad_m166252750(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Store.MainThreadDispatcher::Update()
extern "C"  void MainThreadDispatcher_Update_m670448704 (MainThreadDispatcher_t3211665238 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainThreadDispatcher_Update_m670448704_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ActionU5BU5D_t388269512* V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	Action_t1264377477 * V_2 = NULL;
	ActionU5BU5D_t388269512* V_3 = NULL;
	int32_t V_4 = 0;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = 0;
	NO_UNUSED_WARNING (__leave_target);
	{
		IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
		bool L_0 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_CallbacksPending_4();
		il2cpp_codegen_memory_barrier();
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		goto IL_0095;
	}

IL_0012:
	{
		IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
		List_1_t2736452219 * L_1 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
		V_1 = L_1;
		RuntimeObject * L_2 = V_1;
		Monitor_Enter_m2249409497(NULL /*static, unused*/, L_2, /*hidden argument*/NULL);
	}

IL_001e:
	try
	{ // begin try (depth: 1)
		{
			IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
			List_1_t2736452219 * L_3 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
			NullCheck(L_3);
			int32_t L_4 = List_1_get_Count_m808340314(L_3, /*hidden argument*/List_1_get_Count_m808340314_RuntimeMethod_var);
			if (L_4)
			{
				goto IL_0033;
			}
		}

IL_002e:
		{
			IL2CPP_LEAVE(0x95, FINALLY_0066);
		}

IL_0033:
		{
			IL2CPP_RUNTIME_CLASS_INIT(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var);
			List_1_t2736452219 * L_5 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
			NullCheck(L_5);
			int32_t L_6 = List_1_get_Count_m808340314(L_5, /*hidden argument*/List_1_get_Count_m808340314_RuntimeMethod_var);
			V_0 = ((ActionU5BU5D_t388269512*)SZArrayNew(ActionU5BU5D_t388269512_il2cpp_TypeInfo_var, (uint32_t)L_6));
			List_1_t2736452219 * L_7 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
			ActionU5BU5D_t388269512* L_8 = V_0;
			NullCheck(L_7);
			List_1_CopyTo_m2569245864(L_7, L_8, /*hidden argument*/List_1_CopyTo_m2569245864_RuntimeMethod_var);
			List_1_t2736452219 * L_9 = ((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->get_s_Callbacks_3();
			NullCheck(L_9);
			List_1_Clear_m2936844859(L_9, /*hidden argument*/List_1_Clear_m2936844859_RuntimeMethod_var);
			il2cpp_codegen_memory_barrier();
			((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->set_s_CallbacksPending_4(0);
			IL2CPP_LEAVE(0x6D, FINALLY_0066);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0066;
	}

FINALLY_0066:
	{ // begin finally (depth: 1)
		RuntimeObject * L_10 = V_1;
		Monitor_Exit_m3585316909(NULL /*static, unused*/, L_10, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(102)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(102)
	{
		IL2CPP_JUMP_TBL(0x95, IL_0095)
		IL2CPP_JUMP_TBL(0x6D, IL_006d)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_006d:
	{
		ActionU5BU5D_t388269512* L_11 = V_0;
		V_3 = L_11;
		V_4 = 0;
		goto IL_008b;
	}

IL_0078:
	{
		ActionU5BU5D_t388269512* L_12 = V_3;
		int32_t L_13 = V_4;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		Action_t1264377477 * L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_2 = L_15;
		Action_t1264377477 * L_16 = V_2;
		NullCheck(L_16);
		Action_Invoke_m937035532(L_16, /*hidden argument*/NULL);
		int32_t L_17 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_17, (int32_t)1));
	}

IL_008b:
	{
		int32_t L_18 = V_4;
		ActionU5BU5D_t388269512* L_19 = V_3;
		NullCheck(L_19);
		if ((((int32_t)L_18) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_19)->max_length)))))))
		{
			goto IL_0078;
		}
	}

IL_0095:
	{
		return;
	}
}
// System.Void UnityEngine.Store.MainThreadDispatcher::.cctor()
extern "C"  void MainThreadDispatcher__cctor_m320126332 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainThreadDispatcher__cctor_m320126332_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->set_OBJECT_NAME_2(_stringLiteral2183561488);
		List_1_t2736452219 * L_0 = (List_1_t2736452219 *)il2cpp_codegen_object_new(List_1_t2736452219_il2cpp_TypeInfo_var);
		List_1__ctor_m2543424368(L_0, /*hidden argument*/List_1__ctor_m2543424368_RuntimeMethod_var);
		((MainThreadDispatcher_t3211665238_StaticFields*)il2cpp_codegen_static_fields_for(MainThreadDispatcher_t3211665238_il2cpp_TypeInfo_var))->set_s_Callbacks_3(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
