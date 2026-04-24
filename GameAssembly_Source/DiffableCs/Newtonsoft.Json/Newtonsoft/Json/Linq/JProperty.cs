namespace Newtonsoft.Json.Linq;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JProperty : JContainer
{
	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private JToken <>2__current; //Field offset: 0x18
			[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
			public JPropertyList <>4__this; //Field offset: 0x20

			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
			public <GetEnumerator>d__1(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal JToken _token; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 10
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override JToken Item
		{
			 get { } //Length: 101
			 set { } //Length: 124
		}

		public JPropertyList() { }

		public override void Add(JToken item) { }

		public override void Clear() { }

		public override bool Contains(JToken item) { }

		public override void CopyTo(JToken[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override JToken get_Item(int index) { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public override IEnumerator<JToken> GetEnumerator() { }

		public override int IndexOf(JToken item) { }

		public override void Insert(int index, JToken item) { }

		public override bool Remove(JToken item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, JToken value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly JPropertyList _content; //Field offset: 0x58
	private readonly string _name; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	public string Name
	{
		[DebuggerStepThrough]
		 get { } //Length: 5
	}

	public virtual JTokenType Type
	{
		[DebuggerStepThrough]
		 get { } //Length: 6
	}

	public JToken Value
	{
		[DebuggerStepThrough]
		 get { } //Length: 27
		 set { } //Length: 126
	}

	public JProperty(string name, object content) { }

	public JProperty(JProperty other) { }

	internal JProperty(string name) { }

	internal virtual void ClearItems() { }

	internal virtual JToken CloneToken() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual bool ContainsItem(JToken item) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	public string get_Name() { }

	[DebuggerStepThrough]
	public virtual JTokenType get_Type() { }

	[DebuggerStepThrough]
	public JToken get_Value() { }

	internal virtual JToken GetItem(int index) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual int IndexOfItem(JToken item) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	public static JProperty Load(JsonReader reader) { }

	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual bool RemoveItem(JToken item) { }

	internal virtual void RemoveItemAt(int index) { }

	public void set_Value(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual void SetItem(int index, JToken item) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

