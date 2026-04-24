namespace Assets.Scripts.UI.Panels.PnlDLC;

public class DlcBillboardControl : MonoBehaviour
{
	[SerializeField]
	private GameObject m_PlayMask; //Field offset: 0x18
	[SerializeField]
	private Image m_Img; //Field offset: 0x20
	[SerializeField]
	private Button m_Button; //Field offset: 0x28
	private int m_JsonIndex; //Field offset: 0x30
	[SerializeField]
	private int m_ButtonIndex; //Field offset: 0x34

	public DlcBillboardControl() { }

}

