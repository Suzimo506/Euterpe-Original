namespace System.Linq.Expressions;

internal class AssignBinaryExpression : BinaryExpression
{

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 39
	}

	internal AssignBinaryExpression(Expression left, Expression right) { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

}

