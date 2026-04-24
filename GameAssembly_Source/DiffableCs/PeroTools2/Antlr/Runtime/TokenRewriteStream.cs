namespace Antlr.Runtime;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TokenRewriteStream : CommonTokenStream
{
	private class InsertBeforeOp : RewriteOperation
	{

		public InsertBeforeOp(TokenRewriteStream stream, int index, object text) { }

		public virtual int Execute(StringBuilder buf) { }

	}

	private class ReplaceOp : RewriteOperation
	{
		public int lastIndex; //Field offset: 0x28

		public ReplaceOp(TokenRewriteStream stream, int from, int to, object text) { }

		public virtual int Execute(StringBuilder buf) { }

		public virtual string ToString() { }

	}

	internal class RewriteOperation
	{
		public int instructionIndex; //Field offset: 0x10
		public int index; //Field offset: 0x14
		public object text; //Field offset: 0x18
		protected TokenRewriteStream stream; //Field offset: 0x20

		protected RewriteOperation(TokenRewriteStream stream, int index) { }

		protected RewriteOperation(TokenRewriteStream stream, int index, object text) { }

		public override int Execute(StringBuilder buf) { }

		public virtual string ToString() { }

	}

	public const string DEFAULT_PROGRAM_NAME = "default"; //Field offset: 0x0
	public const int PROGRAM_INIT_SIZE = 100; //Field offset: 0x0
	public const int MIN_TOKEN_INDEX = 0; //Field offset: 0x0
	protected IDictionary<String, IList`1<RewriteOperation>> programs; //Field offset: 0x38
	protected IDictionary<String, Int32> lastRewriteTokenIndexes; //Field offset: 0x40

	public TokenRewriteStream() { }

	public TokenRewriteStream(ITokenSource tokenSource) { }

	public TokenRewriteStream(ITokenSource tokenSource, int channel) { }

	protected override string CatOpText(object a, object b) { }

	public override void Delete(string programName, IToken from, IToken to) { }

	public override void Delete(string programName, int from, int to) { }

	public override void Delete(IToken from, IToken to) { }

	public override void Delete(IToken indexT) { }

	public override void Delete(int from, int to) { }

	public override void Delete(int index) { }

	public override void DeleteProgram(string programName) { }

	public override void DeleteProgram() { }

	protected override IList<RewriteOperation> GetKindOfOps(IList<RewriteOperation> rewrites, Type kind) { }

	protected override IList<RewriteOperation> GetKindOfOps(IList<RewriteOperation> rewrites, Type kind, int before) { }

	public override int GetLastRewriteTokenIndex() { }

	protected override int GetLastRewriteTokenIndex(string programName) { }

	protected override IList<RewriteOperation> GetProgram(string name) { }

	protected void Init() { }

	private IList<RewriteOperation> InitializeProgram(string name) { }

	public override void InsertAfter(int index, object text) { }

	public override void InsertAfter(IToken t, object text) { }

	public override void InsertAfter(string programName, int index, object text) { }

	public override void InsertAfter(string programName, IToken t, object text) { }

	public override void InsertBefore(string programName, IToken t, object text) { }

	public override void InsertBefore(int index, object text) { }

	public override void InsertBefore(IToken t, object text) { }

	public override void InsertBefore(string programName, int index, object text) { }

	protected override IDictionary<Int32, RewriteOperation> ReduceToSingleOperationPerIndex(IList<RewriteOperation> rewrites) { }

	public override void Replace(IToken from, IToken to, object text) { }

	public override void Replace(IToken indexT, object text) { }

	public override void Replace(int from, int to, object text) { }

	public override void Replace(int index, object text) { }

	public override void Replace(string programName, int from, int to, object text) { }

	public override void Replace(string programName, IToken from, IToken to, object text) { }

	public override void Rollback(int instructionIndex) { }

	public override void Rollback(string programName, int instructionIndex) { }

	protected override void SetLastRewriteTokenIndex(string programName, int i) { }

	public override string ToDebugString() { }

	public override string ToDebugString(int start, int end) { }

	public override string ToOriginalString() { }

	public override string ToOriginalString(int start, int end) { }

	public virtual string ToString() { }

	public override string ToString(string programName) { }

	public virtual string ToString(int start, int end) { }

	public override string ToString(string programName, int start, int end) { }

}

