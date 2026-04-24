namespace System.Xml.XPath;

public class XPathDocument
{
	private XPathNode[] pageText; //Field offset: 0x10
	private XPathNode[] pageRoot; //Field offset: 0x18
	private XPathNode[] pageXmlNmsp; //Field offset: 0x20
	private int idxText; //Field offset: 0x28
	private int idxRoot; //Field offset: 0x2C
	private int idxXmlNmsp; //Field offset: 0x30
	private XmlNameTable nameTable; //Field offset: 0x38
	private bool hasLineInfo; //Field offset: 0x40
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x48
	private Dictionary<String, XPathNodeRef> idValueMap; //Field offset: 0x50

	internal bool HasLineInfo
	{
		internal get { } //Length: 5
	}

	internal XmlNameTable NameTable
	{
		internal get { } //Length: 5
	}

	internal bool get_HasLineInfo() { }

	internal XmlNameTable get_NameTable() { }

	internal int GetCollapsedTextNode(out XPathNode[] pageText) { }

	internal int GetRootNode(out XPathNode[] pageRoot) { }

	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	internal int LookupIdElement(string id, out XPathNode[] pageElem) { }

	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

