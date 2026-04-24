namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class JsonUtility
{

	public static T FromJson(string json) { }

	public static object FromJson(string json, Type type) { }

	[FreeFunction]
	[ThreadSafe]
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	public static string ToJson(object obj) { }

	public static string ToJson(object obj, bool prettyPrint) { }

	[FreeFunction]
	[ThreadSafe]
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

}

