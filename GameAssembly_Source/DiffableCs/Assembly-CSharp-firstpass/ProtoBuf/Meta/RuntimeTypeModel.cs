namespace ProtoBuf.Meta;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RuntimeTypeModel : TypeModel
{
	private sealed class BasicType
	{
		private readonly Type type; //Field offset: 0x10
		private readonly IProtoSerializer serializer; //Field offset: 0x18

		public IProtoSerializer Serializer
		{
			 get { } //Length: 5
		}

		public Type Type
		{
			 get { } //Length: 5
		}

		public BasicType(Type type, IProtoSerializer serializer) { }

		public IProtoSerializer get_Serializer() { }

		public Type get_Type() { }

	}

	private sealed class Singleton
	{
		internal static readonly RuntimeTypeModel Value; //Field offset: 0x2C927B4

		private static Singleton() { }

		private Singleton() { }

	}

	private const byte OPTIONS_InferTagFromNameDefault = 1; //Field offset: 0x0
	private const byte OPTIONS_IsDefaultModel = 2; //Field offset: 0x0
	private const byte OPTIONS_Frozen = 4; //Field offset: 0x0
	private const byte OPTIONS_AutoAddMissingTypes = 8; //Field offset: 0x0
	private const byte OPTIONS_UseImplicitZeroDefaults = 32; //Field offset: 0x0
	private const byte OPTIONS_AllowParseableTypes = 64; //Field offset: 0x0
	private const byte OPTIONS_AutoAddProtoContractTypesOnly = 128; //Field offset: 0x0
	private static readonly MatchPredicate MetaTypeFinder; //Field offset: 0x0
	private static readonly MatchPredicate BasicTypeFinder; //Field offset: 0x8
	private byte options; //Field offset: 0x18
	private BasicList basicTypes; //Field offset: 0x20
	private readonly BasicList types; //Field offset: 0x28
	private int metadataTimeoutMilliseconds; //Field offset: 0x30
	private int contentionCounter; //Field offset: 0x34
	[CompilerGenerated]
	private LockContentedEventHandler LockContended; //Field offset: 0x38
	private MethodInfo defaultFactory; //Field offset: 0x40

	public event LockContentedEventHandler LockContended
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool AllowParseableTypes
	{
		 get { } //Length: 10
		 set { } //Length: 33
	}

	public bool AutoAddMissingTypes
	{
		 get { } //Length: 10
		 set { } //Length: 223
	}

	public bool AutoAddProtoContractTypesOnly
	{
		 get { } //Length: 8
		 set { } //Length: 33
	}

	public static RuntimeTypeModel Default
	{
		 get { } //Length: 86
	}

	public bool InferTagFromNameDefault
	{
		 get { } //Length: 7
		 set { } //Length: 33
	}

	public MetaType Item
	{
		 get { } //Length: 211
	}

	public int MetadataTimeoutMilliseconds
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public bool UseImplicitZeroDefaults
	{
		 get { } //Length: 10
		 set { } //Length: 143
	}

	private static RuntimeTypeModel() { }

	internal RuntimeTypeModel(bool isDefault) { }

	public MetaType Add(Type type, bool applyDefaultBehaviour) { }

	[CompilerGenerated]
	public void add_LockContended(LockContentedEventHandler value) { }

	private void AddContention() { }

	private static bool BasicTypeFinderImpl(object value, object ctx) { }

	private void CascadeDependents(BasicList list, MetaType metaType) { }

	private MetaType Create(Type type) { }

	protected private virtual object Deserialize(int key, object value, ProtoReader source) { }

	internal int FindOrAddAuto(Type type, bool demand, bool addWithContractOnly, bool addEvenIfAutoDisabled) { }

	internal MetaType FindWithoutAdd(Type type) { }

	public void Freeze() { }

	public bool get_AllowParseableTypes() { }

	public bool get_AutoAddMissingTypes() { }

	public bool get_AutoAddProtoContractTypesOnly() { }

	public static RuntimeTypeModel get_Default() { }

	public bool get_InferTagFromNameDefault() { }

	public MetaType get_Item(Type type) { }

	public int get_MetadataTimeoutMilliseconds() { }

	public bool get_UseImplicitZeroDefaults() { }

	private int GetContention() { }

	internal EnumPair[] GetEnumMap(Type type) { }

	internal int GetKey(Type type, bool demand, bool getBaseKey) { }

	protected virtual int GetKeyImpl(Type type) { }

	private bool GetOption(byte option) { }

	public virtual string GetSchema(Type type) { }

	internal string GetSchemaTypeName(Type effectiveType, DataFormat dataFormat, bool asReference, bool dynamicType, ref bool requiresBclImport) { }

	public IEnumerable GetTypes() { }

	internal bool IsPrepared(Type type) { }

	private static bool MetaTypeFinderImpl(object value, object ctx) { }

	private MetaType RecogniseCommonTypes(Type type) { }

	internal void ReleaseLock(int opaqueToken) { }

	[CompilerGenerated]
	public void remove_LockContended(LockContentedEventHandler value) { }

	internal void ResolveListTypes(Type type, ref Type itemType, ref Type defaultType) { }

	protected private virtual void Serialize(int key, object value, ProtoWriter dest) { }

	public void set_AllowParseableTypes(bool value) { }

	public void set_AutoAddMissingTypes(bool value) { }

	public void set_AutoAddProtoContractTypesOnly(bool value) { }

	public void set_InferTagFromNameDefault(bool value) { }

	public void set_MetadataTimeoutMilliseconds(int value) { }

	public void set_UseImplicitZeroDefaults(bool value) { }

	public void SetDefaultFactory(MethodInfo methodInfo) { }

	private void SetOption(byte option, bool value) { }

	internal void TakeLock(ref int opaqueToken) { }

	private void ThrowIfFrozen() { }

	internal IProtoSerializer TryGetBasicTypeSerializer(Type type) { }

	internal void VerifyFactory(MethodInfo factory, Type type) { }

	private void WaitOnLock(MetaType type) { }

}

