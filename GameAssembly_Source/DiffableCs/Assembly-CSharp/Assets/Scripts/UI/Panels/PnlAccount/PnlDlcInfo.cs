namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlDlcInfo : BaseMessageBox
{
	[SerializeField]
	private Transform m_DlcInfo; //Field offset: 0xD8
	[SerializeField]
	private Transform m_InfoPos; //Field offset: 0xE0
	[SerializeField]
	private Transform m_DlcPos; //Field offset: 0xE8
	[SerializeField]
	private Button m_ReLogin; //Field offset: 0xF0
	private bool isUnlockAll; //Field offset: 0xF8

	public PnlDlcInfo() { }

}

