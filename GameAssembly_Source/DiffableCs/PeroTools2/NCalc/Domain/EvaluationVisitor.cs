namespace NCalc.Domain;

public class EvaluationVisitor : LogicalExpressionVisitor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public object leftValue; //Field offset: 0x10
		public BinaryExpression expression; //Field offset: 0x18
		public EvaluationVisitor <>4__this; //Field offset: 0x20
		public object rightValue; //Field offset: 0x28

		public <>c__DisplayClass22_0() { }

		internal object <Visit>b__0() { }

		internal object <Visit>b__1() { }

	}

	private sealed class Func : MulticastDelegate
	{

		public Func`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke() { }

	}

	private static Type[] CommonTypes; //Field offset: 0x0
	private readonly EvaluateOptions _options; //Field offset: 0x10
	[CompilerGenerated]
	private object <Result>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EvaluateFunctionHandler EvaluateFunction; //Field offset: 0x20
	[CompilerGenerated]
	private EvaluateParameterHandler EvaluateParameter; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<String, Object> <Parameters>k__BackingField; //Field offset: 0x30

	public event EvaluateFunctionHandler EvaluateFunction
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EvaluateParameterHandler EvaluateParameter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private bool Checked
	{
		private get { } //Length: 9
	}

	private bool IgnoreCase
	{
		private get { } //Length: 8
	}

	private bool IgnoreCaseString
	{
		private get { } //Length: 9
	}

	private bool Ordinal
	{
		private get { } //Length: 9
	}

	public Dictionary<String, Object> Parameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private object Result
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static EvaluationVisitor() { }

	public EvaluationVisitor(EvaluateOptions options) { }

	[CompilerGenerated]
	public void add_EvaluateFunction(EvaluateFunctionHandler value) { }

	[CompilerGenerated]
	public void add_EvaluateParameter(EvaluateParameterHandler value) { }

	private void CheckCase(string function, string called) { }

	public int CompareUsingMostPreciseType(object a, object b) { }

	private object Evaluate(LogicalExpression expression) { }

	private bool get_Checked() { }

	private bool get_IgnoreCase() { }

	private bool get_IgnoreCaseString() { }

	private bool get_Ordinal() { }

	[CompilerGenerated]
	public Dictionary<String, Object> get_Parameters() { }

	[CompilerGenerated]
	public object get_Result() { }

	private static Type GetMostPreciseType(Type a, Type b) { }

	private static bool IsReal(object value) { }

	private void OnEvaluateFunction(string name, FunctionArgs args) { }

	private void OnEvaluateParameter(string name, ParameterArgs args) { }

	[CompilerGenerated]
	public void remove_EvaluateFunction(EvaluateFunctionHandler value) { }

	[CompilerGenerated]
	public void remove_EvaluateParameter(EvaluateParameterHandler value) { }

	[CompilerGenerated]
	public void set_Parameters(Dictionary<String, Object> value) { }

	[CompilerGenerated]
	private void set_Result(object value) { }

	public virtual void Visit(UnaryExpression expression) { }

	public virtual void Visit(ValueExpression expression) { }

	public virtual void Visit(Function function) { }

	public virtual void Visit(LogicalExpression expression) { }

	public virtual void Visit(Identifier parameter) { }

	public virtual void Visit(TernaryExpression expression) { }

	public virtual void Visit(BinaryExpression expression) { }

}

