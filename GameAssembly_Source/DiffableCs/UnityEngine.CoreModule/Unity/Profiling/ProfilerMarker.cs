namespace Unity.Profiling;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct ProfilerMarker
{
	[UsedByNativeCode]
	internal struct AutoScope : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr m_Ptr; //Field offset: 0x0

		internal AutoScope(IntPtr markerPtr) { }

		public override void Dispose() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; //Field offset: 0x0

	public ProfilerMarker(string name) { }

	public AutoScope Auto() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ThreadSafe]
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ThreadSafe]
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ThreadSafe]
	internal static void Internal_End(IntPtr markerPtr) { }

}

