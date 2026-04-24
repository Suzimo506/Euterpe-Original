namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlPhoneBind : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__15_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnYesClicked>b__15_1(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public PnlAccountVerify msg; //Field offset: 0x10
		public PnlPhoneBind <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <OnYesClicked>b__0(JObject o) { }

	}

	internal enum InputType
	{
		Phone = 0,
		Email = 1,
	}

	[SerializeField]
	private Button m_PhoneBtn; //Field offset: 0xD8
	[SerializeField]
	private Button m_EmailBtn; //Field offset: 0xE0
	[SerializeField]
	private Text m_PhoneTagTxt; //Field offset: 0xE8
	[SerializeField]
	private Text m_EmailTagTxt; //Field offset: 0xF0
	[SerializeField]
	private InputField m_InputField_Phone; //Field offset: 0xF8
	[SerializeField]
	private InputField m_InputField_Email; //Field offset: 0x100
	[SerializeField]
	private GameObject m_PhoneLine; //Field offset: 0x108
	[SerializeField]
	private GameObject m_EmailLine; //Field offset: 0x110
	private InputType m_CurType; //Field offset: 0x118
	private string m_FinalSendTxt; //Field offset: 0x120

	public PnlPhoneBind() { }

	private void BindInit() { }

	private void OnEmailClicked() { }

	protected virtual void OnNoClicked() { }

	private void OnPhoneClicked() { }

	protected virtual void OnYesClicked() { }

	public virtual void StartInit() { }

}

