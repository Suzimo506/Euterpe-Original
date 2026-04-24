namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProtoIncludeAttribute : Attribute
{
	private readonly int tag; //Field offset: 0x10
	private readonly string knownTypeName; //Field offset: 0x18
	private DataFormat dataFormat; //Field offset: 0x20

	[DefaultValue(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public DataFormat DataFormat
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Type KnownType
	{
		 get { } //Length: 91
	}

	public string KnownTypeName
	{
		 get { } //Length: 5
	}

	public int Tag
	{
		 get { } //Length: 4
	}

	public ProtoIncludeAttribute(int tag, Type knownType) { }

	public ProtoIncludeAttribute(int tag, string knownTypeName) { }

	public DataFormat get_DataFormat() { }

	public Type get_KnownType() { }

	public string get_KnownTypeName() { }

	public int get_Tag() { }

	public void set_DataFormat(DataFormat value) { }

}

