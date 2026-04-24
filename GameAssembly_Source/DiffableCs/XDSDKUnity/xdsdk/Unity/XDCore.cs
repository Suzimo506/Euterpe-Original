namespace xdsdk.Unity;

public class XDCore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__23_1; //Field offset: 0x8
		public static Action<String> <>9__23_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <PayWithoutRealNameCheck>b__23_1(string result) { }

		internal void <PayWithoutRealNameCheck>b__23_2(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string token; //Field offset: 0x10
		public XDCore <>4__this; //Field offset: 0x18
		public Action<User> <>9__4; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal void <Login>b__1(User user) { }

		internal void <Login>b__4(User userAfterRealName) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public User user; //Field offset: 0x10
		public <>c__DisplayClass19_0 CS$<>8__locals1; //Field offset: 0x18
		public Action<String> <>9__5; //Field offset: 0x20

		public <>c__DisplayClass19_1() { }

		internal void <Login>b__3(int code, object result) { }

		internal void <Login>b__5(string err) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public XDCore <>4__this; //Field offset: 0x10
		public Dictionary<String, String> info; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <Pay>b__0(int code, object result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public object result; //Field offset: 0x10
		public <>c__DisplayClass22_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass22_1() { }

		internal void <Pay>b__1(User userAfterRealName) { }

		internal void <Pay>b__2(string err) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public XDCore <>4__this; //Field offset: 0x10
		public Dictionary<String, String> info; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_1
	{
		public SDKManager manager; //Field offset: 0x10
		public <>c__DisplayClass23_0 CS$<>8__locals1; //Field offset: 0x18
		public Action<Int32, Object> <>9__3; //Field offset: 0x20

		public <>c__DisplayClass23_1() { }

		internal void <PayWithoutRealNameCheck>b__0(int code, object data) { }

		internal void <PayWithoutRealNameCheck>b__3(int resultCode, object resultData) { }

	}

	private enum SDK_State
	{
		Initialize = 0,
		Initializing = 1,
		Initialized = 2,
		LoggingIn = 3,
		LoggedIn = 4,
		Paying = 5,
		RealName = 6,
	}

	private static XDCore instance; //Field offset: 0x0
	private SDK_State state; //Field offset: 0x10
	[CompilerGenerated]
	private Action<ResultCode, String> Callback; //Field offset: 0x18
	private AppInfo appInfo; //Field offset: 0x20
	private User user; //Field offset: 0x28
	private GameObject managerObject; //Field offset: 0x30
	private readonly LoginEntry loginEntry; //Field offset: 0x38

	public event Action<ResultCode, String> Callback
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static XDCore Instance
	{
		 get { } //Length: 207
	}

	public XDCore() { }

	[CompilerGenerated]
	private void <Init>b__18_0(AppInfo info) { }

	[CompilerGenerated]
	private void <Init>b__18_1(string error) { }

	[CompilerGenerated]
	private void <Login>b__19_0() { }

	[CompilerGenerated]
	private void <Login>b__19_2(string error) { }

	[CompilerGenerated]
	private void <Login>b__19_6(int code, object data) { }

	[CompilerGenerated]
	private void <OpenRealName>b__24_0(int code, object result) { }

	[CompilerGenerated]
	public void add_Callback(Action<ResultCode, String> value) { }

	public void ClearCallback() { }

	public static XDCore get_Instance() { }

	public string GetAccessToken() { }

	public void HideGuest() { }

	public void HideQQ() { }

	public void HideTapTap() { }

	public void HideWX() { }

	public void Init(string appid) { }

	public void Login() { }

	public void Logout() { }

	public void OpenRealName() { }

	public void Pay(Dictionary<String, String> info) { }

	public void PayWithoutRealNameCheck(Dictionary<String, String> info) { }

	[CompilerGenerated]
	public void remove_Callback(Action<ResultCode, String> value) { }

	public void SetLoginEntries(String[] entries) { }

}

