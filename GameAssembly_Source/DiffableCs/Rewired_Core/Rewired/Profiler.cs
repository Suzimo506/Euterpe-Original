namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class Profiler
{
	private const string VJsZSuySzZNGJokihCszlTIXvLxC = "ENABLE_PROFILER must be set in Rewired Core to use the profiler."; //Field offset: 0x0

	public static bool enableBinaryLog
	{
		 get { } //Length: 52
		 set { } //Length: 49
	}

	public static bool enabled
	{
		 get { } //Length: 52
		 set { } //Length: 49
	}

	public static string logFile
	{
		 get { } //Length: 94
		 set { } //Length: 49
	}

	public static bool supported
	{
		 get { } //Length: 52
	}

	public static uint usedHeapSize
	{
		 get { } //Length: 52
	}

	public static long usedHeapSizeLong
	{
		 get { } //Length: 52
	}

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void AddFramesFromFile(string file) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void BeginSample(string name) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void BeginSample(string name, object targetObject) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void EndSample() { }

	public static bool get_enableBinaryLog() { }

	public static bool get_enabled() { }

	public static string get_logFile() { }

	public static bool get_supported() { }

	public static uint get_usedHeapSize() { }

	public static long get_usedHeapSizeLong() { }

	public static uint GetMonoHeapSize() { }

	public static long GetMonoHeapSizeLong() { }

	public static uint GetMonoUsedSize() { }

	public static long GetMonoUsedSizeLong() { }

	public static int GetRuntimeMemorySize(object o) { }

	public static long GetRuntimeMemorySizeLong(object o) { }

	public static uint GetTotalAllocatedMemory() { }

	public static long GetTotalAllocatedMemoryLong() { }

	public static uint GetTotalReservedMemory() { }

	public static long GetTotalReservedMemoryLong() { }

	public static uint GetTotalUnusedReservedMemory() { }

	public static long GetTotalUnusedReservedMemoryLong() { }

	private static void PbsIKplpKlxZerSabvTHivwzypUb() { }

	public static void set_enableBinaryLog(bool value) { }

	public static void set_enabled(bool value) { }

	public static void set_logFile(string value) { }

}

