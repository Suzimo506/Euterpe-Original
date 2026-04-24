namespace MS.Internal.Xml.XPath;

internal abstract class XPathAxisIterator : XPathNodeIterator
{
	internal XPathNavigator nav; //Field offset: 0x18
	internal XPathNodeType type; //Field offset: 0x20
	internal string name; //Field offset: 0x28
	internal string uri; //Field offset: 0x30
	internal int position; //Field offset: 0x38
	internal bool matchSelf; //Field offset: 0x3C
	internal bool first; //Field offset: 0x3D

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	protected override bool Matches
	{
		 get { } //Length: 337
	}

	public XPathAxisIterator(XPathNavigator nav, bool matchSelf) { }

	public XPathAxisIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	public XPathAxisIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	public XPathAxisIterator(XPathAxisIterator it) { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	protected override bool get_Matches() { }

}

