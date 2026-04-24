namespace xdsdk.Unity;

public class TwoFactorAuthWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public User user; //Field offset: 0x10
		public string token; //Field offset: 0x18
		public TwoFactorAuthWindow <>4__this; //Field offset: 0x20

		public <>c__DisplayClass17_0() { }

		internal void <Awake>b__9(int code, object result) { }

	}

	private static double lastFetchTime; //Field offset: 0x0
	private static DateTime dateTime; //Field offset: 0x8
	private AppInfo appInfo; //Field offset: 0x58
	private long userID; //Field offset: 0x60
	private string username; //Field offset: 0x68
	private string password; //Field offset: 0x70
	public Button close; //Field offset: 0x78
	public Button back; //Field offset: 0x80
	public Text mobile; //Field offset: 0x88
	public InputField code; //Field offset: 0x90
	public Button send; //Field offset: 0x98
	public Button confirm; //Field offset: 0xA0
	public Text errorText; //Field offset: 0xA8
	public Image errorIcon; //Field offset: 0xB0

	public virtual Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 676
	}

	private static TwoFactorAuthWindow() { }

	public TwoFactorAuthWindow() { }

	[CompilerGenerated]
	private void <Awake>b__17_0() { }

	[CompilerGenerated]
	private void <Awake>b__17_1() { }

	[CompilerGenerated]
	private void <Awake>b__17_2() { }

	[CompilerGenerated]
	private void <Awake>b__17_3() { }

	[CompilerGenerated]
	private void <Awake>b__17_4(string content) { }

	[CompilerGenerated]
	private void <Awake>b__17_5(string result) { }

	[CompilerGenerated]
	private void <Awake>b__17_6(string error) { }

	[CompilerGenerated]
	private void <Awake>b__17_7(Dictionary<String, Object> dict) { }

	[CompilerGenerated]
	private void <Awake>b__17_8(string errorType, object errorContent) { }

	private void Awake() { }

	public virtual Dictionary<String, Object> get_Extra() { }

	private void HideError() { }

	public virtual void set_Extra(Dictionary<String, Object> value) { }

	private void ShowError(string error) { }

	private void Update() { }

}

