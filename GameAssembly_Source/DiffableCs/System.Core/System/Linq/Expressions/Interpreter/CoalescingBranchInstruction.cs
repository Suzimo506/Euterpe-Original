namespace System.Linq.Expressions.Interpreter;

internal sealed class CoalescingBranchInstruction : OffsetInstruction
{
	private static Instruction[] s_cache; //Field offset: 0x2C927B4

	public virtual Instruction[] Cache
	{
		 get { } //Length: 115
	}

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

	public CoalescingBranchInstruction() { }

	public virtual Instruction[] get_Cache() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

