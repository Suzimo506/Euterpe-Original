namespace ZenFulcrum.EmbeddedBrowser.Promises;

[Extension]
public static class EnumerableExt
{
	[CompilerGenerated]
	private sealed class <LazyEach>d__1 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<T> source; //Field offset: 0x0
		public IEnumerable<T> <>3__source; //Field offset: 0x0
		private Action<T> fn; //Field offset: 0x0
		public Action<T> <>3__fn; //Field offset: 0x0
		private IEnumerator<T> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <LazyEach>d__1`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static void Each(IEnumerable<T> source, Action<T> fn) { }

	[Extension]
	public static void Each(IEnumerable<T> source, Action<T, Int32> fn) { }

	public static IEnumerable<T> Empty() { }

	[Extension]
	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerable<T> LazyEach(IEnumerable<T> source, Action<T> fn) { }

}

