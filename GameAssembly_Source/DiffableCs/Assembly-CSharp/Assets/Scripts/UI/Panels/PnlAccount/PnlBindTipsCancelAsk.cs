namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlBindTipsCancelAsk : BaseMessageBox
{
	[SerializeField]
	private GameObject m_TapTapTip; //Field offset: 0xD8
	[SerializeField]
	private GameObject m_SteamTip; //Field offset: 0xE0
	[SerializeField]
	private GameObject m_IOSTip; //Field offset: 0xE8

	public PnlBindTipsCancelAsk() { }

	protected virtual void OnNoClicked() { }

	protected virtual void OnYesClicked() { }

	private void SetTips() { }

	public virtual void Show() { }

}

