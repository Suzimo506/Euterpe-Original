namespace MS.Internal.Xml.XPath;

internal abstract class ResetableIterator : XPathNodeIterator
{

	public abstract int CurrentPosition
	{
		 get { } //Length: 0
	}

	public ResetableIterator() { }

	protected ResetableIterator(ResetableIterator other) { }

	public abstract int get_CurrentPosition() { }

	public abstract void Reset() { }

	protected void ResetCount() { }

}

