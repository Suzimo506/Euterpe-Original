namespace System.Dynamic;

public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<String, Object>, ICollection<KeyValuePair`2<String, Object>>, IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair`2<String, Object>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		public ExpandoObject <>4__this; //Field offset: 0x28
		public int version; //Field offset: 0x30
		public ExpandoData data; //Field offset: 0x38
		private int <i>5__1; //Field offset: 0x40

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
		public <GetExpandoEnumerator>d__51(int <>1__state) { }

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

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ExpandoData
	{
		internal static ExpandoData Empty; //Field offset: 0x0
		internal readonly ExpandoClass Class; //Field offset: 0x10
		private readonly Object[] _dataArray; //Field offset: 0x18
		private int _version; //Field offset: 0x20

		internal object Item
		{
			internal get { } //Length: 53
			internal set { } //Length: 134
		}

		internal int Length
		{
			internal get { } //Length: 26
		}

		internal int Version
		{
			internal get { } //Length: 4
		}

		private static ExpandoData() { }

		private ExpandoData() { }

		internal ExpandoData(ExpandoClass klass, Object[] data, int version) { }

		internal object get_Item(int index) { }

		internal int get_Length() { }

		internal int get_Version() { }

		private static int GetAlignedSize(int len) { }

		internal void set_Item(int index, object value) { }

		internal ExpandoData UpdateClass(ExpandoClass newClass) { }

	}

	[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class KeyCollection : ICollection<String>, IEnumerable<String>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<String>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private string <>2__current; //Field offset: 0x18
			public KeyCollection <>4__this; //Field offset: 0x20
			private int <i>5__1; //Field offset: 0x28
			private int <n>5__2; //Field offset: 0x2C

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
			public <GetEnumerator>d__15(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private readonly ExpandoObject _expando; //Field offset: 0x10
		private readonly int _expandoVersion; //Field offset: 0x18
		private readonly int _expandoCount; //Field offset: 0x1C
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		public override int Count
		{
			 get { } //Length: 105
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		internal KeyCollection(ExpandoObject expando) { }

		public override void Add(string item) { }

		private void CheckVersion() { }

		public override void Clear() { }

		public override bool Contains(string item) { }

		public override void CopyTo(String[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public override IEnumerator<String> GetEnumerator() { }

		public override bool Remove(string item) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private sealed class KeyCollectionDebugView
	{
		private readonly ICollection<String> _collection; //Field offset: 0x10

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public String[] Items
		{
			 get { } //Length: 242
		}

		public KeyCollectionDebugView(ICollection<String> collection) { }

		public String[] get_Items() { }

	}

	private class MetaExpando : DynamicMetaObject
	{
		[CompilerGenerated]
		private sealed class <GetDynamicMemberNames>d__6 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private string <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public MetaExpando <>4__this; //Field offset: 0x28
			private ExpandoData <expandoData>5__1; //Field offset: 0x30
			private ExpandoClass <klass>5__2; //Field offset: 0x38
			private int <i>5__3; //Field offset: 0x40

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
			public <GetDynamicMemberNames>d__6(int <>1__state) { }

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


		public ExpandoObject Value
		{
			 get { } //Length: 77
		}

		public MetaExpando(Expression expression, ExpandoObject value) { }

		private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

		private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

		public ExpandoObject get_Value() { }

		private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public virtual IEnumerable<String> GetDynamicMemberNames() { }

		private Expression GetLimitedSelf() { }

		private BindingRestrictions GetRestrictions() { }

	}

	[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ValueCollection : ICollection<Object>, IEnumerable<Object>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<Object>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public ValueCollection <>4__this; //Field offset: 0x20
			private ExpandoData <data>5__1; //Field offset: 0x28
			private int <i>5__2; //Field offset: 0x30

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
			public <GetEnumerator>d__15(int <>1__state) { }

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

		private readonly ExpandoObject _expando; //Field offset: 0x10
		private readonly int _expandoVersion; //Field offset: 0x18
		private readonly int _expandoCount; //Field offset: 0x1C
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		public override int Count
		{
			 get { } //Length: 105
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		internal ValueCollection(ExpandoObject expando) { }

		public override void Add(object item) { }

		private void CheckVersion() { }

		public override void Clear() { }

		public override bool Contains(object item) { }

		public override void CopyTo(Object[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public override IEnumerator<Object> GetEnumerator() { }

		public override bool Remove(object item) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private sealed class ValueCollectionDebugView
	{
		private readonly ICollection<Object> _collection; //Field offset: 0x10

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Object[] Items
		{
			 get { } //Length: 242
		}

		public ValueCollectionDebugView(ICollection<Object> collection) { }

		public Object[] get_Items() { }

	}

	private static readonly MethodInfo ExpandoTryGetValue; //Field offset: 0x0
	private static readonly MethodInfo ExpandoTrySetValue; //Field offset: 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; //Field offset: 0x10
	private static readonly MethodInfo ExpandoPromoteClass; //Field offset: 0x18
	private static readonly MethodInfo ExpandoCheckVersion; //Field offset: 0x20
	internal static readonly object Uninitialized; //Field offset: 0x28
	internal readonly object LockObject; //Field offset: 0x10
	private ExpandoData _data; //Field offset: 0x18
	private int _count; //Field offset: 0x20
	private PropertyChangedEventHandler _propertyChanged; //Field offset: 0x28

	internal ExpandoClass Class
	{
		internal get { } //Length: 27
	}

	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.Item
	{
		private get { } //Length: 116
		private set { } //Length: 201
	}

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys
	{
		private get { } //Length: 83
	}

	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values
	{
		private get { } //Length: 83
	}

	private static ExpandoObject() { }

	public ExpandoObject() { }

	private bool ExpandoContainsKey(string key) { }

	internal ExpandoClass get_Class() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<KeyValuePair`2<String, Object>> GetExpandoEnumerator(ExpandoData data, int version) { }

	internal bool IsDeletedMember(int index) { }

	internal void PromoteClass(object oldClass, object newClass) { }

	private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<String, Object> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<String, Object> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<String, Object>[] array, int arrayIndex) { }

	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<String, Object> item) { }

	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	private override IEnumerator<KeyValuePair`2<String, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	private void TryAddMember(string key, object value) { }

	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	private bool TryGetValueForKey(string key, out object value) { }

	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

}

