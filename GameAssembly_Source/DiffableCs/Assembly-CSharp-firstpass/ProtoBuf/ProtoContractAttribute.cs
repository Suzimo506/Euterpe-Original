namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProtoContractAttribute : Attribute
{
	private const byte OPTIONS_InferTagFromName = 1; //Field offset: 0x0
	private const byte OPTIONS_InferTagFromNameHasValue = 2; //Field offset: 0x0
	private const byte OPTIONS_UseProtoMembersOnly = 4; //Field offset: 0x0
	private const byte OPTIONS_SkipConstructor = 8; //Field offset: 0x0
	private const byte OPTIONS_IgnoreListHandling = 16; //Field offset: 0x0
	private const byte OPTIONS_AsReferenceDefault = 32; //Field offset: 0x0
	private const byte OPTIONS_EnumPassthru = 64; //Field offset: 0x0
	private const byte OPTIONS_EnumPassthruHasValue = 128; //Field offset: 0x0
	private string name; //Field offset: 0x10
	private int implicitFirstTag; //Field offset: 0x18
	private ImplicitFields implicitFields; //Field offset: 0x1C
	private int dataMemberOffset; //Field offset: 0x20
	private byte flags; //Field offset: 0x24

	public bool AsReferenceDefault
	{
		 get { } //Length: 10
		 set { } //Length: 33
	}

	public int DataMemberOffset
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool EnumPassthru
	{
		 get { } //Length: 10
		 set { } //Length: 37
	}

	internal bool EnumPassthruHasValue
	{
		internal get { } //Length: 8
	}

	public bool IgnoreListHandling
	{
		 get { } //Length: 10
		 set { } //Length: 33
	}

	public ImplicitFields ImplicitFields
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int ImplicitFirstTag
	{
		 get { } //Length: 4
		 set { } //Length: 109
	}

	public bool InferTagFromName
	{
		 get { } //Length: 7
		 set { } //Length: 37
	}

	internal bool InferTagFromNameHasValue
	{
		internal get { } //Length: 9
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool SkipConstructor
	{
		 get { } //Length: 10
		 set { } //Length: 33
	}

	public bool UseProtoMembersOnly
	{
		 get { } //Length: 10
		 set { } //Length: 33
	}

	public ProtoContractAttribute() { }

	public bool get_AsReferenceDefault() { }

	public int get_DataMemberOffset() { }

	public bool get_EnumPassthru() { }

	internal bool get_EnumPassthruHasValue() { }

	public bool get_IgnoreListHandling() { }

	public ImplicitFields get_ImplicitFields() { }

	public int get_ImplicitFirstTag() { }

	public bool get_InferTagFromName() { }

	internal bool get_InferTagFromNameHasValue() { }

	public string get_Name() { }

	public bool get_SkipConstructor() { }

	public bool get_UseProtoMembersOnly() { }

	private bool HasFlag(byte flag) { }

	public void set_AsReferenceDefault(bool value) { }

	public void set_DataMemberOffset(int value) { }

	public void set_EnumPassthru(bool value) { }

	public void set_IgnoreListHandling(bool value) { }

	public void set_ImplicitFields(ImplicitFields value) { }

	public void set_ImplicitFirstTag(int value) { }

	public void set_InferTagFromName(bool value) { }

	public void set_Name(string value) { }

	public void set_SkipConstructor(bool value) { }

	public void set_UseProtoMembersOnly(bool value) { }

	private void SetFlag(byte flag, bool value) { }

}

