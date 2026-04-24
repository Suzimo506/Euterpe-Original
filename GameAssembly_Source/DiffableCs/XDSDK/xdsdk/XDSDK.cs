namespace xdsdk;

public class XDSDK
{
	internal enum ProtocolType
	{
		PROTOCOL_TYPE_USER = 0,
		PROTOCOL_TYPE_GAME = 1,
		PROTOCOL_TYPE_PRIVACY = 2,
	}


	public XDSDK() { }

	public static void AppleLogin() { }

	public static void AutoLogin() { }

	public static void ClearRole() { }

	public static void Exit() { }

	public static void GameResume() { }

	public static void GameStop() { }

	public static string GetAccessToken() { }

	public static string GetAdChannelName() { }

	public static string GetSDKVersion() { }

	private static XDSDKInterface getXDSDKImp() { }

	public static void GuestLogin() { }

	public static void HideGuest() { }

	public static void HideQQ() { }

	public static void HideTapTap() { }

	public static void HideWX() { }

	public static void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapdb) { }

	public static void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapdb, bool enableMoment) { }

	public static bool IsLoggedIn() { }

	public static void Login() { }

	public static void Logout() { }

	public static void OnResume() { }

	public static void OnStop() { }

	public static void OpenProtocol(ProtocolType type) { }

	public static void OpenRealName() { }

	public static void OpenUserBindView() { }

	public static bool OpenUserCenter() { }

	public static void OpenUserMoment(XDMomentConfig config, string xdId) { }

	public static bool Pay(Dictionary<String, String> info) { }

	public static void RestorePay(Dictionary<String, String> info) { }

	public static void SetCallback(XDCallback callback) { }

	public static void SetLevel(int level) { }

	public static void SetLoginEntries(String[] entries) { }

	public static void SetQQWeb() { }

	public static void SetRole(string roleId, string roleName, string roleAvatar) { }

	public static void SetServer(string server) { }

	public static void SetWXWeb() { }

	public static void Share(Dictionary<String, String> content) { }

	public static void ShowVC() { }

	public static void TapTapLogin() { }

	public static void UserFeedback() { }

}

