namespace PeroTools2.Account.Internal;

internal class AccountSetting : SingletonScriptableObject<AccountSetting>
{
	internal struct LoginInfo
	{
		[ConstGroupDrawer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string platform; //Field offset: 0x0
		public string iOSAppId; //Field offset: 0x8
		public string androidAppId; //Field offset: 0x10
		public string webAppId; //Field offset: 0x18

	}

	internal struct PaymentInfo
	{
		[ConstGroupDrawer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string platform; //Field offset: 0x0
		public string appId; //Field offset: 0x8

	}

	internal class Setting
	{
		public string gameBackendUrl; //Field offset: 0x10
		public string userSystemBackendUrl; //Field offset: 0x18
		public string overseaUserSystemBackendUrl; //Field offset: 0x20

		public Setting() { }

	}

	public bool enable; //Field offset: 0x58
	public string gameId; //Field offset: 0x60
	public string universalLinks; //Field offset: 0x68
	public List<LoginInfo> loginInfos; //Field offset: 0x70
	public List<PaymentInfo> paymentInfo; //Field offset: 0x78
	[SerializeField]
	private Dictionary<String, Setting> m_Settings; //Field offset: 0x80

	public AccountSetting() { }

	public Setting GetSetting(string settingName) { }

}

