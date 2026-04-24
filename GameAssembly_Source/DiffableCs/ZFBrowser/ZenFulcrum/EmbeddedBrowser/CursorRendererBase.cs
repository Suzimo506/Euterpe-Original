namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class CursorRendererBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Setup>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CursorRendererBase <>4__this; //Field offset: 0x20

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
		public <Setup>d__2(int <>1__state) { }

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

	protected BrowserCursor cursor; //Field offset: 0x18

	protected CursorRendererBase() { }

	protected abstract void CursorChange() { }

	public override void OnEnable() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Setup() { }

}

