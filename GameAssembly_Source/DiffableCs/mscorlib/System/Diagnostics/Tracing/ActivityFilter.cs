namespace System.Diagnostics.Tracing;

internal sealed class ActivityFilter : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public ActivityFilter filterList; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int tickNow; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, Int32> x, KeyValuePair<Guid, Int32> y) { }

	}

	[CompilerGenerated]
	private sealed class <GetFilterAsTuple>d__7 : IEnumerable<Tuple`2<Int32, Int32>>, IEnumerable, IEnumerator<Tuple`2<Int32, Int32>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Tuple<Int32, Int32> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ActivityFilter <>4__this; //Field offset: 0x28
		private Guid sourceGuid; //Field offset: 0x30
		public Guid <>3__sourceGuid; //Field offset: 0x40
		private ActivityFilter <af>5__1; //Field offset: 0x50

		private override Tuple<Int32, Int32> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetFilterAsTuple>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Tuple`2<Int32, Int32>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

		[DebuggerHidden]
		private override Tuple<Int32, Int32> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private ConcurrentDictionary<Guid, Int32> m_activeActivities; //Field offset: 0x10
	private ConcurrentDictionary<Guid, Tuple`2<Guid, Int32>> m_rootActiveActivities; //Field offset: 0x18
	private Guid m_providerGuid; //Field offset: 0x20
	private int m_eventId; //Field offset: 0x30
	private int m_samplingFreq; //Field offset: 0x34
	private int m_curSampleCount; //Field offset: 0x38
	private int m_perEventSourceSessionId; //Field offset: 0x3C
	private ActivityFilter m_next; //Field offset: 0x40
	private Action<Guid> m_myActivityDelegate; //Field offset: 0x48

	private ActivityFilter(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter = null) { }

	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	public override void Dispose() { }

	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	private static ConcurrentDictionary<Guid, Int32> GetActiveActivities(ActivityFilter filterList) { }

	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IEnumerable<Tuple`2<Int32, Int32>> GetFilterAsTuple(Guid sourceGuid) { }

	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, Int32> activities) { }

	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

}

