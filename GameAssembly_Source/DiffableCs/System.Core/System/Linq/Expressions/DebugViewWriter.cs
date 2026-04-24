namespace System.Linq.Expressions;

internal sealed class DebugViewWriter : ExpressionVisitor
{
	[Flags]
	private enum Flow
	{
		None = 0,
		Space = 1,
		NewLine = 2,
		Break = 32768,
	}

	private readonly TextWriter _out; //Field offset: 0x10
	private int _column; //Field offset: 0x18
	private readonly Stack<Int32> _stack; //Field offset: 0x20
	private int _delta; //Field offset: 0x28
	private Flow _flow; //Field offset: 0x2C
	private Queue<LambdaExpression> _lambdas; //Field offset: 0x30
	private Dictionary<LambdaExpression, Int32> _lambdaIds; //Field offset: 0x38
	private Dictionary<ParameterExpression, Int32> _paramIds; //Field offset: 0x40
	private Dictionary<LabelTarget, Int32> _labelIds; //Field offset: 0x48

	private int Base
	{
		private get { } //Length: 81
	}

	private int Delta
	{
		private get { } //Length: 4
	}

	private int Depth
	{
		private get { } //Length: 94
	}

	private DebugViewWriter(TextWriter file) { }

	[CompilerGenerated]
	private void <VisitDeclarations>b__38_0(ParameterExpression variable) { }

	[CompilerGenerated]
	private void <VisitExpressions>b__37_0(T e) { }

	private Flow CheckBreak(Flow flow) { }

	private static bool ContainsWhiteSpace(string name) { }

	private void Dedent() { }

	private void DumpLabel(LabelTarget target) { }

	private int get_Base() { }

	private int get_Delta() { }

	private int get_Depth() { }

	private static string GetConstantValueSuffix(Type type) { }

	private static string GetDisplayName(string name) { }

	private Flow GetFlow(Flow flow) { }

	private static int GetId(T e, ref Dictionary<T, Int32>& ids) { }

	private int GetLabelTargetId(LabelTarget target) { }

	private string GetLabelTargetName(LabelTarget target) { }

	private int GetLambdaId(LambdaExpression le) { }

	private string GetLambdaName(LambdaExpression lambda) { }

	private static int GetOperatorPrecedence(Expression node) { }

	private int GetParamId(ParameterExpression p) { }

	private void Indent() { }

	private static bool IsSimpleExpression(Expression node) { }

	private static bool NeedsParentheses(Expression parent, Expression child) { }

	private void NewLine() { }

	private void Out(Flow before, string s, Flow after) { }

	private void Out(string s, Flow after) { }

	private void Out(Flow before, string s) { }

	private void Out(string s) { }

	private void OutMember(Expression node, Expression instance, MemberInfo member) { }

	private void ParenthesizedVisit(Expression parent, Expression nodeToVisit) { }

	private static string QuoteName(string name) { }

	protected private virtual Expression VisitBinary(BinaryExpression node) { }

	protected private virtual Expression VisitBlock(BlockExpression node) { }

	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	protected private virtual Expression VisitConditional(ConditionalExpression node) { }

	protected private virtual Expression VisitConstant(ConstantExpression node) { }

	private void VisitDeclarations(IReadOnlyList<ParameterExpression> expressions) { }

	protected private virtual Expression VisitDefault(DefaultExpression node) { }

	private void VisitExpressions(char open, IReadOnlyList<T> expressions) { }

	private void VisitExpressions(char open, char separator, IReadOnlyList<T> expressions) { }

	private void VisitExpressions(char open, char separator, IReadOnlyList<T> expressions, Action<T> visit) { }

	protected private virtual Expression VisitExtension(Expression node) { }

	protected private virtual Expression VisitGoto(GotoExpression node) { }

	protected private virtual Expression VisitIndex(IndexExpression node) { }

	protected private virtual Expression VisitInvocation(InvocationExpression node) { }

	protected private virtual Expression VisitLabel(LabelExpression node) { }

	protected private virtual Expression VisitLambda(Expression<T> node) { }

	protected private virtual Expression VisitLoop(LoopExpression node) { }

	protected private virtual Expression VisitMember(MemberExpression node) { }

	protected private virtual Expression VisitMethodCall(MethodCallExpression node) { }

	protected private virtual Expression VisitNewArray(NewArrayExpression node) { }

	protected private virtual Expression VisitParameter(ParameterExpression node) { }

	protected private virtual Expression VisitTry(TryExpression node) { }

	protected private virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	protected private virtual Expression VisitUnary(UnaryExpression node) { }

	private void Write(string s) { }

	private void WriteLambda(LambdaExpression lambda) { }

	private void WriteLine() { }

	private void WriteTo(Expression node) { }

	internal static void WriteTo(Expression node, TextWriter writer) { }

}

