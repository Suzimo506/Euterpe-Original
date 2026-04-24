namespace xdsdk.Unity;

public class MainLoginWindow : UIElement
{
	private AppInfo appInfo; //Field offset: 0x58
	private LoginEntry loginEntry; //Field offset: 0x60
	public Button loginButton1st; //Field offset: 0x68
	public Button loginButton2nd; //Field offset: 0x70
	public Button loginButton3rd; //Field offset: 0x78
	public Button loginButton4th; //Field offset: 0x80
	public Button close; //Field offset: 0x88

	public virtual Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 567
	}

	public MainLoginWindow() { }

	[CompilerGenerated]
	private void <HandleQQLogin>b__20_0(Dictionary<String, Object> resultDict) { }

	[CompilerGenerated]
	private void <HandleQQLogin>b__20_1(string error) { }

	[CompilerGenerated]
	private void <HandleTapLogin>b__22_0(Dictionary<String, Object> resultDict) { }

	[CompilerGenerated]
	private void <HandleTapLogin>b__22_1(string error) { }

	[CompilerGenerated]
	private void <HandleWXLogin>b__21_0(Dictionary<String, Object> resultDict) { }

	[CompilerGenerated]
	private void <HandleWXLogin>b__21_1(string error) { }

	[CompilerGenerated]
	private void <LoginByType>b__19_0(int code, object data) { }

	[CompilerGenerated]
	private void <LoginByType>b__19_1(int code, object data) { }

	[CompilerGenerated]
	private void <LoginByType>b__19_2(int code, object data) { }

	[CompilerGenerated]
	private void <LoginByType>b__19_3(int code, object data) { }

	private void Awake() { }

	private void ChangeButtonSprite(Button button, string spriteName) { }

	private void ChangeLoginEntries() { }

	private void ChangeLoginEntry(Button button, Type type, string position) { }

	protected virtual void FocusTo(GameObject go) { }

	public virtual Dictionary<String, Object> get_Extra() { }

	private void HandleQQLogin(string url) { }

	private void HandleTapLogin(string url) { }

	private void HandleWXLogin(string url) { }

	public void LoginByType(Type type) { }

	private void OnCloseClicked() { }

	private void OnFirstEntryClicked() { }

	private void OnFourthEntryClicked() { }

	private void OnSecondEntryClicked() { }

	private void OnThirdEntryClicked() { }

	public virtual void set_Extra(Dictionary<String, Object> value) { }

}

