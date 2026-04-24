namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct InstructionArray
{
	public sealed class DebugView
	{
		private readonly InstructionArray _array; //Field offset: 0x10

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public InstructionView[] A0
		{
			 get { } //Length: 188
		}

		public DebugView(InstructionArray array) { }

		[CompilerGenerated]
		private int <GetInstructionViews>b__4_0(int index) { }

		public InstructionView[] get_A0() { }

		public InstructionView[] GetInstructionViews(bool includeDebugCookies = false) { }

	}

	internal readonly int MaxStackDepth; //Field offset: 0x0
	internal readonly int MaxContinuationDepth; //Field offset: 0x4
	internal readonly Instruction[] Instructions; //Field offset: 0x8
	internal readonly Object[] Objects; //Field offset: 0x10
	internal readonly RuntimeLabel[] Labels; //Field offset: 0x18
	internal readonly List<KeyValuePair`2<Int32, Object>> DebugCookies; //Field offset: 0x20

	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, Object[] objects, RuntimeLabel[] labels, List<KeyValuePair`2<Int32, Object>> debugCookies) { }

}

