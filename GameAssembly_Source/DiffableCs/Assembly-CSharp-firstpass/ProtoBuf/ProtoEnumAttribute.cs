namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProtoEnumAttribute : Attribute
{
	private bool hasValue; //Field offset: 0x10
	private int enumValue; //Field offset: 0x14
	private string name; //Field offset: 0x18

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int Value
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public ProtoEnumAttribute() { }

	public string get_Name() { }

	public int get_Value() { }

	public bool HasValue() { }

	public void set_Name(string value) { }

	public void set_Value(int value) { }

}

