namespace ProtoBuf.Meta;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MetaType : ISerializerProxy
{
	[Flags]
	public enum AttributeFamily
	{
		None = 0,
		ProtoBuf = 1,
		DataContractSerialier = 2,
		XmlSerializer = 4,
		AutoTuple = 8,
	}

	public sealed class Comparer : IComparer, IComparer<MetaType>
	{
		public static readonly Comparer Default; //Field offset: 0x6513C

		private static Comparer() { }

		public Comparer() { }

		public override int Compare(object x, object y) { }

		public override int Compare(MetaType x, MetaType y) { }

	}

	private const byte OPTIONS_AsReferenceDefault = 32; //Field offset: 0x0
	private const byte OPTIONS_PrivateOnApi = 8; //Field offset: 0x0
	internal static readonly Type ienumerable; //Field offset: 0x0
	private const byte OPTIONS_Frozen = 4; //Field offset: 0x0
	private const byte OPTIONS_EnumPassThru = 2; //Field offset: 0x0
	private const byte OPTIONS_Pending = 1; //Field offset: 0x0
	private const byte OPTIONS_AutoTuple = 64; //Field offset: 0x0
	private const byte OPTIONS_IgnoreListHandling = 128; //Field offset: 0x0
	private const byte OPTIONS_SkipConstructor = 16; //Field offset: 0x0
	private MetaType baseType; //Field offset: 0x10
	private BasicList subTypes; //Field offset: 0x18
	private CallbackSet callbacks; //Field offset: 0x20
	private string name; //Field offset: 0x28
	private MethodInfo factory; //Field offset: 0x30
	private readonly RuntimeTypeModel model; //Field offset: 0x38
	private readonly Type type; //Field offset: 0x40
	private IProtoTypeSerializer serializer; //Field offset: 0x48
	private Type constructType; //Field offset: 0x50
	private Type surrogate; //Field offset: 0x58
	private readonly BasicList fields; //Field offset: 0x60
	private byte flags; //Field offset: 0x68

	public bool AsReferenceDefault
	{
		 get { } //Length: 30
		 set { } //Length: 104
	}

	public MetaType BaseType
	{
		 get { } //Length: 5
	}

	public CallbackSet Callbacks
	{
		 get { } //Length: 157
	}

	public Type ConstructType
	{
		 get { } //Length: 5
		 set { } //Length: 48
	}

	public bool EnumPassthru
	{
		 get { } //Length: 29
		 set { } //Length: 103
	}

	internal IEnumerable Fields
	{
		internal get { } //Length: 5
	}

	public bool HasCallbacks
	{
		 get { } //Length: 104
	}

	public bool HasSubtypes
	{
		 get { } //Length: 44
	}

	public bool IgnoreListHandling
	{
		 get { } //Length: 27
		 set { } //Length: 101
	}

	public bool IncludeSerializerMethod
	{
		 get { } //Length: 32
		 set { } //Length: 108
	}

	internal bool IsAutoTuple
	{
		internal get { } //Length: 30
	}

	internal bool IsList
	{
		internal get { } //Length: 165
	}

	private bool IsValueType
	{
		private get { } //Length: 29
	}

	public ValueMember Item
	{
		 get { } //Length: 313
	}

	public ValueMember Item
	{
		 get { } //Length: 276
	}

	internal TypeModel Model
	{
		internal get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 48
	}

	internal bool Pending
	{
		internal get { } //Length: 27
		internal set { } //Length: 77
	}

	private override IProtoSerializer ProtoBuf.Serializers.ISerializerProxy.Serializer
	{
		private get { } //Length: 7
	}

	internal IProtoTypeSerializer Serializer
	{
		internal get { } //Length: 343
	}

	public Type Type
	{
		 get { } //Length: 5
	}

	public bool UseConstructor
	{
		 get { } //Length: 32
		 set { } //Length: 108
	}

	private static MetaType() { }

	internal MetaType(RuntimeTypeModel model, Type type, MethodInfo factory) { }

	public MetaType Add(string memberName) { }

	public MetaType Add(String[] memberNames) { }

	public MetaType Add(int fieldNumber, string memberName, object defaultValue) { }

	public MetaType Add(int fieldNumber, string memberName, Type itemType, Type defaultType) { }

	public MetaType Add(int fieldNumber, string memberName) { }

	private void Add(ValueMember member) { }

	public ValueMember AddField(int fieldNumber, string memberName) { }

	private ValueMember AddField(int fieldNumber, string memberName, Type itemType, Type defaultType, object defaultValue) { }

	public ValueMember AddField(int fieldNumber, string memberName, Type itemType, Type defaultType) { }

	public MetaType AddSubType(int fieldNumber, Type derivedType, DataFormat dataFormat) { }

	public MetaType AddSubType(int fieldNumber, Type derivedType) { }

	internal void ApplyDefaultBehaviour() { }

	private ValueMember ApplyDefaultBehaviour(bool isEnum, ProtoMemberAttribute normalizedAttribute) { }

	private static void ApplyDefaultBehaviour_AddMembers(TypeModel model, AttributeFamily family, bool isEnum, BasicList partialMembers, int dataMemberOffset, bool inferTagByName, ImplicitFields implicitMode, BasicList members, MemberInfo member, ref bool forced, bool isPublic, bool isField, ref Type effectiveType) { }

	private IProtoTypeSerializer BuildSerializer() { }

	private static void CheckForCallback(MethodInfo method, AttributeMap[] attributes, string callbackTypeName, ref MethodInfo[] callbacks, int index) { }

	private static MethodInfo Coalesce(MethodInfo[] arr, int x, int y) { }

	public bool get_AsReferenceDefault() { }

	public MetaType get_BaseType() { }

	public CallbackSet get_Callbacks() { }

	public Type get_ConstructType() { }

	public bool get_EnumPassthru() { }

	internal IEnumerable get_Fields() { }

	public bool get_HasCallbacks() { }

	public bool get_HasSubtypes() { }

	public bool get_IgnoreListHandling() { }

	public bool get_IncludeSerializerMethod() { }

	internal bool get_IsAutoTuple() { }

	internal bool get_IsList() { }

	private bool get_IsValueType() { }

	public ValueMember get_Item(int fieldNumber) { }

	public ValueMember get_Item(MemberInfo member) { }

	internal TypeModel get_Model() { }

	public string get_Name() { }

	internal bool get_Pending() { }

	internal IProtoTypeSerializer get_Serializer() { }

	public Type get_Type() { }

	public bool get_UseConstructor() { }

	internal static bool GetAsReferenceDefault(RuntimeTypeModel model, Type type) { }

	private static AttributeMap GetAttribute(AttributeMap[] attribs, string fullName) { }

	private static Type GetBaseType(MetaType type) { }

	internal static AttributeFamily GetContractFamily(RuntimeTypeModel model, Type type, AttributeMap[] attributes) { }

	private static void GetDataFormat(ref DataFormat value, AttributeMap attrib, string memberName) { }

	internal EnumPair[] GetEnumMap() { }

	private static void GetFieldBoolean(ref bool value, AttributeMap attrib, string memberName) { }

	private static bool GetFieldBoolean(ref bool value, AttributeMap attrib, string memberName, bool publicOnly) { }

	private static void GetFieldName(ref string name, AttributeMap attrib, string memberName) { }

	private static void GetFieldNumber(ref int value, AttributeMap attrib, string memberName) { }

	public ValueMember[] GetFields() { }

	private static void GetIgnore(ref bool ignore, AttributeMap attrib, AttributeMap[] attribs, string fullName) { }

	internal int GetKey(bool demand, bool getBaseKey) { }

	private int GetNextFieldNumber() { }

	internal static MetaType GetRootType(MetaType source) { }

	internal string GetSchemaTypeName() { }

	public SubType[] GetSubtypes() { }

	internal MetaType GetSurrogateOrBaseOrSelf(bool deep) { }

	internal MetaType GetSurrogateOrSelf() { }

	private static bool HasFamily(AttributeFamily value, AttributeFamily required) { }

	private bool HasFlag(byte flag) { }

	internal static Exception InbuiltType(Type type) { }

	internal bool IsDefined(int fieldNumber) { }

	internal bool IsPrepared() { }

	private bool IsValidSubType(Type subType) { }

	internal static StringBuilder NewLine(StringBuilder builder, int indent) { }

	private static ProtoMemberAttribute NormalizeProtoMember(TypeModel model, MemberInfo member, AttributeFamily family, bool forced, bool isEnum, BasicList partialMembers, int dataMemberOffset, bool inferByTagName) { }

	private override IProtoSerializer ProtoBuf.Serializers.ISerializerProxy.get_Serializer() { }

	internal static void ResolveListTypes(TypeModel model, Type type, ref Type itemType, ref Type defaultType) { }

	private MethodInfo ResolveMethod(string name, bool instance) { }

	internal static ConstructorInfo ResolveTupleConstructor(Type type, out MemberInfo[] mappedMembers) { }

	public void set_AsReferenceDefault(bool value) { }

	public void set_ConstructType(Type value) { }

	public void set_EnumPassthru(bool value) { }

	public void set_IgnoreListHandling(bool value) { }

	public void set_IncludeSerializerMethod(bool value) { }

	public void set_Name(string value) { }

	internal void set_Pending(bool value) { }

	public void set_UseConstructor(bool value) { }

	private void SetBaseType(MetaType baseType) { }

	public MetaType SetCallbacks(string beforeSerialize, string afterSerialize, string beforeDeserialize, string afterDeserialize) { }

	public MetaType SetCallbacks(MethodInfo beforeSerialize, MethodInfo afterSerialize, MethodInfo beforeDeserialize, MethodInfo afterDeserialize) { }

	public MetaType SetFactory(string factory) { }

	public MetaType SetFactory(MethodInfo factory) { }

	private void SetFlag(byte flag, bool value, bool throwIfFrozen) { }

	public void SetSurrogate(Type surrogateType) { }

	protected private void ThrowIfFrozen() { }

	public virtual string ToString() { }

	internal void WriteSchema(StringBuilder builder, int indent, ref bool requiresBclImport) { }

}

