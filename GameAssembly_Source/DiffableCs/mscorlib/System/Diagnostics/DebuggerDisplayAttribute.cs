namespace System.Diagnostics;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name; //Field offset: 0x10
	private string value; //Field offset: 0x18
	private string type; //Field offset: 0x20

	public string Name
	{
		 set { } //Length: 12
	}

	public string Type
	{
		 set { } //Length: 12
	}

	public DebuggerDisplayAttribute(string value) { }

	public void set_Name(string value) { }

	public void set_Type(string value) { }

}

