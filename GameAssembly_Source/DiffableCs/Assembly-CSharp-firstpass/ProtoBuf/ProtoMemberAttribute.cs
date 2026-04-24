namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoMemberAttribute>
{
	internal MemberInfo Member; //Field offset: 0x10
	internal bool TagIsPinned; //Field offset: 0x18
	private string name; //Field offset: 0x20
	private DataFormat dataFormat; //Field offset: 0x28
	private int tag; //Field offset: 0x2C
	private MemberSerializationOptions options; //Field offset: 0x30

	public bool AsReference
	{
		 get { } //Length: 9
		 set { } //Length: 29
	}

	internal bool AsReferenceHasValue
	{
		internal get { } //Length: 9
		internal set { } //Length: 25
	}

	public DataFormat DataFormat
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool DynamicType
	{
		 get { } //Length: 9
		 set { } //Length: 25
	}

	public bool IsPacked
	{
		 get { } //Length: 7
		 set { } //Length: 25
	}

	public bool IsRequired
	{
		 get { } //Length: 8
		 set { } //Length: 25
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public MemberSerializationOptions Options
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool OverwriteList
	{
		 get { } //Length: 9
		 set { } //Length: 25
	}

	public int Tag
	{
		 get { } //Length: 4
	}

	public ProtoMemberAttribute(int tag) { }

	internal ProtoMemberAttribute(int tag, bool forced) { }

	public override int CompareTo(object other) { }

	public override int CompareTo(ProtoMemberAttribute other) { }

	public bool get_AsReference() { }

	internal bool get_AsReferenceHasValue() { }

	public DataFormat get_DataFormat() { }

	public bool get_DynamicType() { }

	public bool get_IsPacked() { }

	public bool get_IsRequired() { }

	public string get_Name() { }

	public MemberSerializationOptions get_Options() { }

	public bool get_OverwriteList() { }

	public int get_Tag() { }

	internal void Rebase(int tag) { }

	public void set_AsReference(bool value) { }

	internal void set_AsReferenceHasValue(bool value) { }

	public void set_DataFormat(DataFormat value) { }

	public void set_DynamicType(bool value) { }

	public void set_IsPacked(bool value) { }

	public void set_IsRequired(bool value) { }

	public void set_Name(string value) { }

	public void set_Options(MemberSerializationOptions value) { }

	public void set_OverwriteList(bool value) { }

}

