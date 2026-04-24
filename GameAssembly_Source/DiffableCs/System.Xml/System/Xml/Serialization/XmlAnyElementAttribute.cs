namespace System.Xml.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class XmlAnyElementAttribute : Attribute
{
	private string elementName; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private int order; //Field offset: 0x20

	public string Name
	{
		 get { } //Length: 68
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public int Order
	{
		 get { } //Length: 4
	}

	public XmlAnyElementAttribute() { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_Name() { }

	public string get_Namespace() { }

	public int get_Order() { }

}

