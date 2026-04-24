//Type is in global namespace

public class PnlCredits : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public int delegateIdx; //Field offset: 0x10
		public PnlCredits <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <Awake>b__0() { }

	}

	public GameObject pnlCredits; //Field offset: 0x18
	public AudioClip pnlMusicClip; //Field offset: 0x20
	public AudioClip optionBgmClip; //Field offset: 0x28
	public ScrollRect scrollRect; //Field offset: 0x30
	public float waitTime; //Field offset: 0x38
	public float totalTime; //Field offset: 0x3C
	public float moveSpeed; //Field offset: 0x40
	public Button backButton; //Field offset: 0x48
	private Tweener m_Tweener; //Field offset: 0x50
	private Sequence m_Sequence; //Field offset: 0x58
	private bool m_UserControl; //Field offset: 0x60
	private bool m_IsDrag; //Field offset: 0x61
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Button[] m_ClickWebBtns; //Field offset: 0x68
	[SerializeField]
	private String[] m_PcWebs; //Field offset: 0x70
	[SerializeField]
	private String[] m_MobileWebs; //Field offset: 0x78

	public PnlCredits() { }

	[CompilerGenerated]
	private float <OnEnable>b__19_0() { }

	[CompilerGenerated]
	private void <OnEnable>b__19_1(float value) { }

	[CompilerGenerated]
	private float <OnRelease>b__23_0() { }

	[CompilerGenerated]
	private void <OnRelease>b__23_1(float value) { }

	private void Awake() { }

	private string GetWeb(int index) { }

	private void OnBackClicked() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void OnPress() { }

	private void OnRelease() { }

	private void OnWebClicked(int index) { }

	private void Update() { }

}

