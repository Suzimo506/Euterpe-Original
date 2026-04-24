namespace NCalc;

public class FunctionArgs : EventArgs
{
	private object _result; //Field offset: 0x10
	[CompilerGenerated]
	private bool <HasResult>k__BackingField; //Field offset: 0x18
	private Expression[] _parameters; //Field offset: 0x20

	public bool HasResult
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Expression[] Parameters
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public object Result
	{
		 get { } //Length: 5
		 set { } //Length: 32
	}

	public FunctionArgs() { }

	public Object[] EvaluateParameters() { }

	[CompilerGenerated]
	public bool get_HasResult() { }

	public Expression[] get_Parameters() { }

	public object get_Result() { }

	[CompilerGenerated]
	public void set_HasResult(bool value) { }

	public void set_Parameters(Expression[] value) { }

	public void set_Result(object value) { }

}

