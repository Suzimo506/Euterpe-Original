namespace System.Xml;

public abstract class XmlCharacterData : XmlLinkedNode
{
	private string data; //Field offset: 0x20

	public override string Data
	{
		 get { } //Length: 68
		 set { } //Length: 195
	}

	public virtual string InnerText
	{
		 get { } //Length: 17
		 set { } //Length: 17
	}

	public virtual string Value
	{
		 get { } //Length: 17
		 set { } //Length: 17
	}

	protected private XmlCharacterData(string data, XmlDocument doc) { }

	internal bool CheckOnData(string data) { }

	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }

	public override string get_Data() { }

	public virtual string get_InnerText() { }

	public virtual string get_Value() { }

	public override void set_Data(string value) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_Value(string value) { }

}

