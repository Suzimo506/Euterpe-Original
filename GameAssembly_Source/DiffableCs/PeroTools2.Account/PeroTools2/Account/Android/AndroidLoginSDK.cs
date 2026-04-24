namespace PeroTools2.Account.Android;

internal class AndroidLoginSDK
{
	private static AndroidJavaClass s_LoginManager; //Field offset: 0x6AD10
	private const string login_pkg_name = "net.peropero.perosdk.LoginManager"; //Field offset: 0x2C927B4

	public AndroidLoginSDK() { }

	private static AndroidJavaClass GetLoginManager() { }

	public static void Login(string platform, string appId, AndroidSDKCallback callback) { }

}

