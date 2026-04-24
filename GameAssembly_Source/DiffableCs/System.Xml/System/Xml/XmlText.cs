namespace System.Xml;

public class XmlText : XmlCharacterData
{

	internal virtual bool IsText
	{
		internal get { } //Length: 3
	}

	public virtual string LocalName
	{
		 get { } //Length: 42
	}

	public virtual string Name
	{
		 get { } //Length: 42
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual XmlNode ParentNode
	{
		 get { } //Length: 144
	}

	public virtual XmlNode PreviousText
	{
		 get { } //Length: 61
	}

	public virtual string Value
	{
		 get { } //Length: 17
		 set { } //Length: 194
	}

	internal virtual XPathNodeType XPNodeType
	{
		internal get { } //Length: 6
	}

	internal XmlText(string strData) { }

	protected private XmlText(string strData, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	internal virtual bool get_IsText() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual XmlNode get_ParentNode() { }

	public virtual XmlNode get_PreviousText() { }

	public virtual string get_Value() { }

	internal virtual XPathNodeType get_XPNodeType() { }

	public virtual void set_Value(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

