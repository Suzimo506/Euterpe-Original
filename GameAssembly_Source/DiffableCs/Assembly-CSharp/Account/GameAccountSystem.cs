namespace Account;

public class GameAccountSystem : AccountSystem
{
	[CompilerGenerated]
	private sealed class <<Login>g__LocalLogin|27_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameAccountSystem <>4__this; //Field offset: 0x20

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
		public <<Login>g__LocalLogin|27_0>d(int <>1__state) { }

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
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__24_0; //Field offset: 0x8
		public static Action<String> <>9__24_1; //Field offset: 0x10
		public static Action<String> <>9__24_2; //Field offset: 0x18
		public static Func<Boolean> <>9__27_1; //Field offset: 0x20
		public static Func<Boolean> <>9__27_2; //Field offset: 0x28
		public static Action <>9__30_5; //Field offset: 0x30
		public static Action <>9__31_4; //Field offset: 0x38
		public static Func<Boolean> <>9__39_1; //Field offset: 0x40
		public static Action<Int64, String> <>9__39_3; //Field offset: 0x48
		public static Action<Int64, String> <>9__60_1; //Field offset: 0x50
		public static Action<Int64, String> <>9__61_2; //Field offset: 0x58

		private static <>c() { }

		public <>c() { }

		internal bool <GetUserInfo>b__39_1() { }

		internal void <GetUserInfo>b__39_3(long c, string s) { }

		internal void <Init>b__24_0() { }

		internal void <Init>b__24_1(string e) { }

		internal void <Init>b__24_2(string e) { }

		internal bool <Login>b__27_1() { }

		internal bool <Login>b__27_2() { }

		internal void <OnLoginSuccess>b__30_5() { }

		internal void <OnPCOverseasLoginSucceed>b__31_4() { }

		internal void <OnSaveSelectCallback>b__61_2(long code, string error) { }

		internal void <Synchronize>b__60_1(long code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		private sealed class <<OnLoginSuccess>g__LoginEnumerator|0>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass30_0 <>4__this; //Field offset: 0x20
			private <>c__DisplayClass30_1 <>8__1; //Field offset: 0x28

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
			public <<OnLoginSuccess>g__LoginEnumerator|0>d(int <>1__state) { }

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

		public GameAccountSystem <>4__this; //Field offset: 0x10
		public string accessToken; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <OnLoginSuccess>b__1() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal IEnumerator <OnLoginSuccess>g__LoginEnumerator|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_1
	{
		public PeroWebRequest req; //Field offset: 0x10
		public <>c__DisplayClass30_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass30_1() { }

		internal void <OnLoginSuccess>b__2(JObject jObj) { }

		internal void <OnLoginSuccess>b__3(JObject jObj) { }

		internal void <OnLoginSuccess>b__4(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		private sealed class <<OnPCOverseasLoginSucceed>g__LoginEnumerator|0>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass31_0 <>4__this; //Field offset: 0x20
			private <>c__DisplayClass31_1 <>8__1; //Field offset: 0x28

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
			public <<OnPCOverseasLoginSucceed>g__LoginEnumerator|0>d(int <>1__state) { }

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

		public string openid; //Field offset: 0x10
		public string p; //Field offset: 0x18
		public GameAccountSystem <>4__this; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal IEnumerator <OnPCOverseasLoginSucceed>g__LoginEnumerator|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_1
	{
		public PeroWebRequest req; //Field offset: 0x10
		public <>c__DisplayClass31_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass31_1() { }

		internal void <OnPCOverseasLoginSucceed>b__1(JObject jObj) { }

		internal void <OnPCOverseasLoginSucceed>b__2(JObject jObj) { }

		internal void <OnPCOverseasLoginSucceed>b__3(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_2
	{
		public JObject jObj; //Field offset: 0x10
		public <>c__DisplayClass31_1 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass31_2() { }

		internal void <OnPCOverseasLoginSucceed>b__5(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Action<Int32> callback; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal void <SetPlayerName>b__0(JObject jObj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public PeroWebRequest webRequest; //Field offset: 0x10
		public Action<Boolean, Boolean> callback; //Field offset: 0x18

		public <>c__DisplayClass37_0() { }

		internal void <IsRealName>b__0(DownloadHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Action failCallback; //Field offset: 0x10
		public Action succeedCallback; //Field offset: 0x18

		public <>c__DisplayClass38_0() { }

		internal void <OpenRealName>g__FailAction|0() { }

		internal void <OpenRealName>g__SucceedAction|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		private sealed class <<GetUserInfo>g__Get|0>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass39_0 <>4__this; //Field offset: 0x20

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
			public <<GetUserInfo>g__Get|0>d(int <>1__state) { }

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

		public GameAccountSystem <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal void <GetUserInfo>b__2(JObject jObj) { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal IEnumerator <GetUserInfo>g__Get|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Action<JToken, JToken, Int32> callback; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal void <GetRanks>b__0(JObject jObj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Action<Int32> callback; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal void <UploadScore>b__0(JObject jObj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public Action callback; //Field offset: 0x10
		public GameAccountSystem <>4__this; //Field offset: 0x18

		public <>c__DisplayClass61_0() { }

		internal void <OnSaveSelectCallback>b__0() { }

		internal void <OnSaveSelectCallback>b__1(JObject o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public DateTime dateTime; //Field offset: 0x10
		public Action<DateTime> callback; //Field offset: 0x18

		public <>c__DisplayClass64_0() { }

		internal void <GetTime>b__0(JObject result) { }

		internal void <GetTime>b__1(long code, string error) { }

	}

	[CompilerGenerated]
	private struct <StartWebSocket>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameAccountSystem <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private Byte[] <result>5__2; //Field offset: 0x38
		private TaskAwaiter<WebSocketReceiveResult> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int call_xd_panel_fail = 1; //Field offset: 0x0
	private const int call_xd_http_fail = 2; //Field offset: 0x0
	private const int call_pero_http_fail = 3; //Field offset: 0x0
	private const int call_3rd_fail = 4; //Field offset: 0x0
	private static GameAccountSystem s_Instance; //Field offset: 0x0
	public bool showTip; //Field offset: 0x58
	[CompilerGenerated]
	private bool <isInited>k__BackingField; //Field offset: 0x59
	public UserBindInfo jObjUserInfo; //Field offset: 0x60
	public JObject jObjLoginInfo; //Field offset: 0x68
	private ClientWebSocket m_WebSocket; //Field offset: 0x70
	private CancellationToken m_CancellationToken; //Field offset: 0x78
	public Action<WebSocketState> onWebSocketState; //Field offset: 0x80
	public Action onConnectError; //Field offset: 0x88
	public Action<String> onMessage; //Field offset: 0x90

	public static GameAccountSystem instance
	{
		 get { } //Length: 256
	}

	public private bool isInited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool isOversea
	{
		 get { } //Length: 3
	}

	public AccountPlatform platform
	{
		 get { } //Length: 80
	}

	public string platform_name
	{
		 get { } //Length: 188
	}

	public UserInfo userInfo
	{
		 get { } //Length: 93
	}

	public GameAccountSystem() { }

	[CompilerGenerated]
	private void <CheckLeaderboardBan>b__56_0(JObject token) { }

	[CompilerGenerated]
	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator <Login>g__LocalLogin|27_0() { }

	[CompilerGenerated]
	private void <OnOverseasLoginSucceed>b__33_0(JObject jObj) { }

	[CompilerGenerated]
	private void <OnOverseasLoginSucceed>b__33_1(long code, string error) { }

	[CompilerGenerated]
	private void <Synchronize>b__60_0(JObject jObj) { }

	public void BanPlayer(bool isBan) { }

	private void BanTip(Scene scene, LoadSceneMode mode) { }

	public void CheckLeaderboardBan() { }

	public void CheckPayment(Action<JObject> succeedCallback, Action<Int64, String> failCallback) { }

	public static GameAccountSystem get_instance() { }

	[CompilerGenerated]
	public bool get_isInited() { }

	public bool get_isOversea() { }

	public AccountPlatform get_platform() { }

	public string get_platform_name() { }

	public UserInfo get_userInfo() { }

	public string GetDeviceID() { }

	public string GetHost() { }

	public SystemLanguage GetLanguage() { }

	public void GetRanks(string musicUid, int difficulty, Action<JToken, JToken, Int32> callback, Action<Int64, String> failCallback) { }

	public void GetTime(Action<DateTime> callback) { }

	public Coroutine GetUserInfo(Action callback = null) { }

	public void Init(string settingName) { }

	public bool IsBind() { }

	public bool IsLoggedIn() { }

	public bool IsOverSeaFromPlayerPrefs() { }

	public void IsRealName(Action<Boolean, Boolean> callback) { }

	public bool IsUserOverseas() { }

	public void Login() { }

	public void Logout() { }

	protected virtual bool OnHeartbeat(HeartbeatResp req) { }

	private void OnLoginFinished(JObject jObj) { }

	public void OnLoginSuccess(string accessToken) { }

	public void OnOverseasLoginSucceed(string sid) { }

	public void OnPCOverseasLoginSucceed(string openid, string p) { }

	public void OnSaveSelectCallback(bool isLocal, Dictionary<String, IData> datas, JToken jsonDatas, Action callback = null) { }

	public void OpenRealName(Action failCallback, Action succeedCallback) { }

	public void Pay(string productId, int price, int realnameType = 0, int adultType = 0, Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	public void PhoneMailBind(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	private Dictionary<String, Object> PrepareUploadScore(string musicUid, int musicDifficulty, string characterUid, string elfinUid, int hp, int score, float acc, int maximumCombo, string evaluate, int miss, List<Beat> beats, string bmsVersion) { }

	public void RefreshDatas() { }

	public void Send(int type) { }

	public void SendFavoriteMusic(List<String> uidsBuffer, string addMusicUid = "", string removeMusicUid = "", Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null) { }

	public void SendLoginFail(string errSdkMsg, int code, int type, UnityWebRequest request, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null) { }

	public PeroWebRequest SendToUrl(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null) { }

	public PeroWebRequest SendToUserUrl(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null) { }

	[CompilerGenerated]
	private void set_isInited(bool value) { }

	public void SetPlayerName(string nickName, Action<Int32> callback, Action<Int64, String> failCallback) { }

	public void StartHeartbeat() { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void StartWebSocket() { }

	public void StopWebSocket() { }

	public void Synchronize() { }

	public void ThirdPartLogin(string _platform) { }

	public void TotalLogout() { }

	public void UpdateLanguage() { }

	public void UploadScore(string musicUid, int musicDifficulty, string characterUid, string elfinUid, int hp, int score, float acc, int maximumCombo, string evaluate, int miss, List<Beat> beats, string bmsVersion, Action<Int32> callback) { }

}

