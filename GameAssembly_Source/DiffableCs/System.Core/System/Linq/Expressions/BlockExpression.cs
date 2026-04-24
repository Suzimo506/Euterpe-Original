namespace System.Linq.Expressions;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BlockExpression : Expression
{

	[ExcludeFromCodeCoverage]
	internal override int ExpressionCount
	{
		internal get { } //Length: 53
	}

	public ReadOnlyCollection<Expression> Expressions
	{
		 get { } //Length: 17
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public Expression Result
	{
		 get { } //Length: 53
	}

	public virtual Type Type
	{
		 get { } //Length: 83
	}

	public ReadOnlyCollection<ParameterExpression> Variables
	{
		 get { } //Length: 17
	}

	internal BlockExpression() { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	internal override int get_ExpressionCount() { }

	public ReadOnlyCollection<Expression> get_Expressions() { }

	public virtual ExpressionType get_NodeType() { }

	public Expression get_Result() { }

	public virtual Type get_Type() { }

	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	[ExcludeFromCodeCoverage]
	internal override Expression GetExpression(int index) { }

	[ExcludeFromCodeCoverage]
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }

	[ExcludeFromCodeCoverage]
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

