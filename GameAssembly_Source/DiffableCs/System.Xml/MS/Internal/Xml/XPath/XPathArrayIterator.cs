namespace MS.Internal.Xml.XPath;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XPathArrayIterator : ResetableIterator
{
	protected IList list; //Field offset: 0x18
	protected int index; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 72
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 424
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	private object debuggerDisplayProxy
	{
		private get { } //Length: 120
	}

	public XPathArrayIterator(XPathArrayIterator it) { }

	public XPathArrayIterator(XPathNodeIterator nodeIterator) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	private object get_debuggerDisplayProxy() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual bool MoveNext() { }

	public virtual void Reset() { }

}

