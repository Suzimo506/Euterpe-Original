namespace Assets.Scripts.PeroTools.Managers;

public class CoroutineManager : SingletonMonoBehaviour<CoroutineManager>, IPause
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action callback; //Field offset: 0x10
		public CoroutineManager <>4__this; //Field offset: 0x18
		public Action failCallback; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public bool isDone; //Field offset: 0x10
		public Coroutine couroutine; //Field offset: 0x18
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass6_1() { }

		internal void <StartCoroutine>b__0() { }

		internal void <StartCoroutine>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <CoroutineEndOfFrame>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

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
		public <CoroutineEndOfFrame>d__9(int <>1__state) { }

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
	private sealed class <CoroutineFixedFramesEnumerator>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public int frames; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38

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
		public <CoroutineFixedFramesEnumerator>d__11(int <>1__state) { }

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
	private sealed class <CoroutineFramesEnumerator>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public int frames; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38

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
		public <CoroutineFramesEnumerator>d__10(int <>1__state) { }

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
	private sealed class <CoroutineObjectEnumerator>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public Func<Object> callback; //Field offset: 0x28

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
		public <CoroutineObjectEnumerator>d__12(int <>1__state) { }

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
	private sealed class <CoroutineSecondsEnumerator>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public bool ignoreActive; //Field offset: 0x28
		public float seconds; //Field offset: 0x2C
		public Action callback; //Field offset: 0x30
		private float <time>5__2; //Field offset: 0x38

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
		public <CoroutineSecondsEnumerator>d__13(int <>1__state) { }

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
	private sealed class <CoroutineUtilEnumerator>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineManager <>4__this; //Field offset: 0x20
		public Func<Boolean> boolFunc; //Field offset: 0x28
		public Action callback; //Field offset: 0x30

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
		public <CoroutineUtilEnumerator>d__8(int <>1__state) { }

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

	private bool m_IsCoroutineActive; //Field offset: 0x18

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public CoroutineManager() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineEndOfFrame(Action callback) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineFixedFramesEnumerator(Action callback, int frames) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineFramesEnumerator(Action callback, int frames) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineObjectEnumerator(Func<Object> callback) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineSecondsEnumerator(Action callback, float seconds, bool ignoreActive) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CoroutineUtilEnumerator(Action callback, Func<Boolean> boolFunc) { }

	public Coroutine Delay(Action callback, decimal seconds) { }

	public Coroutine Delay(Action callback, int frames, bool isFixed = false) { }

	public Coroutine Delay(Action callback, float seconds, bool ignoreActive = false) { }

	public Coroutine EndFrameAction(Action callback) { }

	public override bool get_IsGlobal() { }

	private void Init() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

	public Coroutine StartCoroutine(Action callback, Func<Boolean> boolFunc, float failTime = -1, Action failCallback = null) { }

	public Coroutine StartCoroutine(Func<Object> callback) { }

	public void StopCoroutine(ref Coroutine cor) { }

}

