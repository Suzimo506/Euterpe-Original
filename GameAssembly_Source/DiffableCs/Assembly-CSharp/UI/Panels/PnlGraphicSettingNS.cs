namespace UI.Panels;

public class PnlGraphicSettingNS : UISelectManage
{
	public Button bgButton; //Field offset: 0x110
	public GameObject bgButtonSelected; //Field offset: 0x118
	[SerializeField]
	private AudioClip backPanelClip; //Field offset: 0x120
	[SerializeField]
	private List<UISetColor> m_UiSetColors; //Field offset: 0x128
	[SerializeField]
	private Color m_Normal; //Field offset: 0x130
	[SerializeField]
	private Color m_High; //Field offset: 0x140

	public PnlGraphicSettingNS() { }

	public virtual void OnAwake() { }

	public virtual void OnDisablePnl() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

