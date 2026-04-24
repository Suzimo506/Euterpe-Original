namespace MS.Internal.Xml.XPath;

internal sealed class ClonableStack : List<T>
{

	public ClonableStack`1() { }

	private ClonableStack`1(IEnumerable<T> collection) { }

	public ClonableStack<T> Clone() { }

	public T Peek() { }

	public T Pop() { }

	public void Push(T value) { }

}

