namespace System.Diagnostics.Tracing;

internal class EtwSession
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<WeakReference`1<EtwSession>> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public EtwSession etwSession; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

	}

	private static List<WeakReference`1<EtwSession>> s_etwSessions; //Field offset: 0x0
	public readonly int m_etwSessionId; //Field offset: 0x10
	public ActivityFilter m_activityFilter; //Field offset: 0x18

	private static EtwSession() { }

	private EtwSession(int etwSessionId) { }

	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = false) { }

	public static void RemoveEtwSession(EtwSession etwSession) { }

	private static void TrimGlobalList() { }

}

