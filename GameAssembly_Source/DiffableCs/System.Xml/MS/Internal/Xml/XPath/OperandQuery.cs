namespace MS.Internal.Xml.XPath;

internal sealed class OperandQuery : ValueQuery
{
	internal object val; //Field offset: 0x18

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 12
	}

	public OperandQuery(object val) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

}

