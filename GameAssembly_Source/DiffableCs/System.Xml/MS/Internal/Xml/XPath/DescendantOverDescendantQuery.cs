namespace MS.Internal.Xml.XPath;

internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery
{
	private int level; //Field offset: 0x60

	public DescendantOverDescendantQuery(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	private DescendantOverDescendantQuery(DescendantOverDescendantQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	private bool MoveToFirstChild() { }

	private bool MoveUpUntillNext() { }

	public virtual void Reset() { }

}

