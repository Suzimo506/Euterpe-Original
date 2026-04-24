namespace xdsdk.Unity;

[DisallowMultipleComponent]
public class UIAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action callback; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <BlockForSecond>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <BlockCoroutine>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float blockDuration; //Field offset: 0x20
		public Action onBlockEnd; //Field offset: 0x28

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
		public <BlockCoroutine>d__3(int <>1__state) { }

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


	public UIAnimator() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator BlockCoroutine(float blockDuration, Action onBlockEnd = null) { }

	private void BlockForSecond(float duration, Action callback = null) { }

	public void DoEnterAnimation(UIElement pause, UIElement enter, Action onAnimationEnd = null) { }

	public void DoExitAnimation(UIElement exit, UIElement resume, Action onAnimationEnd = null) { }

}

