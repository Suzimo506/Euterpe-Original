namespace xdsdk.Unity.Service;

public class Api
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Action<AppInfo> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <InitSDK>b__0(string data) { }

		internal void <InitSDK>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <LoginQQ>b__0(string data) { }

		internal void <LoginQQ>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Action<String, String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <LoginWechat>b__0(string data) { }

		internal void <LoginWechat>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <LoginTapTap>b__0(string data) { }

		internal void <LoginTapTap>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Action<String, Object> methodForError; //Field offset: 0x10
		public Action<String> methodForResult; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <LoginXD>b__0(string data) { }

		internal void <LoginXD>b__1(int errorCode, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <FetchVerificationCode>b__0(string result) { }

		internal void <FetchVerificationCode>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Action<User> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <GetUser>b__0(string result) { }

		internal void <GetUser>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <VerifyRealName>b__0(string result) { }

		internal void <VerifyRealName>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Action method; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal void <Logout>b__0(string result) { }

		internal void <Logout>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public Action success; //Field offset: 0x10
		public Action<Int32> failed; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <CheckWeChatToken>b__0(string result) { }

		internal void <CheckWeChatToken>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Action success; //Field offset: 0x10
		public Action<Int32> failed; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <CheckQQToken>b__0(string result) { }

		internal void <CheckQQToken>b__1(int code, string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public Action success; //Field offset: 0x10
		public Action<Int32> failed; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <CheckTapTapToken>b__0(string result) { }

		internal void <CheckTapTapToken>b__1(int code, string error) { }

	}

	private static Api instance; //Field offset: 0x0
	private static GameObject netObject; //Field offset: 0x8
	private static readonly string BASE_URL; //Field offset: 0x10
	private static readonly string BASE_URL_V2; //Field offset: 0x18
	private static readonly string INIT_SDK; //Field offset: 0x20
	private static readonly string XD_AUTH; //Field offset: 0x28
	private static readonly string QQ_AUTH; //Field offset: 0x30
	private static readonly string WX_AUTH; //Field offset: 0x38
	private static readonly string TAP_AUTH; //Field offset: 0x40
	private static readonly string VERIFY_CODE; //Field offset: 0x48
	private static readonly string WX_CHECK; //Field offset: 0x50
	private static readonly string QQ_CHECK; //Field offset: 0x58
	private static readonly string TAPTAP_CHECK; //Field offset: 0x60
	private static readonly string USER; //Field offset: 0x68
	private static readonly string REALNAME; //Field offset: 0x70
	private static readonly string LOGOUT; //Field offset: 0x78

	public static Api Instance
	{
		 get { } //Length: 607
	}

	private static Api() { }

	public Api() { }

	public void CheckQQToken(string appid, string openid, string token, string authType, Action success, Action<Int32> failed) { }

	public void CheckTapTapToken(string appid, string macKey, string kid, string tokenType, string accessToken, string macAlgorithm, string authType, Action success, Action<Int32> failed) { }

	public void CheckWeChatToken(string appid, string refreshToken, string authType, Action success, Action<Int32> failed) { }

	public void FetchVerificationCode(string appid, string userID, Action<String> methodForResult, Action<String> methodForError) { }

	public static Api get_Instance() { }

	public void GetUser(string token, Action<User> methodForResult, Action<String> methodForError) { }

	private void Init() { }

	public void InitSDK(string appid, Action<AppInfo> methodForResult, Action<String> methodForError) { }

	public void LoginQQ(string appid, string openID, string accessToken, Action<String> methodForResult, Action<String> methodForError) { }

	public void LoginTapTap(string appid, string kid, string accessToken, string tokenType, string macKey, string macAlgorithm, Action<String> methodForResult, Action<String> methodForError) { }

	public void LoginWechat(string appid, string wechatCode, Action<String, String> methodForResult, Action<String> methodForError) { }

	public void LoginXD(string appid, string username, string password, string captcha, string code, Action<String> methodForResult, Action<String, Object> methodForError) { }

	public void Logout(Action method) { }

	public void VerifyRealName(string token, string name, string id, Action<String> methodForResult, Action<String> methodForError) { }

}

