namespace System.Linq.Expressions.Interpreter;

internal sealed class SetArrayItemInstruction : Instruction
{
	internal static readonly SetArrayItemInstruction Instance; //Field offset: 0x6AA4E

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 43
	}

	private static SetArrayItemInstruction() { }

	private SetArrayItemInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

