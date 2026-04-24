namespace MS.Internal.Xml.XPath;

internal class Operator : AstNode
{
	internal enum Op
	{
		INVALID = 0,
		OR = 1,
		AND = 2,
		EQ = 3,
		NE = 4,
		LT = 5,
		LE = 6,
		GT = 7,
		GE = 8,
		PLUS = 9,
		MINUS = 10,
		MUL = 11,
		DIV = 12,
		MOD = 13,
		UNION = 14,
	}

	private static Op[] invertOp; //Field offset: 0x0
	private Op opType; //Field offset: 0x10
	private AstNode opnd1; //Field offset: 0x18
	private AstNode opnd2; //Field offset: 0x20

	public AstNode Operand1
	{
		 get { } //Length: 5
	}

	public AstNode Operand2
	{
		 get { } //Length: 5
	}

	public Op OperatorType
	{
		 get { } //Length: 4
	}

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 28
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	private static Operator() { }

	public Operator(Op op, AstNode opnd1, AstNode opnd2) { }

	public AstNode get_Operand1() { }

	public AstNode get_Operand2() { }

	public Op get_OperatorType() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

	public static Op InvertOperator(Op op) { }

}

