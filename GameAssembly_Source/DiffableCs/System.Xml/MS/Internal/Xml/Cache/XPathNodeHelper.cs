namespace MS.Internal.Xml.Cache;

internal abstract class XPathNodeHelper
{

	public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	private static void GetChild(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

}

