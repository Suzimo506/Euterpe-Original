namespace Assets.Scripts.UI.Tips;

public class PnlFeverDlcTips : BaseMessageBox
{
	private int m_ThemeIndex; //Field offset: 0xD8
	private int m_JsonIndex; //Field offset: 0xDC

	public PnlFeverDlcTips() { }

	protected virtual void OnYesClicked() { }

	private void RefreshUI() { }

	public virtual void SetSetting(string key, int value) { }

	public virtual void Show() { }

}

