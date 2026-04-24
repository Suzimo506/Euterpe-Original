namespace System.Xml.XPath;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class XPathNodeIterator : ICloneable, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private XPathNodeIterator original; //Field offset: 0x10
		private XPathNodeIterator current; //Field offset: 0x18
		private bool iterationStarted; //Field offset: 0x20

		public override object Current
		{
			 get { } //Length: 402
		}

		public Enumerator(XPathNodeIterator original) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	internal int count; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 106
	}

	public abstract XPathNavigator Current
	{
		 get { } //Length: 0
	}

	public abstract int CurrentPosition
	{
		 get { } //Length: 0
	}

	private object debuggerDisplayProxy
	{
		private get { } //Length: 136
	}

	protected XPathNodeIterator() { }

	public abstract XPathNodeIterator Clone() { }

	public override int get_Count() { }

	public abstract XPathNavigator get_Current() { }

	public abstract int get_CurrentPosition() { }

	private object get_debuggerDisplayProxy() { }

	public override IEnumerator GetEnumerator() { }

	public abstract bool MoveNext() { }

	private override object System.ICloneable.Clone() { }

}

