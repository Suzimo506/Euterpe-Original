namespace Antlr.Runtime.Tree;

public class DotTreeGenerator
{
	[CompilerGenerated]
	private sealed class <DefineEdges>d__9 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private object tree; //Field offset: 0x28
		public object <>3__tree; //Field offset: 0x30
		private ITreeAdaptor adaptor; //Field offset: 0x38
		public ITreeAdaptor <>3__adaptor; //Field offset: 0x40
		public DotTreeGenerator <>4__this; //Field offset: 0x48
		private int <n>5__2; //Field offset: 0x50
		private string <parentName>5__3; //Field offset: 0x58
		private string <parentText>5__4; //Field offset: 0x60
		private int <i>5__5; //Field offset: 0x68
		private object <child>5__6; //Field offset: 0x70
		private IEnumerator<String> <>7__wrap6; //Field offset: 0x78

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
		public <DefineEdges>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <DefineNodes>d__8 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private object tree; //Field offset: 0x28
		public object <>3__tree; //Field offset: 0x30
		private ITreeAdaptor adaptor; //Field offset: 0x38
		public ITreeAdaptor <>3__adaptor; //Field offset: 0x40
		public DotTreeGenerator <>4__this; //Field offset: 0x48
		private int <n>5__2; //Field offset: 0x50
		private int <i>5__3; //Field offset: 0x54
		private object <child>5__4; //Field offset: 0x58
		private IEnumerator<String> <>7__wrap4; //Field offset: 0x60

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
		public <DefineNodes>d__8(int <>1__state) { }

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

	private const string Footer = "}"; //Field offset: 0x0
	private const string NodeFormat = "  {0} [label="{1}"];"; //Field offset: 0x0
	private const string EdgeFormat = "  {0} -> {1} // "{2}" -> "{3}""; //Field offset: 0x0
	private readonly String[] HeaderLines; //Field offset: 0x10
	private Dictionary<Object, Int32> nodeToNumberMap; //Field offset: 0x18
	private int nodeNumber; //Field offset: 0x20

	public DotTreeGenerator() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override IEnumerable<String> DefineEdges(object tree, ITreeAdaptor adaptor) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override IEnumerable<String> DefineNodes(object tree, ITreeAdaptor adaptor) { }

	protected override string FixString(string text) { }

	protected override int GetNodeNumber(object t) { }

	protected override string GetNodeText(ITreeAdaptor adaptor, object t) { }

	public override string ToDot(object tree, ITreeAdaptor adaptor) { }

	public override string ToDot(ITree tree) { }

}

