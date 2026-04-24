namespace xdsdk.Unity;

public class PlatformLoginWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__15_2; //Field offset: 0x8
		public static UnityAction <>9__15_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__15_2() { }

		internal void <Awake>b__15_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public string token; //Field offset: 0x10
		public User user; //Field offset: 0x18
		public PlatformLoginWindow <>4__this; //Field offset: 0x20
		public Action<User> <>9__3; //Field offset: 0x28
		public Action<String> <>9__4; //Field offset: 0x30

		public <>c__DisplayClass16_0() { }

		internal void <LoginXD>b__2(int code, object result) { }

		internal void <LoginXD>b__3(User userAfterRealName) { }

		internal void <LoginXD>b__4(string err) { }

	}

	private AppInfo appInfo; //Field offset: 0x58
	public Button close; //Field offset: 0x60
	public Button back; //Field offset: 0x68
	public InputField username; //Field offset: 0x70
	public InputField password; //Field offset: 0x78
	public Button login; //Field offset: 0x80
	public Button forgot; //Field offset: 0x88
	public Button register; //Field offset: 0x90
	public Text error1; //Field offset: 0x98
	public Image error1Icon; //Field offset: 0xA0
	public Text error2; //Field offset: 0xA8
	public Image error2Icon; //Field offset: 0xB0

	public virtual Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 226
	}

	public PlatformLoginWindow() { }

	[CompilerGenerated]
	private void <Awake>b__15_0() { }

	[CompilerGenerated]
	private void <Awake>b__15_1() { }

	[CompilerGenerated]
	private void <Awake>b__15_4(string value) { }

	[CompilerGenerated]
	private void <Awake>b__15_5(string value) { }

	[CompilerGenerated]
	private void <LoginXD>b__16_0(Dictionary<String, Object> dict) { }

	[CompilerGenerated]
	private void <LoginXD>b__16_1(string errorType, object errorContent) { }

	[CompilerGenerated]
	private void <LoginXD>b__16_5(int code, object data) { }

	private void Awake() { }

	public virtual Dictionary<String, Object> get_Extra() { }

	private void HideError1() { }

	private void HideError2() { }

	private void LoginXD() { }

	public virtual void set_Extra(Dictionary<String, Object> value) { }

	private void ShowError1(string error) { }

	private void ShowError2(string error) { }

}

