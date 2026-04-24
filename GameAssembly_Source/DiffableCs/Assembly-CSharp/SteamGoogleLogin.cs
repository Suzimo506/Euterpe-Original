//Type is in global namespace

public class SteamGoogleLogin : SingletonMonoBehaviour<SteamGoogleLogin>
{
	[CompilerGenerated]
	private sealed class <WaitWebInit>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <WaitWebInit>d__18(int <>1__state) { }

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

	private static bool m_IsInited; //Field offset: 0x0
	private HttpListener listener; //Field offset: 0x18
	private Thread listenerThread; //Field offset: 0x20
	private UnityWebRequest m_WebRequest; //Field offset: 0x28
	public bool m_IsGoogleLogin; //Field offset: 0x30
	private string m_CallbackContext; //Field offset: 0x38
	private string m_AccessToken; //Field offset: 0x40
	private string m_IdToken; //Field offset: 0x48
	private string m_OpenId; //Field offset: 0x50
	private string m_Email; //Field offset: 0x58
	private string m_Sid; //Field offset: 0x60
	private bool m_RunCallback; //Field offset: 0x68
	private bool m_RunGetOpenId; //Field offset: 0x69
	private bool m_RunTxwy; //Field offset: 0x6A
	[SerializeField]
	private bool m_CanRunCallbackWebRequest; //Field offset: 0x6B
	private bool m_WhileRunCallbackWebRequest; //Field offset: 0x6C
	private bool m_CanRunGetOpenIdRequest; //Field offset: 0x6D
	private bool m_WhileRunGetOpenId; //Field offset: 0x6E
	private bool m_CanRunTxwyRequest; //Field offset: 0x6F
	private bool m_WhileCanRunTxwy; //Field offset: 0x70
	private bool m_WhileRunFail; //Field offset: 0x71
	private bool m_StartListener; //Field offset: 0x72
	private IAsyncResult m_Result; //Field offset: 0x78
	private string m_Prefix; //Field offset: 0x80
	private string base_login_url; //Field offset: 0x88
	private string redirect_url; //Field offset: 0x90
	private string scope; //Field offset: 0x98
	private string google_appID; //Field offset: 0xA0
	private string google_appKey; //Field offset: 0xA8
	private string stateKey; //Field offset: 0xB0
	private string access_token_url; //Field offset: 0xB8
	private string m_NewCode; //Field offset: 0xC0
	private string m_NewState; //Field offset: 0xC8
	private string m_CallbackDataBody; //Field offset: 0xD0
	private Dictionary<String, String> m_body; //Field offset: 0xD8
	private bool m_IsCallbackCheckOver; //Field offset: 0xE0
	private bool m_IsCallBackPostOver; //Field offset: 0xE1
	private bool m_IsCallBackPostFail; //Field offset: 0xE2
	private string m_AuthEmail; //Field offset: 0xE8
	private string m_AuthUserId; //Field offset: 0xF0
	private string m_BaseOpenIdUrl; //Field offset: 0xF8
	private bool m_IsGetOpenIdCheckOver; //Field offset: 0x100
	private bool m_IsGetOpenIdRunOver; //Field offset: 0x101
	private bool m_RunGetOpenIdFail; //Field offset: 0x102
	private string m_TxwyId; //Field offset: 0x108
	private string m_TxwyAppKey; //Field offset: 0x110
	private string m_TxwyParams; //Field offset: 0x118
	private bool m_IsGetTxwyCheckOver; //Field offset: 0x120
	private bool m_IsGetTxwyRunOver; //Field offset: 0x121
	private bool m_RunTxwyFail; //Field offset: 0x122
	private bool m_IsRunPlayBackGameCheckOver; //Field offset: 0x123
	public bool m_IsRunPlayBackGameOver; //Field offset: 0x124
	private bool m_IsFinishToShow; //Field offset: 0x125

	public SteamGoogleLogin() { }

	public void CheckIsGoogleLogin() { }

	private void GetOpenId(HttpListenerContext context, string accessToken) { }

	private string GetRandomString() { }

	private void IsAuth(HttpListenerContext context) { }

	private void IsCallBack(HttpListenerContext context) { }

	private void IsFail(HttpListenerContext context) { }

	private void IsFinish(HttpListenerContext context) { }

	private void IsPlayBackGame(HttpListenerContext context) { }

	private void IsTxwy(HttpListenerContext context) { }

	private void ListenerCallback(IAsyncResult result) { }

	public string Md5Sum(string strToEncrypt) { }

	private void OnDestroy() { }

	public void OnWebEnd() { }

	public void OnWebInit() { }

	private void OnWebRequestCompleted(AsyncOperation ao) { }

	public void OpenWeb() { }

	private void Start() { }

	private void startListener() { }

	private void Update() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator WaitWebInit() { }

}

