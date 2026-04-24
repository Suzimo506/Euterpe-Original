namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlPhoneBindChangeAsk : BaseMessageBox
{
	[SerializeField]
	private Button m_BindExplainBtn; //Field offset: 0xD8
	private string m_AccountNumber; //Field offset: 0xE0

	public PnlPhoneBindChangeAsk() { }

	private void OnBindExplainBtnClicked() { }

	protected virtual void OnNoClicked() { }

	protected virtual void OnYesClicked() { }

	public void SetAccountNumber(string number) { }

	public virtual void StartInit() { }

}

