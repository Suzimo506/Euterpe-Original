namespace Assets.Scripts.UI.Panels;

public class PnlOverseaAsk : UISelectManage
{
	public List<Button> buttons; //Field offset: 0x110
	public Text[] texts; //Field offset: 0x118
	public Button yesBtn; //Field offset: 0x120
	public GameObject[] imgs; //Field offset: 0x128
	private String[] m_Urls; //Field offset: 0x130

	public PnlOverseaAsk() { }

	public virtual void OnAwake() { }

	public virtual void OnEnablePnl() { }

	private void OnYesClicked() { }

	public virtual List<GameObject> SetSelectableObj() { }

}

