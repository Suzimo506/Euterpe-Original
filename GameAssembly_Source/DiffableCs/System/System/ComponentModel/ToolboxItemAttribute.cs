namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ToolboxItemAttribute : Attribute
{
	public static readonly ToolboxItemAttribute Default; //Field offset: 0x0
	public static readonly ToolboxItemAttribute None; //Field offset: 0x8
	private string toolboxItemTypeName; //Field offset: 0x10

	public string ToolboxItemTypeName
	{
		 get { } //Length: 68
	}

	private static ToolboxItemAttribute() { }

	public ToolboxItemAttribute(bool defaultType) { }

	public ToolboxItemAttribute(string toolboxItemTypeName) { }

	public virtual bool Equals(object obj) { }

	public string get_ToolboxItemTypeName() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

