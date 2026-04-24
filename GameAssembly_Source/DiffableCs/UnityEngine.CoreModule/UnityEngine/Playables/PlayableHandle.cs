namespace UnityEngine.Playables;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableHandle Null
	{
		 get { } //Length: 104
	}

	private static PlayableHandle() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableHandle other) { }

	public static PlayableHandle get_Null() { }

	public virtual int GetHashCode() { }

	internal Playable GetInput(int inputPort) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction]
	private PlayableHandle GetInputHandle(int index) { }

	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsNull() { }

	private static bool IsNull_Injected(ref PlayableHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal void SetTime(double value) { }

	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

}

