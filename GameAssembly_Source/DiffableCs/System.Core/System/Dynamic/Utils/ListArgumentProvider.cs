namespace System.Dynamic.Utils;

internal sealed class ListArgumentProvider : ListProvider<Expression>
{
	private readonly IArgumentProvider _provider; //Field offset: 0x10
	private readonly Expression _arg0; //Field offset: 0x18

	protected virtual int ElementCount
	{
		 get { } //Length: 72
	}

	protected virtual Expression First
	{
		 get { } //Length: 5
	}

	internal ListArgumentProvider(IArgumentProvider provider, Expression arg0) { }

	protected virtual int get_ElementCount() { }

	protected virtual Expression get_First() { }

	protected virtual Expression GetElement(int index) { }

}

