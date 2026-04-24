namespace NCalc.Domain;

public class SerializationVisitor : LogicalExpressionVisitor
{
	private readonly NumberFormatInfo _numberFormatInfo; //Field offset: 0x10
	[CompilerGenerated]
	private StringBuilder <Result>k__BackingField; //Field offset: 0x18

	public StringBuilder Result
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public SerializationVisitor() { }

	protected void EncapsulateNoValue(LogicalExpression expression) { }

	[CompilerGenerated]
	public StringBuilder get_Result() { }

	[CompilerGenerated]
	protected void set_Result(StringBuilder value) { }

	public virtual void Visit(LogicalExpression expression) { }

	public virtual void Visit(TernaryExpression expression) { }

	public virtual void Visit(BinaryExpression expression) { }

	public virtual void Visit(UnaryExpression expression) { }

	public virtual void Visit(ValueExpression expression) { }

	public virtual void Visit(Function function) { }

	public virtual void Visit(Identifier parameter) { }

}

