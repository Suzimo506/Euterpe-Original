namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class NoAllocHelpers
{

	public static void EnsureListElemCount(List<T> list, int count) { }

	[FreeFunction]
	public static Array ExtractArrayFromList(object list) { }

	public static T[] ExtractArrayFromListT(List<T> list) { }

	[FreeFunction]
	internal static void Internal_ResizeList(object list, int size) { }

	public static void ResizeList(List<T> list, int size) { }

	public static int SafeLength(Array values) { }

	public static int SafeLength(List<T> values) { }

}

