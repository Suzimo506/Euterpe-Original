namespace System.Linq.Expressions.Interpreter;

internal sealed class PopInstruction : Instruction
{
	internal static readonly PopInstruction Instance; //Field offset: 0x2C927B4

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 43
	}

	private static PopInstruction() { }

	private PopInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

