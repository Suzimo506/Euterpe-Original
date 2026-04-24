//Type is in global namespace

public class PnlFavaoriteMusicTips : BaseMessageBox
{
	[SerializeField]
	private FancyScrollView m_TipsFsv; //Field offset: 0xD8

	public PnlFavaoriteMusicTips() { }

	private void OnEnable() { }

	protected virtual void OnYesClicked() { }

}

