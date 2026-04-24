namespace MEC;

public class Timing : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <_CallContinuously>d__335 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18
		public float period; //Field offset: 0x20
		public GameObject gObject; //Field offset: 0x28
		public Action action; //Field offset: 0x30

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_CallContinuously>d__335(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_CallContinuously>d__353 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private float <>2__current; //Field offset: 0x0
		public Timing <>4__this; //Field offset: 0x0
		public float period; //Field offset: 0x0
		public GameObject gObject; //Field offset: 0x0
		public Action<T> action; //Field offset: 0x0
		public T reference; //Field offset: 0x0

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_CallContinuously>d__353`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_DelayedCall>d__313 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public GameObject cancelWith; //Field offset: 0x28
		public Action action; //Field offset: 0x30

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_DelayedCall>d__313(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_EOFPump>d__133 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Timing <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <_EOFPump>d__133(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_EOFPumpWatcher>d__132(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_InjectDelay>d__288 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18
		public float waitTime; //Field offset: 0x20
		public IEnumerator<Single> proc; //Field offset: 0x28

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_InjectDelay>d__288(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__275 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18
		public CoroutineHandle handle; //Field offset: 0x20
		public IEnumerator<Single> proc; //Field offset: 0x28

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_StartWhenDone>d__275(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__280 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public AsyncOperation operation; //Field offset: 0x18
		public IEnumerator<Single> pausedProc; //Field offset: 0x20

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_StartWhenDone>d__280(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__282 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public CustomYieldInstruction operation; //Field offset: 0x18
		public IEnumerator<Single> pausedProc; //Field offset: 0x20

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_StartWhenDone>d__282(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__287 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Func<Boolean> evaluatorFunc; //Field offset: 0x18
		public bool continueOn; //Field offset: 0x20
		public IEnumerator<Single> pausedProc; //Field offset: 0x28

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_StartWhenDone>d__287(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_WatchCall>d__334 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Timing <>4__this; //Field offset: 0x18
		public float timeframe; //Field offset: 0x20
		public CoroutineHandle handle; //Field offset: 0x24
		public Action onDone; //Field offset: 0x28
		public GameObject gObject; //Field offset: 0x30

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_WatchCall>d__334(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <_WatchCall>d__352 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private float <>2__current; //Field offset: 0x0
		public Timing <>4__this; //Field offset: 0x0
		public float timeframe; //Field offset: 0x0
		public CoroutineHandle handle; //Field offset: 0x0
		public Action<T> onDone; //Field offset: 0x0
		public GameObject gObject; //Field offset: 0x0
		public T reference; //Field offset: 0x0

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <_WatchCall>d__352`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct ProcessIndex : IEquatable<ProcessIndex>
	{
		public Segment seg; //Field offset: 0x0
		public int i; //Field offset: 0x4

		public override bool Equals(ProcessIndex other) { }

		public virtual bool Equals(object other) { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(ProcessIndex a, ProcessIndex b) { }

		public static bool op_Inequality(ProcessIndex a, ProcessIndex b) { }

	}

	public const float WaitForOneFrame = -∞; //Field offset: 0x0
	private const int InitialBufferSizeSmall = 8; //Field offset: 0x0
	private const int InitialBufferSizeMedium = 64; //Field offset: 0x0
	private const int InitialBufferSizeLarge = 256; //Field offset: 0x0
	private const int ProcessArrayChunkSize = 64; //Field offset: 0x0
	private const ushort FramesUntilMaintenance = 64; //Field offset: 0x0
	public static Func<IEnumerator`1<Single>, CoroutineHandle, IEnumerator`1<Single>> ReplacementFunction; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnPreExecute; //Field offset: 0x8
	[CompilerGenerated]
	private static Thread <MainThread>k__BackingField; //Field offset: 0x10
	private static object _tmpRef; //Field offset: 0x18
	private static int _tmpInt; //Field offset: 0x20
	private static bool _tmpBool; //Field offset: 0x24
	private static Segment _tmpSegment; //Field offset: 0x28
	private static CoroutineHandle _tmpHandle; //Field offset: 0x2C
	private static readonly Dictionary<CoroutineHandle, HashSet`1<CoroutineHandle>> Links; //Field offset: 0x30
	private static readonly WaitForEndOfFrame EofWaitObject; //Field offset: 0x38
	private static Timing[] ActiveInstances; //Field offset: 0x40
	private static Timing _instance; //Field offset: 0x48
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float TimeBetweenSlowUpdateCalls; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public DebugInfoType ProfilerDebugAmount; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool AutoTriggerManualTimeframe; //Field offset: 0x20
	[Space]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int UpdateCoroutines; //Field offset: 0x24
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int FixedUpdateCoroutines; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int LateUpdateCoroutines; //Field offset: 0x2C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int SlowUpdateCoroutines; //Field offset: 0x30
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int RealtimeUpdateCoroutines; //Field offset: 0x34
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int EditorUpdateCoroutines; //Field offset: 0x38
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int EditorSlowUpdateCoroutines; //Field offset: 0x3C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int EndOfFrameCoroutines; //Field offset: 0x40
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int ManualTimeframeCoroutines; //Field offset: 0x44
	public float localTime; //Field offset: 0x48
	public float deltaTime; //Field offset: 0x4C
	public Func<Single, Single> SetManualTimeframeTime; //Field offset: 0x50
	[CompilerGenerated]
	private CoroutineHandle <currentCoroutine>k__BackingField; //Field offset: 0x58
	private int _currentUpdateFrame; //Field offset: 0x5C
	private int _currentLateUpdateFrame; //Field offset: 0x60
	private int _currentSlowUpdateFrame; //Field offset: 0x64
	private int _currentRealtimeUpdateFrame; //Field offset: 0x68
	private int _currentEndOfFrameFrame; //Field offset: 0x6C
	private int _nextUpdateProcessSlot; //Field offset: 0x70
	private int _nextLateUpdateProcessSlot; //Field offset: 0x74
	private int _nextFixedUpdateProcessSlot; //Field offset: 0x78
	private int _nextSlowUpdateProcessSlot; //Field offset: 0x7C
	private int _nextRealtimeUpdateProcessSlot; //Field offset: 0x80
	private int _nextEditorUpdateProcessSlot; //Field offset: 0x84
	private int _nextEditorSlowUpdateProcessSlot; //Field offset: 0x88
	private int _nextEndOfFrameProcessSlot; //Field offset: 0x8C
	private int _nextManualTimeframeProcessSlot; //Field offset: 0x90
	private int _lastUpdateProcessSlot; //Field offset: 0x94
	private int _lastLateUpdateProcessSlot; //Field offset: 0x98
	private int _lastFixedUpdateProcessSlot; //Field offset: 0x9C
	private int _lastSlowUpdateProcessSlot; //Field offset: 0xA0
	private int _lastRealtimeUpdateProcessSlot; //Field offset: 0xA4
	private int _lastEndOfFrameProcessSlot; //Field offset: 0xA8
	private int _lastManualTimeframeProcessSlot; //Field offset: 0xAC
	private float _lastUpdateTime; //Field offset: 0xB0
	private float _lastLateUpdateTime; //Field offset: 0xB4
	private float _lastFixedUpdateTime; //Field offset: 0xB8
	private float _lastSlowUpdateTime; //Field offset: 0xBC
	private float _lastRealtimeUpdateTime; //Field offset: 0xC0
	private float _lastEndOfFrameTime; //Field offset: 0xC4
	private float _lastManualTimeframeTime; //Field offset: 0xC8
	private float _lastSlowUpdateDeltaTime; //Field offset: 0xCC
	private float _lastEditorUpdateDeltaTime; //Field offset: 0xD0
	private float _lastEditorSlowUpdateDeltaTime; //Field offset: 0xD4
	private float _lastManualTimeframeDeltaTime; //Field offset: 0xD8
	private ushort _framesSinceUpdate; //Field offset: 0xDC
	private ushort _expansions; //Field offset: 0xDE
	[HideInInspector]
	[SerializeField]
	private byte _instanceID; //Field offset: 0xE0
	private bool _EOFPumpRan; //Field offset: 0xE1
	private readonly Dictionary<CoroutineHandle, HashSet`1<CoroutineHandle>> _waitingTriggers; //Field offset: 0xE8
	private readonly HashSet<CoroutineHandle> _allWaiting; //Field offset: 0xF0
	private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex; //Field offset: 0xF8
	private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle; //Field offset: 0x100
	private readonly Dictionary<CoroutineHandle, String> _processTags; //Field offset: 0x108
	private readonly Dictionary<String, HashSet`1<CoroutineHandle>> _taggedProcesses; //Field offset: 0x110
	private readonly Dictionary<CoroutineHandle, Int32> _processLayers; //Field offset: 0x118
	private readonly Dictionary<Int32, HashSet`1<CoroutineHandle>> _layeredProcesses; //Field offset: 0x120
	private IEnumerator<Single>[] UpdateProcesses; //Field offset: 0x128
	private IEnumerator<Single>[] LateUpdateProcesses; //Field offset: 0x130
	private IEnumerator<Single>[] FixedUpdateProcesses; //Field offset: 0x138
	private IEnumerator<Single>[] SlowUpdateProcesses; //Field offset: 0x140
	private IEnumerator<Single>[] RealtimeUpdateProcesses; //Field offset: 0x148
	private IEnumerator<Single>[] EditorUpdateProcesses; //Field offset: 0x150
	private IEnumerator<Single>[] EditorSlowUpdateProcesses; //Field offset: 0x158
	private IEnumerator<Single>[] EndOfFrameProcesses; //Field offset: 0x160
	private IEnumerator<Single>[] ManualTimeframeProcesses; //Field offset: 0x168
	private Boolean[] UpdatePaused; //Field offset: 0x170
	private Boolean[] LateUpdatePaused; //Field offset: 0x178
	private Boolean[] FixedUpdatePaused; //Field offset: 0x180
	private Boolean[] SlowUpdatePaused; //Field offset: 0x188
	private Boolean[] RealtimeUpdatePaused; //Field offset: 0x190
	private Boolean[] EditorUpdatePaused; //Field offset: 0x198
	private Boolean[] EditorSlowUpdatePaused; //Field offset: 0x1A0
	private Boolean[] EndOfFramePaused; //Field offset: 0x1A8
	private Boolean[] ManualTimeframePaused; //Field offset: 0x1B0
	private Boolean[] UpdateHeld; //Field offset: 0x1B8
	private Boolean[] LateUpdateHeld; //Field offset: 0x1C0
	private Boolean[] FixedUpdateHeld; //Field offset: 0x1C8
	private Boolean[] SlowUpdateHeld; //Field offset: 0x1D0
	private Boolean[] RealtimeUpdateHeld; //Field offset: 0x1D8
	private Boolean[] EditorUpdateHeld; //Field offset: 0x1E0
	private Boolean[] EditorSlowUpdateHeld; //Field offset: 0x1E8
	private Boolean[] EndOfFrameHeld; //Field offset: 0x1F0
	private Boolean[] ManualTimeframeHeld; //Field offset: 0x1F8
	private CoroutineHandle _eofWatcherHandle; //Field offset: 0x200

	public static event Action OnPreExecute
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public private CoroutineHandle currentCoroutine
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public static CoroutineHandle CurrentCoroutine
	{
		 get { } //Length: 477
	}

	public static float DeltaTime
	{
		 get { } //Length: 88
	}

	public static Timing Instance
	{
		 get { } //Length: 619
		 set { } //Length: 103
	}

	public static float LocalTime
	{
		 get { } //Length: 88
	}

	public private static Thread MainThread
	{
		[CompilerGenerated]
		 get { } //Length: 87
		[CompilerGenerated]
		private set { } //Length: 103
	}

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _CallContinuously(float period, Action action, GameObject gObject) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _CallContinuously(T reference, float period, Action<T> action, GameObject gObject) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _DelayedCall(float delay, Action action, GameObject cancelWith) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator _EOFPump() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _EOFPumpWatcher() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _InjectDelay(IEnumerator<Single> proc, float waitTime) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _StartWhenDone(CoroutineHandle handle, IEnumerator<Single> proc) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static IEnumerator<Single> _StartWhenDone(AsyncOperation operation, IEnumerator<Single> pausedProc) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static IEnumerator<Single> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<Single> pausedProc) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static IEnumerator<Single> _StartWhenDone(Func<Boolean> evaluatorFunc, bool continueOn, IEnumerator<Single> pausedProc) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> _WatchCall(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone) { }

	private static Timing() { }

	public Timing() { }

	[CompilerGenerated]
	public static void add_OnPreExecute(Action value) { }

	private void AddLayerOnInstance(int layer, CoroutineHandle handle) { }

	private void AddTagOnInstance(string tag, CoroutineHandle handle) { }

	public static CoroutineHandle CallContinuously(float timeframe, Action action, Action onDone = null) { }

	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, Action onDone = null) { }

	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, Action onDone = null) { }

	public static CoroutineHandle CallContinuously(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null) { }

	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null) { }

	public static CoroutineHandle CallContinuously(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null) { }

	public static CoroutineHandle CallContinuously(T reference, float timeframe, Action<T> action, Action<T> onDone = null) { }

	public static CoroutineHandle CallContinuously(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Action onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, Action onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, Action onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(T reference, float timeframe, Action<T> action, Action<T> onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null) { }

	public CoroutineHandle CallContinuouslyOnInstance(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null) { }

	public static CoroutineHandle CallDelayed(float delay, Action action) { }

	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject) { }

	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject) { }

	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action) { }

	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject) { }

	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action) { }

	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject) { }

	public CoroutineHandle CallDelayedOnInstance(float delay, Action action) { }

	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, Action onDone = null) { }

	public static CoroutineHandle CallPeriodically(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null) { }

	public static CoroutineHandle CallPeriodically(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null) { }

	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Action onDone = null) { }

	public static CoroutineHandle CallPeriodically(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null) { }

	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null) { }

	public static CoroutineHandle CallPeriodically(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null) { }

	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Action onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null) { }

	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, Action onDone = null) { }

	private void CloseWaitingProcess(CoroutineHandle handle) { }

	private IEnumerator<Single> CoindexExtract(ProcessIndex coindex) { }

	private bool CoindexIsHeld(ProcessIndex coindex) { }

	private bool CoindexIsNull(ProcessIndex coindex) { }

	private bool CoindexIsPaused(ProcessIndex coindex) { }

	private IEnumerator<Single> CoindexPeek(ProcessIndex coindex) { }

	private void CoindexReplace(ProcessIndex coindex, IEnumerator<Single> replacement) { }

	private IEnumerator<Single> CreateHold(ProcessIndex coindex, IEnumerator<Single> coptr) { }

	[Obsolete]
	public static void Destroy(object obj) { }

	[Obsolete]
	public static void Destroy(object obj, float f) { }

	[Obsolete]
	public static void DestroyImmediate(object obj, bool b) { }

	[Obsolete]
	public static void DestroyImmediate(object obj) { }

	[Obsolete]
	public static void DestroyObject(object obj, float f) { }

	[Obsolete]
	public static void DestroyObject(object obj) { }

	private void EditorRemoveUnused() { }

	[Obsolete]
	public static T FindObjectOfType() { }

	[Obsolete]
	public static object FindObjectOfType(Type t) { }

	[Obsolete]
	public static Object[] FindObjectsOfType(Type t) { }

	[Obsolete]
	public static T[] FindObjectsOfType() { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public CoroutineHandle get_currentCoroutine() { }

	public static CoroutineHandle get_CurrentCoroutine() { }

	public static float get_DeltaTime() { }

	public static Timing get_Instance() { }

	public static float get_LocalTime() { }

	[CompilerGenerated]
	public static Thread get_MainThread() { }

	public static string GetDebugName(CoroutineHandle handle) { }

	private static IEnumerator<Single> GetHandleHelper(IEnumerator<Single> input, CoroutineHandle handle) { }

	public static Timing GetInstance(byte ID) { }

	public static Nullable<Int32> GetLayer(CoroutineHandle handle) { }

	[Obsolete]
	public static float GetMyHandle(Action<CoroutineHandle> reciever) { }

	public static Segment GetSegment(CoroutineHandle handle) { }

	private float GetSegmentTime(Segment segment) { }

	public static string GetTag(CoroutineHandle handle) { }

	private bool HandleIsInWaitingList(CoroutineHandle handle) { }

	private void InitializeInstanceID() { }

	[Obsolete]
	public static void Instantiate(object obj) { }

	[Obsolete]
	public static void Instantiate(object original, Vector3 position, Quaternion rotation) { }

	[Obsolete]
	public static void Instantiate(T original) { }

	public static bool IsAliveAndPaused(CoroutineHandle handle) { }

	public static bool IsRunning(CoroutineHandle handle) { }

	public static int KillCoroutines(CoroutineHandle handle) { }

	public static int KillCoroutines(IEnumerable<CoroutineHandle> handles) { }

	public static int KillCoroutines() { }

	public static int KillCoroutines(GameObject gameObj) { }

	public static int KillCoroutines(int layer) { }

	public static int KillCoroutines(string tag) { }

	public static int KillCoroutines(int layer, string tag) { }

	public static int KillCoroutines(GameObject gameObj, string tag) { }

	public int KillCoroutinesOnInstance(GameObject gameObj) { }

	public int KillCoroutinesOnInstance(int layer) { }

	public int KillCoroutinesOnInstance() { }

	public int KillCoroutinesOnInstance(CoroutineHandle handle) { }

	public int KillCoroutinesOnInstance(string tag) { }

	public int KillCoroutinesOnInstance(GameObject gameObj, string tag) { }

	public int KillCoroutinesOnInstance(int layer, string tag) { }

	private void LateUpdate() { }

	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave) { }

	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key) { }

	private bool Nullify(ProcessIndex coindex) { }

	private bool Nullify(CoroutineHandle handle) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private bool OnEditorStart() { }

	private void OnEnable() { }

	public static int PauseCoroutines(int layer) { }

	public static int PauseCoroutines(string tag) { }

	public static int PauseCoroutines(GameObject gameObj) { }

	public static int PauseCoroutines(GameObject gameObj, string tag) { }

	public static int PauseCoroutines(IEnumerable<CoroutineHandle> handles) { }

	public static int PauseCoroutines(int layer, string tag) { }

	public static int PauseCoroutines(CoroutineHandle handle) { }

	public static int PauseCoroutines() { }

	public int PauseCoroutinesOnInstance(int layer, string tag) { }

	public int PauseCoroutinesOnInstance(GameObject gameObj) { }

	public int PauseCoroutinesOnInstance() { }

	public int PauseCoroutinesOnInstance(CoroutineHandle handle) { }

	public int PauseCoroutinesOnInstance(string tag) { }

	public int PauseCoroutinesOnInstance(int layer) { }

	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag) { }

	[Obsolete]
	public static void print(object message) { }

	[CompilerGenerated]
	public static void remove_OnPreExecute(Action value) { }

	private void RemoveGraffiti(CoroutineHandle handle) { }

	public static bool RemoveLayer(CoroutineHandle handle) { }

	private void RemoveLayerOnInstance(CoroutineHandle handle) { }

	public static bool RemoveTag(CoroutineHandle handle) { }

	private void RemoveTagOnInstance(CoroutineHandle handle) { }

	private void RemoveUnused() { }

	public static int ResumeCoroutines(CoroutineHandle handle) { }

	public static int ResumeCoroutines(int layer) { }

	public static int ResumeCoroutines() { }

	public static int ResumeCoroutines(IEnumerable<CoroutineHandle> handles) { }

	public static int ResumeCoroutines(GameObject gameObj) { }

	public static int ResumeCoroutines(int layer, string tag) { }

	public static int ResumeCoroutines(GameObject gameObj, string tag) { }

	public static int ResumeCoroutines(string tag) { }

	public int ResumeCoroutinesOnInstance(CoroutineHandle handle) { }

	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag) { }

	public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles) { }

	public int ResumeCoroutinesOnInstance(GameObject gameObj) { }

	public int ResumeCoroutinesOnInstance(int layer) { }

	public int ResumeCoroutinesOnInstance(string tag) { }

	public int ResumeCoroutinesOnInstance(int layer, string tag) { }

	public int ResumeCoroutinesOnInstance() { }

	private static IEnumerator<Single> ReturnTmpRefForRepFunc(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, int layer) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment, int layer, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, GameObject gameObj) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, GameObject gameObj, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, int layer, string tag) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment) { }

	public static CoroutineHandle RunCoroutine(IEnumerator<Single> coroutine, Segment segment, int layer) { }

	private CoroutineHandle RunCoroutineInternal(IEnumerator<Single> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment, int layer, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment, int layer) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, Segment segment, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, int layer, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, GameObject gameObj, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, string tag) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, int layer) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine, GameObject gameObj) { }

	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<Single> coroutine) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, int layer, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision) { }

	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<Single> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, string tag, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, int layer, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision) { }

	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<Single> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision) { }

	[CompilerGenerated]
	private void set_currentCoroutine(CoroutineHandle value) { }

	public static void set_Instance(Timing value) { }

	[CompilerGenerated]
	private static void set_MainThread(Thread value) { }

	private bool SetHeld(ProcessIndex coindex, bool newHeldState) { }

	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true) { }

	private bool SetPause(ProcessIndex coindex, bool newPausedState) { }

	public static bool SetSegment(CoroutineHandle handle, Segment newSegment) { }

	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true) { }

	[Obsolete]
	public Coroutine StartCoroutine(string methodName, object value) { }

	[Obsolete]
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete]
	public Coroutine StartCoroutine(string methodName) { }

	[Obsolete]
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	[Obsolete]
	public void StopAllCoroutines() { }

	[Obsolete]
	public void StopCoroutine(string methodName) { }

	[Obsolete]
	public void StopCoroutine(IEnumerator routine) { }

	[Obsolete]
	public void StopCoroutine(Coroutine routine) { }

	private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle) { }

	public static float SwitchCoroutine(Segment newSegment, string newTag) { }

	public static float SwitchCoroutine(Segment newSegment, int newLayer) { }

	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag) { }

	public static float SwitchCoroutine(string newTag) { }

	public static float SwitchCoroutine(int newLayer) { }

	public static float SwitchCoroutine(Segment newSegment) { }

	public static float SwitchCoroutine(int newLayer, string newTag) { }

	private static IEnumerator<Single> SwitchCoroutineRepL(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepLT(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepS(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepSL(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepSLT(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepST(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	private static IEnumerator<Single> SwitchCoroutineRepT(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	public void TriggerManualTimeframeUpdate() { }

	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false) { }

	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key) { }

	private void Update() { }

	private bool UpdateTimeValues(Segment segment) { }

	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true) { }

	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true) { }

	public static float WaitForSeconds(float waitTime) { }

	public float WaitForSecondsOnInstance(float waitTime) { }

	public static float WaitUntilDone(CustomYieldInstruction operation) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, string tag) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, int layer) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, int layer, string tag) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, Segment segment) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, Segment segment, string tag) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, Segment segment, int layer) { }

	public static float WaitUntilDone(IEnumerator<Single> newCoroutine, Segment segment, int layer, string tag) { }

	public static float WaitUntilDone(CoroutineHandle otherCoroutine) { }

	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue) { }

	public static float WaitUntilDone(AsyncOperation operation) { }

	public static float WaitUntilFalse(Func<Boolean> evaluatorFunc) { }

	private static IEnumerator<Single> WaitUntilFalseHelper(IEnumerator<Single> coptr, CoroutineHandle handle) { }

	public static float WaitUntilTrue(Func<Boolean> evaluatorFunc) { }

	private static IEnumerator<Single> WaitUntilTrueHelper(IEnumerator<Single> coptr, CoroutineHandle handle) { }

}

