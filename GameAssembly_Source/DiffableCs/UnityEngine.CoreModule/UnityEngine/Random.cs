namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Random
{

	public static float value
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[FreeFunction]
	public static float get_value() { }

	[FreeFunction]
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunction]
	public static float Range(float min, float max) { }

	public static int Range(int min, int max) { }

}

