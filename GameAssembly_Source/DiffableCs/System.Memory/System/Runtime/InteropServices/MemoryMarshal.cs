namespace System.Runtime.InteropServices;

public static class MemoryMarshal
{
	[CompilerGenerated]
	private sealed class <ToEnumerable>d__3 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private ReadOnlyMemory<T> memory; //Field offset: 0x0
		public ReadOnlyMemory<T> <>3__memory; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 65
		}

		[DebuggerHidden]
		public <ToEnumerable>d__3`1(int <>1__state) { }

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


	public static T GetReference(Span<T> span) { }

	public static T GetReference(ReadOnlySpan<T> span) { }

	public static T Read(ReadOnlySpan<Byte> source) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerable<T> ToEnumerable(ReadOnlyMemory<T> memory) { }

	public static bool TryGetArray(ReadOnlyMemory<T> memory, out ArraySegment<T>& segment) { }

	public static bool TryGetMemoryManager(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }

	public static bool TryGetString(ReadOnlyMemory<Char> memory, out string text, out int start, out int length) { }

	public static void Write(Span<Byte> destination, ref T value) { }

}

