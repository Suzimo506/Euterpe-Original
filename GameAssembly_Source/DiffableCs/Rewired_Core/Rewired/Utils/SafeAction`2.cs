namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class SafeAction : SafeDelegate<Action`2<T, T2>>
{
	private static Action<Object, Action`2<T, T2>> fhWGZUtlgVxDrbgCDrtYdVtFVJoH; //Field offset: 0x0
	private T2 KBUpiYTvorDLPDLyufQHLTbRWDQR; //Field offset: 0x0
	private T tGaBPLgRqDeZFHTPaAuCoxqxUbsvA; //Field offset: 0x0

	private static Action<Object, Action`2<T, T2>> invokeDelegate
	{
		private get { } //Length: 363
	}

	public SafeAction`2() { }

	public SafeAction`2(Action<Exception> unnamed_param_0) { }

	protected SafeAction`2(SafeAction<T, T2> unnamed_param_0) { }

	public virtual object Clone() { }

	public void Invoke(T arg0, T2 arg1) { }

	private static void NmUlNFuVXwsFfGqriXcfNDxcXwhq(object unnamed_param_0, Action<T, T2> unnamed_param_1) { }

	public static SafeAction<T, T2> op_Addition(SafeAction<T, T2> eventList, Action<T, T2> listener) { }

	public static Action<T, T2> op_Implicit(SafeAction<T, T2> obj) { }

	public static SafeAction<T, T2> op_Implicit(Action<T, T2> obj) { }

	public static SafeAction<T, T2> op_Subtraction(SafeAction<T, T2> eventList, Action<T, T2> listener) { }

	private static Action<Object, Action`2<T, T2>> YpdTTxlnobIOPUXkdrOafKKbCThl() { }

}

