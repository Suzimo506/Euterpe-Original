namespace System;

public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE; //Field offset: 0x6AF30

	public static int MaxGeneration
	{
		 get { } //Length: 70
	}

	private static void _ReRegisterForFinalize(object o) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void _SuppressFinalize(object o) { }

	private static GC() { }

	public static void AddMemoryPressure(long bytesAllocated) { }

	public static void Collect() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int CollectionCount(int generation) { }

	private static object get_ephemeron_tombstone() { }

	public static int get_MaxGeneration() { }

	private static int GetCollectionCount(int generation) { }

	private static int GetMaxGeneration() { }

	private static void InternalCollect(int generation) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void KeepAlive(object obj) { }

	private static void RecordPressure(long bytesAllocated) { }

	internal static void register_ephemeron_array(Ephemeron[] array) { }

	public static void RemoveMemoryPressure(long bytesAllocated) { }

	public static void ReRegisterForFinalize(object obj) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void SuppressFinalize(object obj) { }

}

