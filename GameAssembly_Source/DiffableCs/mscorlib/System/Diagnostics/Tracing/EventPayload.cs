namespace System.Diagnostics.Tracing;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class EventPayload : IDictionary<String, Object>, ICollection<KeyValuePair`2<String, Object>>, IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__17 : IEnumerator<KeyValuePair`2<String, Object>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		public EventPayload <>4__this; //Field offset: 0x28
		private int <i>5__1; //Field offset: 0x30

		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 68
		}

		[DebuggerHidden]
		public <GetEnumerator>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private List<String> m_names; //Field offset: 0x10
	private List<Object> m_values; //Field offset: 0x18

	public override int Count
	{
		 get { } //Length: 59
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override object Item
	{
		 get { } //Length: 486
		 set { } //Length: 73
	}

	public override ICollection<String> Keys
	{
		 get { } //Length: 5
	}

	public override ICollection<Object> Values
	{
		 get { } //Length: 5
	}

	internal EventPayload(List<String> payloadNames, List<Object> payloadValues) { }

	public override void Add(KeyValuePair<String, Object> payloadEntry) { }

	public override void Add(string key, object value) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<String, Object> entry) { }

	public override bool ContainsKey(string key) { }

	public override void CopyTo(KeyValuePair<String, Object>[] payloadEntries, int count) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override object get_Item(string key) { }

	public override ICollection<String> get_Keys() { }

	public override ICollection<Object> get_Values() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator<KeyValuePair`2<String, Object>> GetEnumerator() { }

	public override bool Remove(KeyValuePair<String, Object> entry) { }

	public override bool Remove(string key) { }

	public override void set_Item(string key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(string key, out object value) { }

}

