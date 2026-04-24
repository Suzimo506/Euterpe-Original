namespace System.Linq.Expressions;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConditionalExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; //Field offset: 0x18

	public Expression IfFalse
	{
		 get { } //Length: 17
	}

	public Expression IfTrue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public Expression Test
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		 get { } //Length: 39
	}

	internal ConditionalExpression(Expression test, Expression ifTrue) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public Expression get_IfFalse() { }

	[CompilerGenerated]
	public Expression get_IfTrue() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public Expression get_Test() { }

	public virtual Type get_Type() { }

	internal override Expression GetFalse() { }

	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }

}

