namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
{
	private readonly bool _hasFinally; //Field offset: 0x18
	private TryCatchFinallyHandler _tryHandler; //Field offset: 0x20

	public virtual string InstructionName
	{
		 get { } //Length: 61
	}

	public virtual int ProducedContinuations
	{
		 get { } //Length: 9
	}

	private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally) { }

	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedContinuations() { }

	public virtual int Run(InterpretedFrame frame) { }

	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	public virtual string ToString() { }

}

