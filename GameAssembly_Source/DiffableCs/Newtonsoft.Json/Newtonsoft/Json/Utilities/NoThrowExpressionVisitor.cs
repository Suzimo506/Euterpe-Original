namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class NoThrowExpressionVisitor : ExpressionVisitor
{
	internal static readonly object ErrorResult; //Field offset: 0x68160

	private static NoThrowExpressionVisitor() { }

	public NoThrowExpressionVisitor() { }

	protected virtual Expression VisitConditional(ConditionalExpression node) { }

}

