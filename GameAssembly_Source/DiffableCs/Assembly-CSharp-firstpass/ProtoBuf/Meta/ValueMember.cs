namespace ProtoBuf.Meta;

public class ValueMember
{
	public sealed class Comparer : IComparer, IComparer<ValueMember>
	{
		public static readonly Comparer Default; //Field offset: 0x65187

		private static Comparer() { }

		public Comparer() { }

		public override int Compare(object x, object y) { }

		public override int Compare(ValueMember x, ValueMember y) { }

	}

	private const byte OPTIONS_SupportNull = 16; //Field offset: 0x0
	private const byte OPTIONS_OverwriteList = 8; //Field offset: 0x0
	private const byte OPTIONS_IsRequired = 4; //Field offset: 0x0
	private const byte OPTIONS_IsPacked = 2; //Field offset: 0x0
	private const byte OPTIONS_IsStrict = 1; //Field offset: 0x0
	private readonly int fieldNumber; //Field offset: 0x10
	private readonly MemberInfo member; //Field offset: 0x18
	private readonly Type parentType; //Field offset: 0x20
	private readonly Type itemType; //Field offset: 0x28
	private readonly Type defaultType; //Field offset: 0x30
	private readonly Type memberType; //Field offset: 0x38
	private object defaultValue; //Field offset: 0x40
	private readonly RuntimeTypeModel model; //Field offset: 0x48
	private IProtoSerializer serializer; //Field offset: 0x50
	private DataFormat dataFormat; //Field offset: 0x58
	private bool asReference; //Field offset: 0x5C
	private bool dynamicType; //Field offset: 0x5D
	private MethodInfo getSpecified; //Field offset: 0x60
	private MethodInfo setSpecified; //Field offset: 0x68
	private string name; //Field offset: 0x70
	private byte flags; //Field offset: 0x78

	public bool AsReference
	{
		 get { } //Length: 5
		 set { } //Length: 113
	}

	public DataFormat DataFormat
	{
		 get { } //Length: 4
		 set { } //Length: 111
	}

	public Type DefaultType
	{
		 get { } //Length: 5
	}

	public object DefaultValue
	{
		 get { } //Length: 5
		 set { } //Length: 123
	}

	public bool DynamicType
	{
		 get { } //Length: 5
		 set { } //Length: 113
	}

	public int FieldNumber
	{
		 get { } //Length: 4
	}

	public bool IsPacked
	{
		 get { } //Length: 9
		 set { } //Length: 82
	}

	public bool IsRequired
	{
		 get { } //Length: 10
		 set { } //Length: 83
	}

	public bool IsStrict
	{
		 get { } //Length: 7
		 set { } //Length: 80
	}

	public Type ItemType
	{
		 get { } //Length: 5
	}

	public MemberInfo Member
	{
		 get { } //Length: 5
	}

	public Type MemberType
	{
		 get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 144
	}

	public bool OverwriteList
	{
		 get { } //Length: 10
		 set { } //Length: 83
	}

	public Type ParentType
	{
		 get { } //Length: 5
	}

	internal IProtoSerializer Serializer
	{
		internal get { } //Length: 49
	}

	public bool SupportNull
	{
		 get { } //Length: 10
		 set { } //Length: 83
	}

	public ValueMember(RuntimeTypeModel model, Type parentType, int fieldNumber, MemberInfo member, Type memberType, Type itemType, Type defaultType, DataFormat dataFormat, object defaultValue) { }

	internal ValueMember(RuntimeTypeModel model, int fieldNumber, Type memberType, Type itemType, Type defaultType, DataFormat dataFormat) { }

	private IProtoSerializer BuildSerializer() { }

	public bool get_AsReference() { }

	public DataFormat get_DataFormat() { }

	public Type get_DefaultType() { }

	public object get_DefaultValue() { }

	public bool get_DynamicType() { }

	public int get_FieldNumber() { }

	public bool get_IsPacked() { }

	public bool get_IsRequired() { }

	public bool get_IsStrict() { }

	public Type get_ItemType() { }

	public MemberInfo get_Member() { }

	public Type get_MemberType() { }

	public string get_Name() { }

	public bool get_OverwriteList() { }

	public Type get_ParentType() { }

	internal IProtoSerializer get_Serializer() { }

	public bool get_SupportNull() { }

	private static WireType GetDateTimeWireType(DataFormat format) { }

	private static WireType GetIntWireType(DataFormat format, int width) { }

	internal object GetRawEnumValue() { }

	internal string GetSchemaTypeName(bool applyNetObjectProxy, ref bool requiresBclImport) { }

	private bool HasFlag(byte flag) { }

	private static object ParseDefaultValue(Type type, object value) { }

	public void set_AsReference(bool value) { }

	public void set_DataFormat(DataFormat value) { }

	public void set_DefaultValue(object value) { }

	public void set_DynamicType(bool value) { }

	public void set_IsPacked(bool value) { }

	public void set_IsRequired(bool value) { }

	public void set_IsStrict(bool value) { }

	public void set_OverwriteList(bool value) { }

	public void set_SupportNull(bool value) { }

	private void SetFlag(byte flag, bool value, bool throwIfFrozen) { }

	internal void SetName(string name) { }

	public void SetSpecified(MethodInfo getSpecified, MethodInfo setSpecified) { }

	private void ThrowIfFrozen() { }

	internal static IProtoSerializer TryGetCoreSerializer(RuntimeTypeModel model, DataFormat dataFormat, Type type, out WireType defaultWireType, bool asReference, bool dynamicType, bool overwriteList, bool allowComplexTypes) { }

}

