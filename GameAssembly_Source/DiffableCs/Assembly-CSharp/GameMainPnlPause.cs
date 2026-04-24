//Type is in global namespace

public class GameMainPnlPause : BaseMessageBox
{
	public GameObject pnl321; //Field offset: 0xD8

	public GameMainPnlPause() { }

	protected virtual void OnCancelClicked() { }

	protected virtual void OnNoClicked() { }

	protected virtual void OnYesClicked() { }

	public virtual void Show() { }

}

