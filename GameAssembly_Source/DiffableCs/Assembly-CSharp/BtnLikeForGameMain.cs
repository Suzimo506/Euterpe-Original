//Type is in global namespace

public class BtnLikeForGameMain : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private const string fail = "PnlFail"; //Field offset: 0x0
	private const string victory = "PnlVictory"; //Field offset: 0x0
	public Image holdImg; //Field offset: 0x18
	public GameObject imgLike; //Field offset: 0x20
	public GameObject imgHide; //Field offset: 0x28
	private MusicInfo m_SelectedMusic; //Field offset: 0x30
	private Effect m_ParTglLikes; //Field offset: 0x38
	private Effect m_ParTglDisLikes; //Field offset: 0x40
	[SerializeField]
	private string m_ButtonName; //Field offset: 0x48
	[SerializeField]
	private float m_HoldTime; //Field offset: 0x50
	public bool isPnlVictory; //Field offset: 0x54
	private AbstractMessageBox m_HideMsg; //Field offset: 0x58
	private AbstractMessageBox m_CancelHideMsg; //Field offset: 0x60
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_IsPointDown; //Field offset: 0x68
	private bool m_IsBeginHoldAnim; //Field offset: 0x69
	private Button m_Button; //Field offset: 0x70
	private float m_LongHoldTimer; //Field offset: 0x78
	private bool m_IsHide; //Field offset: 0x7C
	private bool m_IsCollection; //Field offset: 0x7D
	private bool m_IsClickHide; //Field offset: 0x7E

	private bool isOn
	{
		private get { } //Length: 13
	}

	public BtnLikeForGameMain() { }

	private void AddCollection() { }

	private void Awake() { }

	private bool get_isOn() { }

	private void InitMsg() { }

	private void KeyPress() { }

	private void KeyUp() { }

	public void OnHideMsgClose() { }

	public void OnHideMsgShow() { }

	private void OnHideMusic() { }

	public override void OnPointerDown(PointerEventData data) { }

	public override void OnPointerUp(PointerEventData data) { }

	private void OnRemoveHideMusic() { }

	private void OnVictoryBtnClicked(bool state) { }

	private void RemoveCollection() { }

	private void Start() { }

	private void Update() { }

	private void UpdateIcon() { }

}

