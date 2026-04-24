namespace FlexFramework.Excel;

public abstract class CustomConverter : IConverter
{
	[CompilerGenerated]
	private sealed class <SplitGroup>d__5 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private string <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private char start; //Field offset: 0x0
		public char <>3__start; //Field offset: 0x0
		private char end; //Field offset: 0x0
		public char <>3__end; //Field offset: 0x0
		private string input; //Field offset: 0x0
		public string <>3__input; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <SplitGroup>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	private override Type FlexFramework.Excel.IConverter.Type
	{
		private get { } //Length: 95
	}

	protected CustomConverter`1() { }

	public abstract T Convert(string input) { }

	private override object FlexFramework.Excel.IConverter.Convert(string input) { }

	private override Type FlexFramework.Excel.IConverter.get_Type() { }

	protected String[] Split(string input, Char[] separators) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected IEnumerable<String> SplitGroup(string input, char start, char end) { }

	public bool TryConvert(string input, out T value) { }

}

