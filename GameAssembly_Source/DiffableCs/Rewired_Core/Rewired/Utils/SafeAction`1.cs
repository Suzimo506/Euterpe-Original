namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class SafeAction : SafeDelegate<Action`1<T>>
{
	private static Action<Object, Action`1<T>> fhWGZUtlgVxDrbgCDrtYdVtFVJoH; //Field offset: 0x0
	private T tGaBPLgRqDeZFHTPaAuCoxqxUbsvA; //Field offset: 0x0

	private static Action<Object, Action`1<T>> invokeDelegate
	{
		private get { } //Length: 363
	}

	public SafeAction`1() { }

	public SafeAction`1(Action<Exception> unnamed_param_0) { }

	protected SafeAction`1(SafeAction<T> unnamed_param_0) { }

	public virtual object Clone() { }

	public void Invoke(T arg0) { }

	private static void NmUlNFuVXwsFfGqriXcfNDxcXwhq(object unnamed_param_0, Action<T> unnamed_param_1) { }

	public static SafeAction<T> op_Addition(SafeAction<T> eventList, Action<T> listener) { }

	public static Action<T> op_Implicit(SafeAction<T> obj) { }

	public static SafeAction<T> op_Implicit(Action<T> obj) { }

	public static SafeAction<T> op_Subtraction(SafeAction<T> eventList, Action<T> listener) { }

	private static Action<Object, Action`1<T>> YpdTTxlnobIOPUXkdrOafKKbCThl() { }

}

