namespace xdsdk.Unity;

public class RealNameWindow : UIElement
{
	public Button close; //Field offset: 0x58
	public InputField realname; //Field offset: 0x60
	public InputField identifyNumber; //Field offset: 0x68
	public Button confirm; //Field offset: 0x70
	public Text error1; //Field offset: 0x78
	public Image error1Icon; //Field offset: 0x80
	public Text error2; //Field offset: 0x88
	public Image error2Icon; //Field offset: 0x90
	private string token; //Field offset: 0x98
	private string type; //Field offset: 0xA0

	public virtual Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 294
	}

	public RealNameWindow() { }

	[CompilerGenerated]
	private void <Awake>b__13_0() { }

	[CompilerGenerated]
	private void <Awake>b__13_1(string content) { }

	[CompilerGenerated]
	private void <Awake>b__13_2(string content) { }

	[CompilerGenerated]
	private void <Awake>b__13_3() { }

	[CompilerGenerated]
	private void <Awake>b__13_4(string result) { }

	[CompilerGenerated]
	private void <Awake>b__13_5(string error) { }

	private void Awake() { }

	protected virtual void FocusTo(GameObject go) { }

	public virtual Dictionary<String, Object> get_Extra() { }

	private void HideError1() { }

	private void HideError2() { }

	public virtual void set_Extra(Dictionary<String, Object> value) { }

	private void ShowError1(string error) { }

	private void ShowError2(string error) { }

}

