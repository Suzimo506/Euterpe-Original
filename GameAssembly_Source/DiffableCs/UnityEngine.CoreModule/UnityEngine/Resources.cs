namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Resources
{

	internal static T[] ConvertObjects(Object[] rawObjects) { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	public static T[] FindObjectsOfTypeAll() { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource(string path) { }

	public static object Load(string path) { }

	public static T Load(string path) { }

	[FreeFunction]
	[NativeThrows]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Load(string path, Type systemTypeInstance) { }

	[FreeFunction]
	[NativeThrows]
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll(string path) { }

	public static ResourceRequest LoadAsync(string path, Type type) { }

	[FreeFunction]
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[FreeFunction]
	public static void UnloadAsset(object assetToUnload) { }

	[FreeFunction]
	public static AsyncOperation UnloadUnusedAssets() { }

}

