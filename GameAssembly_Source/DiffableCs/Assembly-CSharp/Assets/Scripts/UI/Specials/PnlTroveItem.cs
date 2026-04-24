namespace Assets.Scripts.UI.Specials;

public class PnlTroveItem : MonoBehaviour
{
	public GameObject imgNew; //Field offset: 0x18
	private Text m_ValueText; //Field offset: 0x20
	public GameObject imgItem; //Field offset: 0x28
	public GameObject txtValue; //Field offset: 0x30
	public GameObject imgUse; //Field offset: 0x38
	public Image chipImg; //Field offset: 0x40
	public Toggle itemTgl; //Field offset: 0x48
	[SerializeField]
	private ClickEventListener m_ClickEventListener; //Field offset: 0x50

	private IData item
	{
		private get { } //Length: 137
	}

	public PnlTroveItem() { }

	private void Awake() { }

	private int Count(IData d) { }

	private IData get_item() { }

	private int Index(IData d) { }

	public bool IsEmpty() { }

	private bool IsNew(IData d) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void OnDoubleClicked(GameObject go) { }

	private void OnEnable() { }

	private void OnRefreshUseImg() { }

	private void OnToggleValueChanged(bool isOn) { }

	public void SetActivate() { }

	private void SetImage(IData d) { }

	private string Type(IData d) { }

}

