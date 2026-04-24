namespace System.Linq.Expressions.Interpreter;

internal sealed class ArrayLengthInstruction : Instruction
{
	public static readonly ArrayLengthInstruction Instance; //Field offset: 0x2C927BC

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

	private static ArrayLengthInstruction() { }

	private ArrayLengthInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

