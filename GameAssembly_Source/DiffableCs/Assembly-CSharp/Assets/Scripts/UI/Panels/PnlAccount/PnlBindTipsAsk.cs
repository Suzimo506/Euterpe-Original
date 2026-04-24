namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlBindTipsAsk : BaseMessageBox
{
	[SerializeField]
	private GameObject m_TapTapTip; //Field offset: 0xD8
	[SerializeField]
	private GameObject m_SteamTip; //Field offset: 0xE0
	[SerializeField]
	private GameObject m_IOSTip; //Field offset: 0xE8

	public PnlBindTipsAsk() { }

	protected virtual void OnNoClicked() { }

	protected virtual void OnYesClicked() { }

	private void SetTips() { }

	public virtual void Show() { }

}

