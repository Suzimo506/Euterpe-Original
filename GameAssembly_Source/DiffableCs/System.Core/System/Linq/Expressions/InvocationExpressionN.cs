namespace System.Linq.Expressions;

internal sealed class InvocationExpressionN : InvocationExpression
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 171
	}

	public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

