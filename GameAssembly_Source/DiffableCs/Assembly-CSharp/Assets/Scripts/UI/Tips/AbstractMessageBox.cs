namespace Assets.Scripts.UI.Tips;

public abstract class AbstractMessageBox : SerializedMonoBehaviour
{
	private static String[] s_TitleLocal; //Field offset: 0x0
	[SerializeField]
	protected Popup m_Popup; //Field offset: 0x58
	[SerializeField]
	protected Text m_Title; //Field offset: 0x60
	[SerializeField]
	protected Text m_Msg; //Field offset: 0x68
	[CompilerGenerated]
	private Action onYesClicked; //Field offset: 0x70
	[CompilerGenerated]
	private Action onNoClicked; //Field offset: 0x78
	[CompilerGenerated]
	private Action onCancelClicked; //Field offset: 0x80
	[CompilerGenerated]
	private Action onHelpClicked; //Field offset: 0x88
	[CompilerGenerated]
	private Action onShutClicked; //Field offset: 0x90
	[CompilerGenerated]
	private Action onClose; //Field offset: 0x98
	[CompilerGenerated]
	private Action onShow; //Field offset: 0xA0
	[SerializeField]
	protected Button m_YesButton; //Field offset: 0xA8
	[SerializeField]
	protected Button m_NoButton; //Field offset: 0xB0
	[SerializeField]
	protected Button m_CancelButton; //Field offset: 0xB8
	[SerializeField]
	protected Button m_HelpButton; //Field offset: 0xC0
	[SerializeField]
	protected string m_MessageBoxKey; //Field offset: 0xC8
	protected bool m_PlayClickAudio; //Field offset: 0xD0
	[SerializeField]
	protected bool m_AutoClose; //Field offset: 0xD1
	[SerializeField]
	protected bool m_IsBaseMessageBox; //Field offset: 0xD2
	[SerializeField]
	protected ButtonType m_ButtonType; //Field offset: 0xD4

	public event Action onCancelClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onClose
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onHelpClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onNoClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onShow
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onShutClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onYesClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string MessageBoxKey
	{
		 get { } //Length: 8
	}

	public string MessageBoxText
	{
		 get { } //Length: 39
		 set { } //Length: 64
	}

	public string MessageBoxTitle
	{
		 get { } //Length: 39
		 set { } //Length: 64
	}

	private static AbstractMessageBox() { }

	protected AbstractMessageBox() { }

	[CompilerGenerated]
	public void add_onCancelClicked(Action value) { }

	[CompilerGenerated]
	public void add_onClose(Action value) { }

	[CompilerGenerated]
	public void add_onHelpClicked(Action value) { }

	[CompilerGenerated]
	public void add_onNoClicked(Action value) { }

	[CompilerGenerated]
	public void add_onShow(Action value) { }

	[CompilerGenerated]
	public void add_onShutClicked(Action value) { }

	[CompilerGenerated]
	public void add_onYesClicked(Action value) { }

	public override void AwakeInit() { }

	public override void ClearAllEvent() { }

	public override void ClearEvent(ButtonType t) { }

	public override void Close(bool disablePrevPopup = false) { }

	public override void CloseAll() { }

	public override void Destroy() { }

	public string get_MessageBoxKey() { }

	public string get_MessageBoxText() { }

	public string get_MessageBoxTitle() { }

	public override Button GetMsgBoxButton(ButtonType type) { }

	protected override void OnCancelClicked() { }

	protected override void OnHelpClicked() { }

	protected override void OnNoClicked() { }

	protected override void OnSetMsg() { }

	protected override void OnSetTitle() { }

	protected override void OnShutClicked() { }

	protected override void OnYesClicked() { }

	[CompilerGenerated]
	public void remove_onCancelClicked(Action value) { }

	[CompilerGenerated]
	public void remove_onClose(Action value) { }

	[CompilerGenerated]
	public void remove_onHelpClicked(Action value) { }

	[CompilerGenerated]
	public void remove_onNoClicked(Action value) { }

	[CompilerGenerated]
	public void remove_onShow(Action value) { }

	[CompilerGenerated]
	public void remove_onShutClicked(Action value) { }

	[CompilerGenerated]
	public void remove_onYesClicked(Action value) { }

	public override void ResetMsgBox() { }

	public void set_MessageBoxText(string value) { }

	public void set_MessageBoxTitle(string value) { }

	public void SetAutoClose(bool enable) { }

	public override void SetButtonDisplay(ButtonType t) { }

	public override bool SetButtonText(ButtonType type, string text) { }

	public abstract void SetSetting(string key, int value) { }

	public void SetShutEnable(bool enable) { }

	public override void Show() { }

	public override void Show(string title, string msg) { }

	public override void StartInit() { }

}

