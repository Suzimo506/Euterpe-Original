namespace System.Xml;

internal class XPathNodeList : XmlNodeList
{
	private static readonly Object[] nullparams; //Field offset: 0x0
	private List<XmlNode> list; //Field offset: 0x10
	private XPathNodeIterator nodeIterator; //Field offset: 0x18
	private bool done; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 81
	}

	private static XPathNodeList() { }

	public XPathNodeList(XPathNodeIterator nodeIterator) { }

	public virtual int get_Count() { }

	public virtual IEnumerator GetEnumerator() { }

	private XmlNode GetNode(XPathNavigator n) { }

	public virtual XmlNode Item(int index) { }

	internal int ReadUntil(int index) { }

}

