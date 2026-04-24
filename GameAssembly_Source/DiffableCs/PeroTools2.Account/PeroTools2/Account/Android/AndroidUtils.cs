namespace PeroTools2.Account.Android;

public static class AndroidUtils
{
	private static AndroidJavaClass s_Toaster; //Field offset: 0x0
	private const string toaster_pkg_name = "net.peropero.perosdk.Toaster"; //Field offset: 0x0
	private const string blocker_pkg_name = "net.peropero.perosdk.Blocker"; //Field offset: 0x0
	private static AndroidJavaClass s_Blocker; //Field offset: 0x8

	public static void BlockAllClick() { }

	private static AndroidJavaClass GetBlocker() { }

	private static AndroidJavaClass GetToaster() { }

	public static void Toast(string msg) { }

	public static void UnblockAllClick() { }

}

