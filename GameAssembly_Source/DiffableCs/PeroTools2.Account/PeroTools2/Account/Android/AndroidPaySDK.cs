namespace PeroTools2.Account.Android;

internal class AndroidPaySDK
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Object>, String> <>9__13_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Object>, Object> <>9__13_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Object>, String> <>9__14_0; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, Object>, Object> <>9__14_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <AliAppPayCoroutine>b__13_0(KeyValuePair<String, Object> d) { }

		internal object <AliAppPayCoroutine>b__13_1(KeyValuePair<String, Object> v) { }

		internal string <WXAppPayCoroutine>b__14_0(KeyValuePair<String, Object> d) { }

		internal object <WXAppPayCoroutine>b__14_1(KeyValuePair<String, Object> v) { }

	}

	[CompilerGenerated]
	private sealed class <AliAppPayCoroutine>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AndroidSDKCallback callback; //Field offset: 0x20
		public AppPayReq req; //Field offset: 0x28
		private UnityWebRequest <request>5__2; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AliAppPayCoroutine>d__13(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <WXAppPayCoroutine>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AndroidSDKCallback callback; //Field offset: 0x20
		public AppPayReq req; //Field offset: 0x28
		private UnityWebRequest <request>5__2; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <WXAppPayCoroutine>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class AndroidAppPayCallbackWrapper : AndroidSDKCallback
	{
		private readonly AndroidSDKCallback m_UserCallback; //Field offset: 0x20
		private readonly string m_OrderId; //Field offset: 0x28

		public AndroidAppPayCallbackWrapper(AndroidSDKCallback callback, string orderId) { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private const string alipay_pkg_name = "net.peropero.perosdk.AliPay"; //Field offset: 0x0
	private const string wxpay_pkg_name = "net.peropero.perosdk.WXPay"; //Field offset: 0x0
	private const string aliapp_pay_url = "api/v1/pay/alipay"; //Field offset: 0x0
	private const string wxapp_pay_url = "api/v1/pay/wxpay"; //Field offset: 0x0
	private static AndroidJavaClass s_AliPay; //Field offset: 0x0
	private static AndroidJavaClass s_WXPay; //Field offset: 0x8
	private static string s_AliPayAppId; //Field offset: 0x10
	private static string s_WXPayAppId; //Field offset: 0x18

	public AndroidPaySDK() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerator AliAppPayCoroutine(AppPayReq req, AndroidSDKCallback callback) { }

	private static AndroidJavaClass GetAliPay() { }

	private static AndroidJavaClass GetWXPay() { }

	public static void InitAliPay(string appId) { }

	public static void InitWXPay(string appId) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerator WXAppPayCoroutine(AppPayReq req, AndroidSDKCallback callback) { }

}

