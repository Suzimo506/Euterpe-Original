namespace xdsdk.Unity;

public class XDSDK
{
	public static string VERSION; //Field offset: 0x6AC58

	private static XDSDK() { }

	public XDSDK() { }

	public static string GetAccessToken() { }

	public static void Init(string appid) { }

	public static void Login() { }

	public static void Logout() { }

	public static void OpenRealName() { }

	public static void Pay(Dictionary<String, String> info) { }

	public static void SetCallback(Action<ResultCode, String> callback) { }

	public static void SetLoginEntries(String[] entries) { }

}

