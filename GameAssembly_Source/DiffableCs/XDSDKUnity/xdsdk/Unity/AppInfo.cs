namespace xdsdk.Unity;

public class AppInfo
{
	private string id; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private string pingppAppID; //Field offset: 0x20
	private string wxAppID; //Field offset: 0x28
	private string qqAppID; //Field offset: 0x30
	private string bundleID; //Field offset: 0x38
	private string alipayEname; //Field offset: 0x40
	private string ename; //Field offset: 0x48
	private string wxQRCodeAppID; //Field offset: 0x50
	private string kfApp; //Field offset: 0x58
	private string relationConfirmed; //Field offset: 0x60
	private string taptapClientID; //Field offset: 0x68
	private string tapdbAppID; //Field offset: 0x70
	private string kefuLink; //Field offset: 0x78
	private long needLoginRealName; //Field offset: 0x80
	private long needChargeRealName; //Field offset: 0x88
	private long needRegisterRealName; //Field offset: 0x90

	public string AlipayEname
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string BundleID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string Ename
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string Id
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string KefuLink
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string KfApp
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public long NeedChargeRealName
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public long NeedLoginRealName
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public long NeedRegisterRealName
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string PingppAppID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string QqAppID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string RelationConfirmed
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string TapdbAppID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string TaptapClientID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string WxAppID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string WxQRCodeAppID
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public AppInfo() { }

	public string get_AlipayEname() { }

	public string get_BundleID() { }

	public string get_Ename() { }

	public string get_Id() { }

	public string get_KefuLink() { }

	public string get_KfApp() { }

	public string get_Name() { }

	public long get_NeedChargeRealName() { }

	public long get_NeedLoginRealName() { }

	public long get_NeedRegisterRealName() { }

	public string get_PingppAppID() { }

	public string get_QqAppID() { }

	public string get_RelationConfirmed() { }

	public string get_TapdbAppID() { }

	public string get_TaptapClientID() { }

	public string get_WxAppID() { }

	public string get_WxQRCodeAppID() { }

	public static AppInfo InitWithDict(Dictionary<String, Object> appinfoDict) { }

	public void set_AlipayEname(string value) { }

	public void set_BundleID(string value) { }

	public void set_Ename(string value) { }

	public void set_Id(string value) { }

	public void set_KefuLink(string value) { }

	public void set_KfApp(string value) { }

	public void set_Name(string value) { }

	public void set_NeedChargeRealName(long value) { }

	public void set_NeedLoginRealName(long value) { }

	public void set_NeedRegisterRealName(long value) { }

	public void set_PingppAppID(string value) { }

	public void set_QqAppID(string value) { }

	public void set_RelationConfirmed(string value) { }

	public void set_TapdbAppID(string value) { }

	public void set_TaptapClientID(string value) { }

	public void set_WxAppID(string value) { }

	public void set_WxQRCodeAppID(string value) { }

}

