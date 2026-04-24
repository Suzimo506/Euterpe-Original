namespace Google.Protobuf;

public sealed class ExtensionRegistry : ICollection<Extension>, IEnumerable<Extension>, IEnumerable, IDeepCloneable<ExtensionRegistry>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ObjectIntPair`1<Type>, Extension>, ObjectIntPair`1<Type>> <>9__3_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<ObjectIntPair`1<Type>, Extension>, Extension> <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ObjectIntPair<Type> <.ctor>b__3_0(KeyValuePair<ObjectIntPair`1<Type>, Extension> k) { }

		internal Extension <.ctor>b__3_1(KeyValuePair<ObjectIntPair`1<Type>, Extension> v) { }

	}

	public sealed class ExtensionComparer : IEqualityComparer<Extension>
	{
		internal static ExtensionComparer Instance; //Field offset: 0x2C927B4

		private static ExtensionComparer() { }

		public ExtensionComparer() { }

		public override bool Equals(Extension a, Extension b) { }

		public override int GetHashCode(Extension a) { }

	}

	private IDictionary<ObjectIntPair`1<Type>, Extension> extensions; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 69
	}

	private override bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly
	{
		private get { } //Length: 3
	}

	public ExtensionRegistry() { }

	private ExtensionRegistry(IDictionary<ObjectIntPair`1<Type>, Extension> collection) { }

	public override void Add(Extension extension) { }

	public void AddRange(IEnumerable<Extension> extensions) { }

	public override void Clear() { }

	public override ExtensionRegistry Clone() { }

	public override bool Contains(Extension item) { }

	internal bool ContainsInputField(uint lastTag, Type target, out Extension extension) { }

	public override int get_Count() { }

	public override IEnumerator<Extension> GetEnumerator() { }

	public override bool Remove(Extension item) { }

	private override void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Extension[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

