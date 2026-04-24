namespace System.Xml.Schema;

public class XmlSchemaAnnotation : XmlSchemaObject
{
	private string id; //Field offset: 0x38
	private XmlSchemaObjectCollection items; //Field offset: 0x40
	private XmlAttribute[] moreAttributes; //Field offset: 0x48

	[XmlAttribute(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string Id
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	[XmlElement(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[XmlElement(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 5
	}

	public XmlSchemaAnnotation() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	public XmlSchemaObjectCollection get_Items() { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

