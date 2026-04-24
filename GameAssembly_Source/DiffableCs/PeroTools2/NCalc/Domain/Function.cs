namespace NCalc.Domain;

public class Function : LogicalExpression
{
	[CompilerGenerated]
	private Identifier <Identifier>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private LogicalExpression[] <Expressions>k__BackingField; //Field offset: 0x18

	public LogicalExpression[] Expressions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Identifier Identifier
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Function(Identifier identifier, LogicalExpression[] expressions) { }

	public virtual void Accept(LogicalExpressionVisitor visitor) { }

	[CompilerGenerated]
	public LogicalExpression[] get_Expressions() { }

	[CompilerGenerated]
	public Identifier get_Identifier() { }

	[CompilerGenerated]
	public void set_Expressions(LogicalExpression[] value) { }

	[CompilerGenerated]
	public void set_Identifier(Identifier value) { }

}

