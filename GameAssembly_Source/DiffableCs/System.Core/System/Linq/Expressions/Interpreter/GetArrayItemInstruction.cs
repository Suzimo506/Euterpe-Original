namespace System.Linq.Expressions.Interpreter;

internal sealed class GetArrayItemInstruction : Instruction
{
	internal static readonly GetArrayItemInstruction Instance; //Field offset: 0x6A9F0

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

	private static GetArrayItemInstruction() { }

	private GetArrayItemInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

