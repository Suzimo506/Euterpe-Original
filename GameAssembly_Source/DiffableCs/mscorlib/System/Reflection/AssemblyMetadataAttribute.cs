namespace System.Reflection;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class AssemblyMetadataAttribute : Attribute
{
	private string m_key; //Field offset: 0x10
	private string m_value; //Field offset: 0x18

	public AssemblyMetadataAttribute(string key, string value) { }

}

