namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlAccountSystem : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <IsGlobalBind>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlAccountSystem <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <IsGlobalBind>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Text m_BindAccountTipTxt; //Field offset: 0xD8
	[SerializeField]
	private Text m_AccountShowTxt; //Field offset: 0xE0
	[SerializeField]
	private Button m_BindChangeBtn; //Field offset: 0xE8
	[SerializeField]
	private Transform userInfoPos; //Field offset: 0xF0
	[SerializeField]
	private Button m_LogoutButton; //Field offset: 0xF8
	[SerializeField]
	private Button m_ChangeIdButton; //Field offset: 0x100
	[SerializeField]
	private Button m_BindAccountButton; //Field offset: 0x108
	[SerializeField]
	private Button m_OpenAccountDeleteButton; //Field offset: 0x110
	[SerializeField]
	private GameObject m_PnlAccountQaObj; //Field offset: 0x118
	[SerializeField]
	private GameObject m_TxtAgreementTMP; //Field offset: 0x120
	[SerializeField]
	private RectTransform m_ImgAccountMobile; //Field offset: 0x128

	public PnlAccountSystem() { }

	[CompilerGenerated]
	private void <GetBindInfo>b__18_0() { }

	private void ActiveState(bool unBind, bool bind) { }

	private void GetBindInfo() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator IsGlobalBind() { }

	private string MaskAccountInfo(bool isEmail, string account) { }

	private void OnAccountQAPanel() { }

	private void OnBindAccountButtonClicked() { }

	private void OnBindButtonClicked() { }

	private void OnChangeIdClicked() { }

	private void OnLogoutClicked() { }

	protected virtual void OnNoClicked() { }

	private void OnShowAgreement(bool isShow) { }

	private void PlayClickSfx() { }

	public virtual void Show() { }

	public virtual void StartInit() { }

}

