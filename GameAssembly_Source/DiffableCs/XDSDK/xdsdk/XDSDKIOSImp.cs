namespace xdsdk;

public class XDSDKIOSImp : XDSDKInterface
{
	private sealed class XDSDKMessageCallback : MulticastDelegate
	{

		public XDSDKMessageCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string method, string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string method, string message) { }

	}

	private static XDSDKIOSImp _instance; //Field offset: 0x0
	private static XDCallback xdCallback; //Field offset: 0x8

	public XDSDKIOSImp() { }

	public override void AppleLogin() { }

	public override void AutoLogin() { }

	public override void ClearRole() { }

	public override void Exit() { }

	public override void GameResume() { }

	public override void GameStop() { }

	public override string GetAccessToken() { }

	public override string GetAdChannelName() { }

	public static XDSDKIOSImp GetInstance() { }

	public override string GetSDKVersion() { }

	public XDCallback GetXDCallback() { }

	public override void GuestLogin() { }

	public override void HideGuest() { }

	public override void HideQQ() { }

	public override void HideTapTap() { }

	public override void HideWX() { }

	public override void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapDB) { }

	public override void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapDB, bool enableMoment) { }

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

	public override void UserFeedback() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void XDSDKCallbackImp(string method, string message) { }

}

