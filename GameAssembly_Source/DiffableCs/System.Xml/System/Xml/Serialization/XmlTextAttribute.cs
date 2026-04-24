namespace System.Xml.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class XmlTextAttribute : Attribute
{
	private string dataType; //Field offset: 0x10
	private Type type; //Field offset: 0x18

	public string DataType
	{
		 get { } //Length: 68
	}

	public Type Type
	{
		 get { } //Length: 5
	}

	public XmlTextAttribute() { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public Type get_Type() { }

}

