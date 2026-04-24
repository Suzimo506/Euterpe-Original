namespace System.Xml.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class XmlTypeAttribute : Attribute
{
	private bool includeInSchema; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private string typeName; //Field offset: 0x20

	public bool IncludeInSchema
	{
		 get { } //Length: 5
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public string TypeName
	{
		 get { } //Length: 68
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public bool get_IncludeInSchema() { }

	public string get_Namespace() { }

	public string get_TypeName() { }

}

