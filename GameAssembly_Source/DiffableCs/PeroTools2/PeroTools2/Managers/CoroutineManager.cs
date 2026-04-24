namespace PeroTools2.Managers;

public class CoroutineManager : SingletonMonoBehaviour<CoroutineManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public CoroutineHandle coroutineHandle; //Field offset: 0x10
		public CoroutineManager <>4__this; //Field offset: 0x18
		public Action failCallback; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <StartCoroutine>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <CoroutineFramesEnumerator>d__8 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public int frames; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

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
		public <CoroutineFramesEnumerator>d__8(int <>1__state) { }

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
	private sealed class <CoroutineUtilEnumerator>d__9 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public Func<Boolean> boolFunc; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

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
		public <CoroutineUtilEnumerator>d__9(int <>1__state) { }

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

	private Timing m_Timing; //Field offset: 0x58

	public CoroutineManager() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> CoroutineFramesEnumerator(Action callback, int frames) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> CoroutineUtilEnumerator(Action callback, Func<Boolean> boolFunc) { }

	public CoroutineHandle Delay(Action callback, float seconds, Segment segment = 0) { }

	public CoroutineHandle Delay(Action callback, int frames, Segment segment = 0) { }

	private void Init() { }

	public void Kill(CoroutineHandle coroutine) { }

	public void Pause(CoroutineHandle coroutine) { }

	public void Resume(CoroutineHandle coroutine) { }

	public CoroutineHandle StartCoroutine(Action callback, Func<Boolean> boolFunc, float failTime = -1, Action failCallback = null, Segment segment = 0) { }

	public CoroutineHandle StartCoroutine(IEnumerator<Single> coroutine, Segment segment = 0) { }

	public static void StartEditorCoroutine(IEnumerator coroutine) { }

	public static void StopEditorCoroutine(IEnumerator coroutine) { }

}

