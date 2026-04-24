namespace NCalc;

public class Expression
{
	private static bool _cacheEnabled; //Field offset: 0x0
	private static ConcurrentDictionary<String, WeakReference> _compiledExpressions; //Field offset: 0x8
	[CompilerGenerated]
	private EvaluateOptions <Options>k__BackingField; //Field offset: 0x10
	protected string OriginalExpression; //Field offset: 0x18
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Exception <ErrorException>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private LogicalExpression <ParsedExpression>k__BackingField; //Field offset: 0x30
	protected Dictionary<String, IEnumerator> ParameterEnumerators; //Field offset: 0x38
	protected Dictionary<String, Object> ParametersBackup; //Field offset: 0x40
	[CompilerGenerated]
	private EvaluateFunctionHandler EvaluateFunction; //Field offset: 0x48
	[CompilerGenerated]
	private EvaluateParameterHandler EvaluateParameter; //Field offset: 0x50
	private Dictionary<String, Object> _parameters; //Field offset: 0x58

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

	public static bool CacheEnabled
	{
		 get { } //Length: 86
		 set { } //Length: 267
	}

	public private string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Exception ErrorException
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public EvaluateOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, Object> Parameters
	{
		 get { } //Length: 110
		 set { } //Length: 12
	}

	public private LogicalExpression ParsedExpression
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static Expression() { }

	public Expression(string expression) { }

	public Expression(string expression, EvaluateOptions options) { }

	public Expression(LogicalExpression expression) { }

	public Expression(LogicalExpression expression, EvaluateOptions options) { }

	[CompilerGenerated]
	public void add_EvaluateFunction(EvaluateFunctionHandler value) { }

	[CompilerGenerated]
	public void add_EvaluateParameter(EvaluateParameterHandler value) { }

	private static void CleanCache() { }

	public static LogicalExpression Compile(string expression, bool nocache) { }

	public object Evaluate() { }

	public static bool get_CacheEnabled() { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public Exception get_ErrorException() { }

	[CompilerGenerated]
	public EvaluateOptions get_Options() { }

	public Dictionary<String, Object> get_Parameters() { }

	[CompilerGenerated]
	public LogicalExpression get_ParsedExpression() { }

	public bool HasErrors() { }

	[CompilerGenerated]
	public void remove_EvaluateFunction(EvaluateFunctionHandler value) { }

	[CompilerGenerated]
	public void remove_EvaluateParameter(EvaluateParameterHandler value) { }

	public static void set_CacheEnabled(bool value) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	private void set_ErrorException(Exception value) { }

	[CompilerGenerated]
	public void set_Options(EvaluateOptions value) { }

	public void set_Parameters(Dictionary<String, Object> value) { }

	[CompilerGenerated]
	private void set_ParsedExpression(LogicalExpression value) { }

	public Func<TResult> ToLambda() { }

	public Func<TContext, TResult> ToLambda() { }

}

