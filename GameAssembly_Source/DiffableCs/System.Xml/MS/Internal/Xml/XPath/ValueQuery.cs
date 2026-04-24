namespace MS.Internal.Xml.XPath;

internal abstract class ValueQuery : Query
{

	public virtual int Count
	{
		 get { } //Length: 60
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 60
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 60
	}

	public ValueQuery() { }

	protected ValueQuery(ValueQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual void Reset() { }

}

