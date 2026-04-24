namespace PeroTools2.Account;

public abstract class AccountSystem : SerializedMonoBehaviour
{

	protected string authToken
	{
		 get { } //Length: 35
	}

	protected string gameAuthToken
	{
		 get { } //Length: 35
	}

	protected string gameId
	{
		 get { } //Length: 33
	}

	protected bool isOversea
	{
		 get { } //Length: 33
	}

	protected override int timeout
	{
		 get { } //Length: 6
	}

	protected UserInfo userInfo
	{
		 get { } //Length: 113
	}

	protected AccountSystem() { }

	protected string get_authToken() { }

	protected string get_gameAuthToken() { }

	protected string get_gameId() { }

	protected bool get_isOversea() { }

	protected override int get_timeout() { }

	protected UserInfo get_userInfo() { }

	protected string GetHost() { }

	protected void GetUserHaving(Action<String[]> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	protected void GetUserHaving(AccountCallback callback) { }

	protected string GetUserHost() { }

	protected void Init(string setting, SystemLanguage language, string platform) { }

	protected bool IsLoggedIn() { }

	protected void Logout() { }

	protected override bool OnHeartbeat(HeartbeatResp arg) { }

	protected void OpenLogin(AccountCallback callback) { }

	protected void OpenLogin(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	protected void OpenPayment(string productId, int price, int realnameType, int adultType, AccountCallback callback) { }

	protected void OpenPayment(string productId, int price, int realnameType, int adultType, Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	protected void OpenPhoneMailBind(AccountCallback callback) { }

	protected void OpenPhoneMailBind(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	protected void OpenRealName(AccountCallback callback, bool closeable = true) { }

	protected void OpenRealName(Action<String> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null, bool closeable = true) { }

	protected void PhoneEmailBind(string platform, string number, string code) { }

	protected void PhoneEmailLogin(string platform, string number, string code) { }

	protected void QueryHasProduct(string productId, Action<Boolean> succeed = null, Action<Int32, String> failed = null, Action started = null, Action completed = null) { }

	protected void QueryHasProduct(string productId, AccountCallback callback) { }

	protected void RealName(string realName, string numberId) { }

	protected PeroWebRequest SendToGameBackend(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null) { }

	protected PeroWebRequest SendToUserBackend(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null) { }

	protected void SendVerifyCode() { }

	protected void SetBindCallback(AccountCallback callback) { }

	protected void SetLanguage(SystemLanguage language) { }

	protected void SetLoginCallback(AccountCallback callback) { }

	protected void SetPaymentCallback(AccountCallback callback) { }

	protected void SetRealNameCallback(AccountCallback callback) { }

	protected void StartHeartbeat() { }

	protected void StopHeartbeat() { }

	protected void ThirdPartLogin(string platform) { }

}

