namespace xdsdk;

public interface XDSDKInterface
{

	public void AppleLogin() { }

	public void AutoLogin() { }

	public void ClearRole() { }

	public void Exit() { }

	public void GameResume() { }

	public void GameStop() { }

	public string GetAccessToken() { }

	public string GetAdChannelName() { }

	public string GetSDKVersion() { }

	public void GuestLogin() { }

	public void HideGuest() { }

	public void HideQQ() { }

	public void HideTapTap() { }

	public void HideWX() { }

	public void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapdb) { }

	public void InitSDK(string appid, int aOrientation, string channel, string version, bool enableTapdb, bool enableMoment) { }

	public bool IsLoggedIn() { }

	public void Login() { }

	public void Logout() { }

	public void OnResume() { }

	public void OnStop() { }

	public void OpenProtocol(ProtocolType type) { }

	public void OpenRealName() { }

	public void OpenUserBindView() { }

	public bool OpenUserCenter() { }

	public void OpenUserMoment(XDMomentConfig config, string xdId) { }

	public bool Pay(Dictionary<String, String> info) { }

	public void RestorePay(Dictionary<String, String> info) { }

	public void SetCallback(XDCallback callback) { }

	public void SetLevel(int level) { }

	public void SetLoginEntries(String[] entries) { }

	public void SetQQWeb() { }

	public void SetRole(string roleId, string roleName, string roleAvatar) { }

	public void SetServer(string server) { }

	public void SetWXWeb() { }

	public void Share(Dictionary<String, String> content) { }

	public void ShowVC() { }

	public void TapTapLogin() { }

	public void UserFeedback() { }

}

