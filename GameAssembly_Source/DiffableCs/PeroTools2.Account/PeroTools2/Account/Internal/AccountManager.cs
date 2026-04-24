namespace PeroTools2.Account.Internal;

internal class AccountManager : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public Action<JObject> succeedCallback; //Field offset: 0x10

		public <>c__DisplayClass102_0() { }

		internal void <SendToGameBackend>b__0(DownloadHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass103_0
	{
		public Action<JObject> succeedCallback; //Field offset: 0x10

		public <>c__DisplayClass103_0() { }

		internal void <SendToUserBackend>b__0(DownloadHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass104_0
	{
		public string platform; //Field offset: 0x10

		public <>c__DisplayClass104_0() { }

		internal bool <ThirdPartLogin>b__0(LoginInfo l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public LoginInfo loginInfo; //Field offset: 0x10
		public AccountManager <>4__this; //Field offset: 0x30

		public <>c__DisplayClass86_0() { }

		internal bool <Init>b__0(LoginButton b) { }

		internal void <Init>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_1
	{
		public PaymentInfo payment; //Field offset: 0x10

		public <>c__DisplayClass86_1() { }

		internal bool <Init>b__2(PaymentButton b) { }

	}

	[CompilerGenerated]
	private sealed class <AliAppPayCoroutine>d__111 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AccountManager <>4__this; //Field offset: 0x20
		public AccountCallback callback; //Field offset: 0x28
		public AppPayReq req; //Field offset: 0x30

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
		public <AliAppPayCoroutine>d__111(int <>1__state) { }

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
	private sealed class <GetUserHavingCoroutine>d__114 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AccountCallback callback; //Field offset: 0x20
		public AccountManager <>4__this; //Field offset: 0x28
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
		public <GetUserHavingCoroutine>d__114(int <>1__state) { }

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
	private sealed class <QueryHasProductCoroutine>d__113 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AccountCallback callback; //Field offset: 0x20
		public AccountManager <>4__this; //Field offset: 0x28
		public string productId; //Field offset: 0x30
		private UnityWebRequest <request>5__2; //Field offset: 0x38

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
		public <QueryHasProductCoroutine>d__113(int <>1__state) { }

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
	private sealed class <WXAppPayCoroutine>d__112 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AccountManager <>4__this; //Field offset: 0x20
		public AccountCallback callback; //Field offset: 0x28
		public AppPayReq req; //Field offset: 0x30

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
		public <WXAppPayCoroutine>d__112(int <>1__state) { }

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

	private class AndroidSDKCallbackWrapper : AndroidSDKCallback
	{
		private readonly InternalResultCallback m_InternalCallback; //Field offset: 0x20

		public AndroidSDKCallbackWrapper(InternalResultCallback icallback) { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private class BindPhoneEmailCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public BindPhoneEmailCallback <>4__this; //Field offset: 0x10
			public string res; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnSucceed>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public BindPhoneEmailCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<String> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public BindPhoneEmailCallback(Action<String> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private class GetUserHavingCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public GetUserHavingCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<String[]> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public GetUserHavingCallback(Action<String[]> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private class iOSSDKCallbackWrapper : IiOSSDKCallback
	{
		private readonly InternalResultCallback m_InternalCallback; //Field offset: 0x10

		public iOSSDKCallbackWrapper(InternalResultCallback icallback) { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private struct LoginButton
	{
		[ConstGroupDrawer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string platform; //Field offset: 0x0
		public Button button; //Field offset: 0x8

	}

	private class LoginCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public LoginCallback <>4__this; //Field offset: 0x10
			public string res; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnSucceed>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public LoginCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<String> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public LoginCallback(Action<String> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private struct PaymentButton
	{
		[ConstGroupDrawer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string platform; //Field offset: 0x0
		public Button button; //Field offset: 0x8

	}

	private class PaymentCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public PaymentCallback <>4__this; //Field offset: 0x10
			public string res; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnSucceed>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public PaymentCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<String> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public PaymentCallback(Action<String> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private class QueueProductCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public string res; //Field offset: 0x10
			public QueueProductCallback <>4__this; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnSucceed>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public QueueProductCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<Boolean> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public QueueProductCallback(Action<Boolean> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	private class RealNameCallback : AccountCallback
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public RealNameCallback <>4__this; //Field offset: 0x10
			public string res; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnSucceed>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public RealNameCallback <>4__this; //Field offset: 0x10
			public int code; //Field offset: 0x18
			public string msg; //Field offset: 0x20

			public <>c__DisplayClass6_0() { }

			internal void <OnFailed>b__0() { }

		}

		private readonly Action<String> m_SucceedAction; //Field offset: 0x10
		private readonly Action<Int32, String> m_FailedAction; //Field offset: 0x18
		private readonly Action m_StartedAction; //Field offset: 0x20
		private readonly Action m_CompletedAction; //Field offset: 0x28

		public RealNameCallback(Action<String> succeed, Action<Int32, String> failed, Action started, Action completed) { }

		[CompilerGenerated]
		private void <OnCompleted>b__8_0() { }

		[CompilerGenerated]
		private void <OnStarted>b__7_0() { }

		public virtual void OnCompleted() { }

		public virtual void OnFailed(int code, string msg) { }

		public virtual void OnStarted() { }

		public virtual void OnSucceed(string res) { }

	}

	public const string email_login_url = "api/v1/auth/phone_email_code"; //Field offset: 0x0
	private const int no_net_retry = 6; //Field offset: 0x0
	private const float no_net_gap = 10; //Field offset: 0x0
	private const float heartbeat_gap = 60; //Field offset: 0x0
	public const string get_user_having_from_peropay_url = "api/purchase/apppay/queryhaving"; //Field offset: 0x0
	public const string check_has_product_url = "api/v1/order/check_has_product"; //Field offset: 0x0
	public const string email_bind_url = "api/v1/link/email_code"; //Field offset: 0x0
	public const string phone_bind_url = "api/v1/link/phone_code"; //Field offset: 0x0
	public const string prefab_name = "AccountCanvas"; //Field offset: 0x0
	public const string localization_name = "AccountLocalizationSettings"; //Field offset: 0x0
	public const string auth_token_key = "peropero_account_auth_token"; //Field offset: 0x0
	public const string game_auth_token_key = "peropero_account_game_auth_token"; //Field offset: 0x0
	private static AccountManager s_Instance; //Field offset: 0x0
	public const string user_info_key = "peropero_account_user_info"; //Field offset: 0x0
	public const long vertify_time_gap = 60; //Field offset: 0x0
	public const int login_with_password = 1; //Field offset: 0x0
	public const int login_with_vertify_code = 2; //Field offset: 0x0
	public const int request_timeout_with_retry = 12; //Field offset: 0x0
	public const int max_request_retry = 3; //Field offset: 0x0
	public const string platform_ios_qq = "iosqq"; //Field offset: 0x0
	public const string action_phone_bind = "phone_bind"; //Field offset: 0x0
	public const string action_email_bind = "email_bind"; //Field offset: 0x0
	public const string action_real_name = "real_name"; //Field offset: 0x0
	[ConstGroup(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public const string platform_wechat_pay = "wechat_pay"; //Field offset: 0x0
	[ConstGroup(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public const string platform_alipay = "alipay"; //Field offset: 0x0
	public const int request_timeout = 20; //Field offset: 0x0
	public const string phone_login_url = "api/v1/auth/phone_login_code"; //Field offset: 0x0
	[CompilerGenerated]
	private Setting <setting>k__BackingField; //Field offset: 0x58
	[SerializeField]
	private Popup m_LoginPopup; //Field offset: 0x60
	[SerializeField]
	private Popup m_PaymentPopup; //Field offset: 0x68
	[SerializeField]
	private ClickableText m_TxtAgree; //Field offset: 0x70
	[SerializeField]
	private Toggle m_TglAgree; //Field offset: 0x78
	[SerializeField]
	private Button m_BtnAgree; //Field offset: 0x80
	[SerializeField]
	private Popup m_RealNamePopup; //Field offset: 0x88
	[SerializeField]
	private Button m_BtnRealNameYes; //Field offset: 0x90
	[SerializeField]
	private Button m_BtnRealNameClose; //Field offset: 0x98
	[SerializeField]
	private InputField m_IfName; //Field offset: 0xA0
	[SerializeField]
	private InputField m_IfNumberId; //Field offset: 0xA8
	[SerializeField]
	private Popup m_PhoneEmailPopup; //Field offset: 0xB0
	[SerializeField]
	private Popup m_VerifyCodePopup; //Field offset: 0xB8
	[SerializeField]
	private Button m_BtnVertify1; //Field offset: 0xC0
	[SerializeField]
	private Button m_BtnVertify2; //Field offset: 0xC8
	[SerializeField]
	private Image m_ImgVertify; //Field offset: 0xD0
	[SerializeField]
	private Text m_TxtVertify; //Field offset: 0xD8
	[SerializeField]
	private Button m_BtnPhoneEmailLogin; //Field offset: 0xE0
	[SerializeField]
	private Button m_BtnPhoneEmailClose; //Field offset: 0xE8
	[SerializeField]
	private InputField m_IfPhone; //Field offset: 0xF0
	[SerializeField]
	private InputField m_IfEmail; //Field offset: 0xF8
	[SerializeField]
	private InputField m_IfVertifyCode; //Field offset: 0x100
	[SerializeField]
	private Button m_BtnUsePhone; //Field offset: 0x108
	[SerializeField]
	private Button m_BtnUseEmail; //Field offset: 0x110
	[SerializeField]
	private Text m_TxtUsePhone; //Field offset: 0x118
	[SerializeField]
	private Text m_TxtUseEmail; //Field offset: 0x120
	[SerializeField]
	private Image m_ImgUsePhone; //Field offset: 0x128
	[SerializeField]
	private Image m_ImgUseEmail; //Field offset: 0x130
	[SerializeField]
	private List<LoginButton> m_LoginButtons; //Field offset: 0x138
	[SerializeField]
	private List<PaymentButton> m_PaymentButtons; //Field offset: 0x140
	private long m_VertifyClickTime; //Field offset: 0x148
	private AccountCallback m_LoginCallback; //Field offset: 0x150
	private AccountCallback m_BindCallback; //Field offset: 0x158
	private AccountCallback m_RealNameCallback; //Field offset: 0x160
	private AccountCallback m_PaymentCallback; //Field offset: 0x168
	internal string gameId; //Field offset: 0x170
	private string m_AuthToken; //Field offset: 0x178
	private string m_GameAuthToken; //Field offset: 0x180
	private UserInfo m_UserInfo; //Field offset: 0x188
	private string m_ProductId; //Field offset: 0x1F0
	private int m_Price; //Field offset: 0x1F8
	private int m_RealNameType; //Field offset: 0x1FC
	private int m_AdultType; //Field offset: 0x200
	private string m_Platform; //Field offset: 0x208
	[CompilerGenerated]
	private bool <isOversea>k__BackingField; //Field offset: 0x210
	public Func<HeartbeatResp, Boolean> onHeartBeatTip; //Field offset: 0x218
	private WaitForSeconds m_HeatbeatWaitForSeconds; //Field offset: 0x220
	private WaitUntil m_HeatbeatWaitUtil; //Field offset: 0x228
	private WaitForSeconds m_NoNetWaitForSeconds; //Field offset: 0x230
	private int m_NoNetCount; //Field offset: 0x238
	private Coroutine m_HeartbeatCoroutine1; //Field offset: 0x240
	private Coroutine m_HeartbeatCoroutine2; //Field offset: 0x248

	internal string authToken
	{
		internal get { } //Length: 112
		internal set { } //Length: 133
	}

	internal string gameAuthToken
	{
		internal get { } //Length: 112
		internal set { } //Length: 133
	}

	public static AccountManager instance
	{
		 get { } //Length: 289
	}

	internal bool isOversea
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal Setting setting
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	internal UserInfo userInfo
	{
		internal get { } //Length: 279
		internal set { } //Length: 324
	}

	public AccountManager() { }

	[CompilerGenerated]
	private void <Init>b__142_0() { }

	[CompilerGenerated]
	private void <Init>b__142_1() { }

	[CompilerGenerated]
	private void <Init>b__142_2() { }

	[CompilerGenerated]
	private void <Init>b__142_3() { }

	[CompilerGenerated]
	private void <Init>b__142_4() { }

	[CompilerGenerated]
	private void <Init>b__142_5() { }

	[CompilerGenerated]
	private void <Init>b__142_6() { }

	[CompilerGenerated]
	private void <Init>b__142_7() { }

	[CompilerGenerated]
	private void <Init>b__86_3() { }

	[CompilerGenerated]
	private void <Init>b__86_4() { }

	[CompilerGenerated]
	private void <OnHeartbeatTip>b__127_0(string res) { }

	[CompilerGenerated]
	private void <OpenPhoneEmail>b__94_0() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator AliAppPayCoroutine(AppPayReq req, AccountCallback callback) { }

	internal string get_authToken() { }

	internal string get_gameAuthToken() { }

	public static AccountManager get_instance() { }

	[CompilerGenerated]
	internal bool get_isOversea() { }

	[CompilerGenerated]
	internal Setting get_setting() { }

	internal UserInfo get_userInfo() { }

	public void GetUserHaving(Action<String[]> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	public void GetUserHaving(AccountCallback callback) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator GetUserHavingCoroutine(AccountCallback callback) { }

	private void Init() { }

	public void Init(string settingName, SystemLanguage systemLanguage, string platform) { }

	private void InitAliPay(string appId) { }

	private void InitWXPay(string appId) { }

	public bool IsLoggedIn() { }

	public void Logout() { }

	private void OnApplicationQuit() { }

	private void OnHeartbeatTip(HeartbeatResp req) { }

	public void OpenLogin(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	public void OpenLogin(AccountCallback callback) { }

	public void OpenPayment(string productId, int price, int realnameType = 0, int adultType = 0, Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	public void OpenPayment(string productId, int price, int realnameType = 0, int adultType = 0, AccountCallback callback = null) { }

	public void OpenPhoneEmail(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	public void OpenPhoneEmail(AccountCallback callback) { }

	public void OpenRealName(AccountCallback callback, bool closeable = true) { }

	public void OpenRealName(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null, bool closeable = true) { }

	public void PhoneEmailBind(string platform, string number, string code) { }

	public void PhoneEmailLogin(string platform, string number, string code) { }

	public void QueryHasProduct(string productId, AccountCallback callback) { }

	public void QueryHasProduct(string productId, Action<Boolean> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator QueryHasProductCoroutine(string productId, AccountCallback callback) { }

	public void RealName(string realName, string numberId) { }

	public PeroWebRequest SendToGameBackend(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null, int timeout = 0) { }

	public PeroWebRequest SendToUserBackend(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null, int timeout = 0) { }

	public void SendVerifyCode() { }

	internal void set_authToken(string value) { }

	internal void set_gameAuthToken(string value) { }

	[CompilerGenerated]
	private void set_isOversea(bool value) { }

	[CompilerGenerated]
	private void set_setting(Setting value) { }

	internal void set_userInfo(UserInfo value) { }

	public void SetBindCallback(AccountCallback callback) { }

	public void SetLanguage(SystemLanguage systemLanguage) { }

	public void SetLoginCallback(AccountCallback callback) { }

	public void SetPaymentCallback(AccountCallback callback) { }

	public void SetRealNameCallback(AccountCallback callback) { }

	public void StartHeartbeat() { }

	public void StopHeartbeat() { }

	public void ThirdPartLogin(string platform) { }

	private void Update() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator WXAppPayCoroutine(AppPayReq req, AccountCallback callback) { }

}

