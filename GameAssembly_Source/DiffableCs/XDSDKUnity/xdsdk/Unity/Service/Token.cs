namespace xdsdk.Unity.Service;

public static class Token
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Action callback; //Field offset: 0x10
		public string appid; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <CheckThirdPartyToken>b__0() { }

		internal void <CheckThirdPartyToken>b__1(int code) { }

		internal void <CheckThirdPartyToken>b__2() { }

		internal void <CheckThirdPartyToken>b__3(int code) { }

		internal void <CheckThirdPartyToken>b__4() { }

		internal void <CheckThirdPartyToken>b__5(int code) { }

	}

	internal enum ThirdPartyTokenType
	{
		Wechat = 0,
		QQ = 1,
		TapTap = 2,
	}

	private static readonly string TOKEN_KEY; //Field offset: 0x0
	private static readonly string THIRD_PARTY_TOKEN_KEY; //Field offset: 0x8
	private static readonly string THIRD_PARTY_TOKEN_CHECK_FAILED_TIMESTAMP; //Field offset: 0x10
	private static readonly double THIRD_PARTY_TOKEN_VERIFY_TIME; //Field offset: 0x18

	private static Token() { }

	public static void CheckThirdPartyToken(string appid, Action callback) { }

	private static void ClearThirdPartyToken(string appid) { }

	public static void ClearToken(string appid) { }

	public static string GetToken(string appid) { }

	public static bool HasThirdPartyToken(string appid) { }

	public static void SetThirdPartyToken(string appid, ThirdPartyTokenType type, Dictionary<String, String> tokenDict) { }

	public static void SetToken(string appid, string token) { }

}

