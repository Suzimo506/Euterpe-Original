namespace Assets.Scripts.UI.Panels.PnlDLC;

public class DLCInfo : MonoBehaviour
{
	[SerializeField]
	private GameObject m_Normal; //Field offset: 0x18
	[SerializeField]
	private GameObject m_JustAsPlan; //Field offset: 0x20
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private DlcBillboardControl m_BillboardControl; //Field offset: 0x28
	[SerializeField]
	private DlcBillboardControl m_Billboard2Control; //Field offset: 0x30
	[SerializeField]
	private DLCInfoSubControl m_SubControl; //Field offset: 0x38
	[SerializeField]
	private PnlDlcJustAsPlanned m_DlcJustAsPlanned; //Field offset: 0x40
	[SerializeField]
	private OnFancyScrollViewCellUpdate m_FsvCellUpdate; //Field offset: 0x48
	private int m_Index; //Field offset: 0x50
	private int m_JsonIndex; //Field offset: 0x54
	private DBConfigDlcBillboard m_DbBillboard; //Field offset: 0x58

	public int jsonIndex
	{
		 get { } //Length: 4
	}

	public DLCInfo() { }

	public int get_jsonIndex() { }

}

