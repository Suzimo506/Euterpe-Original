namespace NCalc;

internal class LambdaExpressionVistor : LogicalExpressionVisitor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string methodName; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <FindMethod>b__0(MethodInfo m) { }

	}

	private readonly IDictionary<String, Object> _parameters; //Field offset: 0x10
	private Expression _result; //Field offset: 0x18
	private readonly Expression _context; //Field offset: 0x20
	private readonly EvaluateOptions _options; //Field offset: 0x28

	private bool Checked
	{
		private get { } //Length: 9
	}

	private bool IgnoreCaseString
	{
		private get { } //Length: 9
	}

	private bool Ordinal
	{
		private get { } //Length: 9
	}

	public Expression Result
	{
		 get { } //Length: 5
	}

	public LambdaExpressionVistor(IDictionary<String, Object> parameters, EvaluateOptions options) { }

	public LambdaExpressionVistor(ParameterExpression context, EvaluateOptions options) { }

	private ExtendedMethodInfo FindMethod(string methodName, Expression[] methodArgs) { }

	private bool get_Checked() { }

	private bool get_IgnoreCaseString() { }

	private bool get_Ordinal() { }

	public Expression get_Result() { }

	private Expression[] PrepareMethodArgumentsIfValid(ParameterInfo[] parameters, Expression[] arguments) { }

	private Expression UnwrapNullable(Expression expression) { }

	public virtual void Visit(UnaryExpression expression) { }

	public virtual void Visit(ValueExpression expression) { }

	public virtual void Visit(Function function) { }

	public virtual void Visit(Identifier function) { }

	public virtual void Visit(TernaryExpression expression) { }

	public virtual void Visit(LogicalExpression expression) { }

	public virtual void Visit(BinaryExpression expression) { }

	private Expression WithCommonNumericType(Expression left, Expression right, Func<Expression, Expression, Expression> action, BinaryExpressionType expressiontype = 18) { }

}

