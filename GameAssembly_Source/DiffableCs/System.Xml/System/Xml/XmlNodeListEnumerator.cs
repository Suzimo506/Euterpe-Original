namespace System.Xml;

internal class XmlNodeListEnumerator : IEnumerator
{
	private XPathNodeList list; //Field offset: 0x10
	private int index; //Field offset: 0x18
	private bool valid; //Field offset: 0x1C

	public override object Current
	{
		 get { } //Length: 58
	}

	public XmlNodeListEnumerator(XPathNodeList list) { }

	public override object get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

