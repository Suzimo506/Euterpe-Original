namespace Assets.Scripts.PeroTools.Others;

public class LoadingScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__7_3; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Start>b__7_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public AsyncOperationHandle<SceneInstance> loadLevelOpr; //Field offset: 0x10
		public LoadingScene <>4__this; //Field offset: 0x30

		public <>c__DisplayClass7_0() { }

		internal bool <Start>b__0() { }

		internal bool <Start>b__1() { }

		internal bool <Start>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <Start>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LoadingScene <>4__this; //Field offset: 0x20
		private <>c__DisplayClass7_0 <>8__1; //Field offset: 0x28
		private Stopwatch <watch>5__2; //Field offset: 0x30

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
		public <Start>d__7(int <>1__state) { }

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
	private static bool <isOnLoaded>k__BackingField; //Field offset: 0x0
	private float m_LoadingTime; //Field offset: 0x18
	public Text loadingTip; //Field offset: 0x20

	public private static bool isOnLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 58
	}

	public LoadingScene() { }

	[CompilerGenerated]
	private void <DelayDestroy>b__9_0() { }

	private void Complete() { }

	private void DelayDestroy() { }

	[CompilerGenerated]
	public static bool get_isOnLoaded() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private static void set_isOnLoaded(bool value) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Start() { }

	private void Update() { }

}

