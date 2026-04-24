namespace MS.Internal.Xml.XPath;

internal sealed class ReversePositionQuery : ForwardPositionQuery
{

	public virtual int CurrentPosition
	{
		 get { } //Length: 64
	}

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public ReversePositionQuery(Query input) { }

	private ReversePositionQuery(ReversePositionQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_CurrentPosition() { }

	public virtual QueryProps get_Properties() { }

}

