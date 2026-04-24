namespace Assets.Scripts.UI.Panels.PnlDLC;

public class PnlDlcBtnPurchase : MonoBehaviour, IPreWarm
{
	public FancyScrollView fsv; //Field offset: 0x18
	public Button btnPurchase; //Field offset: 0x20
	public Button btnRestore; //Field offset: 0x28
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject price; //Field offset: 0x30
	public GameObject priceCountdown; //Field offset: 0x38
	public Text txtDiscount; //Field offset: 0x40
	public Text txtCountdown; //Field offset: 0x48
	private PnlPrice m_Price; //Field offset: 0x50
	private BtnIAP m_BtnIapPurchase; //Field offset: 0x58
	private BtnIAP m_BtnIapRestore; //Field offset: 0x60
	private int m_SelectedIndex; //Field offset: 0x68

	public PnlDlcBtnPurchase() { }

	public override void PreWarm(int slice) { }

}

