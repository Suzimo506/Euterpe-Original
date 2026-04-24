namespace System.Dynamic.Utils;

internal sealed class ListParameterProvider : ListProvider<ParameterExpression>
{
	private readonly IParameterProvider _provider; //Field offset: 0x10
	private readonly ParameterExpression _arg0; //Field offset: 0x18

	protected virtual int ElementCount
	{
		 get { } //Length: 72
	}

	protected virtual ParameterExpression First
	{
		 get { } //Length: 5
	}

	internal ListParameterProvider(IParameterProvider provider, ParameterExpression arg0) { }

	protected virtual int get_ElementCount() { }

	protected virtual ParameterExpression get_First() { }

	protected virtual ParameterExpression GetElement(int index) { }

}

