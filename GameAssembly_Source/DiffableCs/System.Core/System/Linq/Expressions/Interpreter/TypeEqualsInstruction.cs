namespace System.Linq.Expressions.Interpreter;

internal sealed class TypeEqualsInstruction : Instruction
{
	public static readonly TypeEqualsInstruction Instance; //Field offset: 0x6ABD6

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 43
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	private static TypeEqualsInstruction() { }

	private TypeEqualsInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

