namespace Account;

public class XDSDKCallback : XDCallback
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x16EA67

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__51_0() { }

		internal void <.cctor>b__51_1(string <p0>) { }

		internal void <.cctor>b__51_10() { }

		internal void <.cctor>b__51_2(string <p0>) { }

		internal void <.cctor>b__51_3(string <p0>) { }

		internal void <.cctor>b__51_4() { }

		internal void <.cctor>b__51_5() { }

		internal void <.cctor>b__51_6() { }

		internal void <.cctor>b__51_7(string <p0>) { }

		internal void <.cctor>b__51_8() { }

		internal void <.cctor>b__51_9() { }

	}

	[CompilerGenerated]
	private static Action onInitSucceed; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<String> onInitFailed; //Field offset: 0x8
	[CompilerGenerated]
	private static Action<String> onLoginSucceed; //Field offset: 0x10
	[CompilerGenerated]
	private static Action<String> onLoginFailed; //Field offset: 0x18
	[CompilerGenerated]
	private static Action onLogout; //Field offset: 0x20
	[CompilerGenerated]
	private static Action onLoginCancell; //Field offset: 0x28
	[CompilerGenerated]
	private static Action onPayCompleted; //Field offset: 0x30
	[CompilerGenerated]
	private static Action<String> onPayFailed; //Field offset: 0x38
	[CompilerGenerated]
	private static Action onPayCanceled; //Field offset: 0x40
	[CompilerGenerated]
	private static Action onRealNameSucceed; //Field offset: 0x48
	[CompilerGenerated]
	private static Action onRealNameFailed; //Field offset: 0x50
	public static bool isInited; //Field offset: 0x58

	public static event Action<String> onInitFailed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onInitSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 238
		[CompilerGenerated]
		 remove { } //Length: 238
	}

	public static event Action onLoginCancell
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action<String> onLoginFailed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action<String> onLoginSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onLogout
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onPayCanceled
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onPayCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action<String> onPayFailed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onRealNameFailed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action onRealNameSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	private static XDSDKCallback() { }

	public XDSDKCallback() { }

	[CompilerGenerated]
	public static void add_onInitFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void add_onInitSucceed(Action value) { }

	[CompilerGenerated]
	public static void add_onLoginCancell(Action value) { }

	[CompilerGenerated]
	public static void add_onLoginFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void add_onLoginSucceed(Action<String> value) { }

	[CompilerGenerated]
	public static void add_onLogout(Action value) { }

	[CompilerGenerated]
	public static void add_onPayCanceled(Action value) { }

	[CompilerGenerated]
	public static void add_onPayCompleted(Action value) { }

	[CompilerGenerated]
	public static void add_onPayFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void add_onRealNameFailed(Action value) { }

	[CompilerGenerated]
	public static void add_onRealNameSucceed(Action value) { }

	public virtual void OnExitCancel() { }

	public virtual void OnExitConfirm() { }

	public virtual void OnGuestBindSucceed(string token) { }

	public virtual void OnInitFailed(string msg) { }

	public virtual void OnInitSucceed() { }

	public virtual void OnLoginCanceled() { }

	public virtual void OnLoginFailed(string msg) { }

	public virtual void OnLoginSucceed(string token) { }

	public virtual void OnLogoutSucceed() { }

	public virtual void OnPayCanceled() { }

	public virtual void OnPayCompleted() { }

	public virtual void OnPayFailed(string msg) { }

	public virtual void OnRealNameFailed(string msg) { }

	public virtual void OnRealNameSucceed() { }

	public virtual void OnWXShareSucceed() { }

	[CompilerGenerated]
	public static void remove_onInitFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void remove_onInitSucceed(Action value) { }

	[CompilerGenerated]
	public static void remove_onLoginCancell(Action value) { }

	[CompilerGenerated]
	public static void remove_onLoginFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void remove_onLoginSucceed(Action<String> value) { }

	[CompilerGenerated]
	public static void remove_onLogout(Action value) { }

	[CompilerGenerated]
	public static void remove_onPayCanceled(Action value) { }

	[CompilerGenerated]
	public static void remove_onPayCompleted(Action value) { }

	[CompilerGenerated]
	public static void remove_onPayFailed(Action<String> value) { }

	[CompilerGenerated]
	public static void remove_onRealNameFailed(Action value) { }

	[CompilerGenerated]
	public static void remove_onRealNameSucceed(Action value) { }

	public virtual void RestoredPayment(List<Dictionary`2<String, String>> resultList) { }

}

