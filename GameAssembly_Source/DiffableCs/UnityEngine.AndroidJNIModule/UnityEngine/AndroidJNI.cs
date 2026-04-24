namespace UnityEngine;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class AndroidJNI
{

	[ThreadSafe]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void ExceptionClear() { }

	[ThreadSafe]
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[Obsolete]
	[ThreadSafe]
	public static Byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	public static Char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	public static Single[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	public static Int32[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	public static Int64[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	public static Int16[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[Obsolete]
	[ThreadSafe]
	public static IntPtr ToByteArray(Byte[] array) { }

	[ThreadSafe]
	public static IntPtr ToCharArray(Char[] array) { }

	[ThreadSafe]
	public static IntPtr ToDoubleArray(Double[] array) { }

	[ThreadSafe]
	public static IntPtr ToFloatArray(Single[] array) { }

	[ThreadSafe]
	public static IntPtr ToIntArray(Int32[] array) { }

	[ThreadSafe]
	public static IntPtr ToLongArray(Int64[] array) { }

	[ThreadSafe]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	public static IntPtr ToSByteArray(SByte[] array) { }

	[ThreadSafe]
	public static IntPtr ToShortArray(Int16[] array) { }

}

