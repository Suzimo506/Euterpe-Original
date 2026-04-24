namespace ProtoBuf;

internal static class ExtensibleUtil
{
	[CompilerGenerated]
	private sealed class <GetExtendedValues>d__0 : IEnumerable<TValue>, IEnumerable, IEnumerator<TValue>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TValue <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IExtensible instance; //Field offset: 0x0
		public IExtensible <>3__instance; //Field offset: 0x0
		private int tag; //Field offset: 0x0
		public int <>3__tag; //Field offset: 0x0
		private DataFormat format; //Field offset: 0x0
		public DataFormat <>3__format; //Field offset: 0x0
		private bool singleton; //Field offset: 0x0
		public bool <>3__singleton; //Field offset: 0x0
		private bool allowDefinedTag; //Field offset: 0x0
		public bool <>3__allowDefinedTag; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TValue System.Collections.Generic.IEnumerator<TValue>.Current
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
		public <GetExtendedValues>d__0`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[DebuggerHidden]
		private override TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

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
	private sealed class <GetExtendedValues>d__1 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IExtensible instance; //Field offset: 0x28
		public IExtensible <>3__instance; //Field offset: 0x30
		private int tag; //Field offset: 0x38
		public int <>3__tag; //Field offset: 0x3C
		private TypeModel model; //Field offset: 0x40
		public TypeModel <>3__model; //Field offset: 0x48
		private bool singleton; //Field offset: 0x50
		public bool <>3__singleton; //Field offset: 0x51
		private DataFormat format; //Field offset: 0x54
		public DataFormat <>3__format; //Field offset: 0x58
		private Type type; //Field offset: 0x60
		public Type <>3__type; //Field offset: 0x68
		private IExtension <extn>5__2; //Field offset: 0x70
		private Stream <stream>5__3; //Field offset: 0x78
		private ProtoReader <reader>5__4; //Field offset: 0x80

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
		public <GetExtendedValues>d__1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	internal static void AppendExtendValue(TypeModel model, IExtensible instance, int tag, DataFormat format, object value) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static IEnumerable GetExtendedValues(TypeModel model, Type type, IExtensible instance, int tag, DataFormat format, bool singleton, bool allowDefinedTag) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static IEnumerable<TValue> GetExtendedValues(IExtensible instance, int tag, DataFormat format, bool singleton, bool allowDefinedTag) { }

}

