namespace xdsdk.Unity.Service;

public static class Login
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public string openID; //Field offset: 0x10
		public string accessToken; //Field offset: 0x18
		public string appid; //Field offset: 0x20
		public Action<Dictionary`2<String, Object>> methodForResult; //Field offset: 0x28
		public Action<String> methodForError; //Field offset: 0x30
		public Action<String> <>9__3; //Field offset: 0x38

		public <>c__DisplayClass0_0() { }

		internal void <QQ>b__0(string token) { }

		internal void <QQ>b__1(string error) { }

		internal void <QQ>b__3(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_1
	{
		public string token; //Field offset: 0x10
		public <>c__DisplayClass0_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass0_1() { }

		internal void <QQ>b__2(User user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public string appid; //Field offset: 0x10
		public Action<Dictionary`2<String, Object>> methodForResult; //Field offset: 0x18
		public Action<String> methodForError; //Field offset: 0x20
		public Action<String> <>9__3; //Field offset: 0x28

		public <>c__DisplayClass1_0() { }

		internal void <Wechat>b__0(string token, string refreshToken) { }

		internal void <Wechat>b__1(string error) { }

		internal void <Wechat>b__3(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_1
	{
		public string token; //Field offset: 0x10
		public string refreshToken; //Field offset: 0x18
		public <>c__DisplayClass1_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass1_1() { }

		internal void <Wechat>b__2(User user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string macKey; //Field offset: 0x10
		public string kid; //Field offset: 0x18
		public string tokenType; //Field offset: 0x20
		public string accessToken; //Field offset: 0x28
		public string macAlgorithm; //Field offset: 0x30
		public string appid; //Field offset: 0x38
		public Action<Dictionary`2<String, Object>> methodForResult; //Field offset: 0x40
		public Action<String> methodForError; //Field offset: 0x48
		public Action<String> <>9__3; //Field offset: 0x50

		public <>c__DisplayClass2_0() { }

		internal void <TapTap>b__0(string token) { }

		internal void <TapTap>b__1(string error) { }

		internal void <TapTap>b__3(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public string token; //Field offset: 0x10
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass2_1() { }

		internal void <TapTap>b__2(User user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action<Dictionary`2<String, Object>> methodForResult; //Field offset: 0x10
		public Action<String, Object> methodForError; //Field offset: 0x18
		public Action<String> <>9__3; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <XD>b__0(string token) { }

		internal void <XD>b__1(string errorType, object errorContent) { }

		internal void <XD>b__3(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public string token; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass3_1() { }

		internal void <XD>b__2(User user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Action<Dictionary`2<String, Object>> methodForResult; //Field offset: 0x10
		public Action<String, Object> methodForError; //Field offset: 0x18
		public Action<String> <>9__3; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <XD>b__0(string token) { }

		internal void <XD>b__1(string errorType, object errorContent) { }

		internal void <XD>b__3(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public string token; //Field offset: 0x10
		public <>c__DisplayClass4_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass4_1() { }

		internal void <XD>b__2(User user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <VerificationCode>b__0(string result) { }

		internal void <VerificationCode>b__1(string errorType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action<User> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <User>b__0(User result) { }

		internal void <User>b__1(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Action<String> methodForResult; //Field offset: 0x10
		public Action<String> methodForError; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <RealName>b__0(string result) { }

		internal void <RealName>b__1(string error) { }

	}


	public static void Logout(Action method) { }

	private static string Md5Sum(string strToEncrypt) { }

	public static void QQ(string appid, string openID, string accessToken, Action<Dictionary`2<String, Object>> methodForResult, Action<String> methodForError) { }

	public static void RealName(string accessToken, string name, string id, Action<String> methodForResult, Action<String> methodForError) { }

	public static void TapTap(string appid, string kid, string accessToken, string tokenType, string macKey, string macAlgorithm, Action<Dictionary`2<String, Object>> methodForResult, Action<String> methodForError) { }

	public static void User(string accessToken, Action<User> methodForResult, Action<String> methodForError) { }

	public static void VerificationCode(string appid, string userID, Action<String> methodForResult, Action<String> methodForError) { }

	public static void Wechat(string appid, string code, Action<Dictionary`2<String, Object>> methodForResult, Action<String> methodForError) { }

	public static void XD(string appid, string username, string password, string code, Action<Dictionary`2<String, Object>> methodForResult, Action<String, Object> methodForError) { }

	public static void XD(string appid, string username, string password, Action<Dictionary`2<String, Object>> methodForResult, Action<String, Object> methodForError) { }

}

