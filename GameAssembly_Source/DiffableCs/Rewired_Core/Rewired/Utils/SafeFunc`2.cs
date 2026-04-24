namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal class SafeFunc : SafeDelegate<Func`2<T, TResult>>
{
	private static Action<Object, Func`2<T, TResult>> fhWGZUtlgVxDrbgCDrtYdVtFVJoH; //Field offset: 0x0
	private TResult wYhBfOdLhnfyFlBGzBJlrsVATLXO; //Field offset: 0x0
	private T tGaBPLgRqDeZFHTPaAuCoxqxUbsvA; //Field offset: 0x0

	private static Action<Object, Func`2<T, TResult>> invokeDelegate
	{
		private get { } //Length: 363
	}

	public SafeFunc`2() { }

	public SafeFunc`2(Action<Exception> unnamed_param_0) { }

	protected SafeFunc`2(SafeFunc<T, TResult> unnamed_param_0) { }

	public virtual object Clone() { }

	public TResult Invoke(T arg0) { }

	private static void NmUlNFuVXwsFfGqriXcfNDxcXwhq(object unnamed_param_0, Func<T, TResult> unnamed_param_1) { }

	public static SafeFunc<T, TResult> op_Addition(SafeFunc<T, TResult> eventList, Func<T, TResult> func) { }

	public static Func<T, TResult> op_Implicit(SafeFunc<T, TResult> obj) { }

	public static SafeFunc<T, TResult> op_Implicit(Func<T, TResult> obj) { }

	public static SafeFunc<T, TResult> op_Subtraction(SafeFunc<T, TResult> eventList, Func<T, TResult> func) { }

	private static Action<Object, Func`2<T, TResult>> YpdTTxlnobIOPUXkdrOafKKbCThl() { }

}

