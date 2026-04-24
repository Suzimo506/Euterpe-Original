namespace ProtoBuf.Meta;

public abstract class TypeModel
{
	private enum CallbackType
	{
		BeforeSerialize = 0,
		AfterSerialize = 1,
		BeforeDeserialize = 2,
		AfterDeserialize = 3,
	}

	private class DeserializeItemsIterator : IEnumerator, IEnumerable
	{
		private bool haveObject; //Field offset: 0x10
		private object current; //Field offset: 0x18
		private readonly Stream source; //Field offset: 0x20
		private readonly Type type; //Field offset: 0x28
		private readonly PrefixStyle style; //Field offset: 0x30
		private readonly int expectedField; //Field offset: 0x34
		private readonly TypeResolver resolver; //Field offset: 0x38
		private readonly TypeModel model; //Field offset: 0x40
		private readonly SerializationContext context; //Field offset: 0x48

		public override object Current
		{
			 get { } //Length: 5
		}

		public DeserializeItemsIterator(TypeModel model, Stream source, Type type, PrefixStyle style, int expectedField, TypeResolver resolver, SerializationContext context) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private sealed class DeserializeItemsIterator : DeserializeItemsIterator, IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable
	{

		public override T Current
		{
			 get { } //Length: 111
		}

		public DeserializeItemsIterator`1(TypeModel model, Stream source, PrefixStyle style, int expectedField, SerializationContext context) { }

		public override T get_Current() { }

		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override void System.IDisposable.Dispose() { }

	}

	private static readonly Type ilist; //Field offset: 0x0
	[CompilerGenerated]
	private TypeFormatEventHandler DynamicTypeFormatting; //Field offset: 0x10

	public event TypeFormatEventHandler DynamicTypeFormatting
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private static TypeModel() { }

	protected TypeModel() { }

	[CompilerGenerated]
	public void add_DynamicTypeFormatting(TypeFormatEventHandler value) { }

	private bool CanSerialize(Type type, bool allowBasic, bool allowContract, bool allowLists) { }

	public bool CanSerialize(Type type) { }

	public bool CanSerializeBasicType(Type type) { }

	public bool CanSerializeContractType(Type type) { }

	private static bool CheckDictionaryAccessors(TypeModel model, Type pair, Type value) { }

	public static RuntimeTypeModel Create() { }

	private static object CreateListInstance(Type listType, Type itemType) { }

	internal static Exception CreateNestedListsNotSupported() { }

	public object DeepClone(object value) { }

	protected private abstract object Deserialize(int key, object value, ProtoReader source) { }

	public object Deserialize(Stream source, object value, Type type) { }

	public object Deserialize(Stream source, object value, Type type, SerializationContext context) { }

	public object Deserialize(Stream source, object value, Type type, int length) { }

	public object Deserialize(Stream source, object value, Type type, int length, SerializationContext context) { }

	public object Deserialize(ProtoReader source, object value, Type type) { }

	private object DeserializeCore(ProtoReader reader, Type type, object value, bool noAutoCreate) { }

	public IEnumerable DeserializeItems(Stream source, Type type, PrefixStyle style, int expectedField, TypeResolver resolver) { }

	public IEnumerable DeserializeItems(Stream source, Type type, PrefixStyle style, int expectedField, TypeResolver resolver, SerializationContext context) { }

	public IEnumerable<T> DeserializeItems(Stream source, PrefixStyle style, int expectedField) { }

	public IEnumerable<T> DeserializeItems(Stream source, PrefixStyle style, int expectedField, SerializationContext context) { }

	internal static Type DeserializeType(TypeModel model, string value) { }

	public object DeserializeWithLengthPrefix(Stream source, object value, Type type, PrefixStyle style, int fieldNumber) { }

	public object DeserializeWithLengthPrefix(Stream source, object value, Type type, PrefixStyle style, int expectedField, TypeResolver resolver) { }

	public object DeserializeWithLengthPrefix(Stream source, object value, Type type, PrefixStyle style, int expectedField, TypeResolver resolver, out int bytesRead) { }

	private object DeserializeWithLengthPrefix(Stream source, object value, Type type, PrefixStyle style, int expectedField, TypeResolver resolver, out int bytesRead, out bool haveObject, SerializationContext context) { }

	protected private int GetKey(ref Type type) { }

	protected abstract int GetKeyImpl(Type type) { }

	internal static Type GetListItemType(TypeModel model, Type listType) { }

	public override string GetSchema(Type type) { }

	internal override Type GetType(string fullName, Assembly context) { }

	private WireType GetWireType(ProtoTypeCode code, DataFormat format, ref Type type, out int modelKey) { }

	public bool IsDefined(Type type) { }

	protected private Type MapType(Type type) { }

	protected private override Type MapType(Type type, bool demand) { }

	private bool PrepareDeserialize(object value, ref Type type) { }

	[CompilerGenerated]
	public void remove_DynamicTypeFormatting(TypeFormatEventHandler value) { }

	internal static Type ResolveKnownType(string name, TypeModel model, Assembly assembly) { }

	internal static MethodInfo ResolveListAdd(TypeModel model, Type listType, Type itemType, out bool isList) { }

	protected private static Type ResolveProxies(Type type) { }

	protected private abstract void Serialize(int key, object value, ProtoWriter dest) { }

	public void Serialize(Stream dest, object value) { }

	public void Serialize(ProtoWriter dest, object value) { }

	public void Serialize(Stream dest, object value, SerializationContext context) { }

	private void SerializeCore(ProtoWriter writer, object value) { }

	internal static string SerializeType(TypeModel model, Type type) { }

	public void SerializeWithLengthPrefix(Stream dest, object value, Type type, PrefixStyle style, int fieldNumber, SerializationContext context) { }

	public void SerializeWithLengthPrefix(Stream dest, object value, Type type, PrefixStyle style, int fieldNumber) { }

	private static void TestEnumerableListPatterns(TypeModel model, BasicList candidates, Type iType) { }

	public static void ThrowCannotCreateInstance(Type type) { }

	protected private static void ThrowUnexpectedSubtype(Type expected, Type actual) { }

	protected private static void ThrowUnexpectedType(Type type) { }

	internal bool TryDeserializeAuxiliaryType(ProtoReader reader, DataFormat format, int tag, Type type, ref object value, bool skipOtherFields, bool asListItem, bool autoCreate, bool insideList) { }

	private bool TryDeserializeList(TypeModel model, ProtoReader reader, DataFormat format, int tag, Type listType, Type itemType, ref object value) { }

	internal bool TrySerializeAuxiliaryType(ProtoWriter writer, Type type, DataFormat format, int tag, object value, bool isInsideList) { }

}

