//Type is in global namespace

public class PnlAnchorMode : UISelectManage
{
	public Toggle openBtn; //Field offset: 0x110
	public Toggle closeBtn; //Field offset: 0x118
	public Color highlightColor; //Field offset: 0x120
	public Color normalColor; //Field offset: 0x130
	public AudioClip optionBgmClip; //Field offset: 0x140

	public PnlAnchorMode() { }

	public void OnClickClose(bool isOn) { }

	public void OnClickOpen(bool isOn) { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	private void SetHighlight(Toggle tgl, bool enable) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

