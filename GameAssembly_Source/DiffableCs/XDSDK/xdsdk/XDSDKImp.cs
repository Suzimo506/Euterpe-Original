namespace xdsdk;

public class XDSDKImp : XDSDKInterface
{
	private static XDSDKImp _instance; //Field offset: 0x0
	public XDCallback xdCallback; //Field offset: 0x10

	public XDSDKImp() { }

	[CompilerGenerated]
	private void <SetCallback>b__3_0(ResultCode code, string data) { }

	public override void AppleLogin() { }

	public override void AutoLogin() { }

	public override void ClearRole() { }

	public override void Exit() { }

	public override void GameResume() { }

	public override void GameStop() { }

	public override string GetAccessToken() { }

	public override string GetAdChannelName() { }

	public static XDSDKImp GetInstance() { }

	public override string GetSDKVersion() { }

	public XDCallback GetXDCallback() { }

	public override void GuestLogin() { }

	public override void HideGuest() { }

	public override void HideQQ() { }

	public override void HideTapTap() { }

	public override void HideWX() { }

	public override void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapDB) { }

	public override void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapdb, bool enableMoment) { }

	public override bool IsLoggedIn() { }

	public override void Login() { }

	public override void Logout() { }

	public override void OnResume() { }

	public override void OnStop() { }

	public override void OpenProtocol(ProtocolType type) { }

	public override void OpenRealName() { }

	public override void OpenUserBindView() { }

	public override bool OpenUserCenter() { }

	public override void OpenUserMoment(XDMomentConfig config, string xdId) { }

	public override bool Pay(Dictionary<String, String> info) { }

	public override void RestorePay(Dictionary<String, String> info) { }

	public override void SetCallback(XDCallback callback) { }

	public override void SetLevel(int level) { }

	public override void SetLoginEntries(String[] entries) { }

	public override void SetQQWeb() { }

	public override void SetRole(string roleId, string roleName, string roleAvatar) { }

	public override void SetServer(string server) { }

	public override void SetWXWeb() { }

	public override void Share(Dictionary<String, String> content) { }

	public override void ShowVC() { }

	public override void TapTapLogin() { }

	private static string UnityGetAccessToken() { }

	private static string UnityGetSdkVersion() { }

	private static void UnityInit(string appid) { }

	private static bool UnityIsLoggedIn() { }

	private static void UnityLogin() { }

	private static void UnityLogout() { }

	private static void UnityOpenRealName() { }

	private static void UnityPay(string proudct_name, string product_id, int product_price, string sid, string role_id, string order_id, string ext) { }

	private static void UnitySetCallback(UniversalCallbackDelegate universalCallback) { }

	private static void UnitySetLoginEntries(String[] entries, int length) { }

	public override void UserFeedback() { }

}

