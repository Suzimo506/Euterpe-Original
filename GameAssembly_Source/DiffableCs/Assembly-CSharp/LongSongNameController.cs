//Type is in global namespace

public class LongSongNameController : MonoBehaviour
{
	[SerializeField]
	private Text m_MidSimpleName; //Field offset: 0x18
	[SerializeField]
	private RectTransform m_SimpleName; //Field offset: 0x20
	[SerializeField]
	private RectTransform m_BackupName; //Field offset: 0x28
	public float m_Speed; //Field offset: 0x30
	private float m_PreWidth; //Field offset: 0x34
	[SerializeField]
	private int m_LongBound; //Field offset: 0x38
	private bool m_PlayLongAnim; //Field offset: 0x3C
	private Mask m_ParentMask; //Field offset: 0x40
	private Image m_MaskImg; //Field offset: 0x48
	[SerializeField]
	private GameObject m_LMask; //Field offset: 0x50
	[SerializeField]
	private GameObject m_RMask; //Field offset: 0x58
	private Text m_TxtSimpleName; //Field offset: 0x60
	private Text m_TxtBackupName; //Field offset: 0x68
	private Coroutine m_DelayAnim; //Field offset: 0x70
	private bool m_Init; //Field offset: 0x78
	public Font specialFont; //Field offset: 0x80
	public Font normalFont; //Field offset: 0x88
	private bool m_IsSpecialFont; //Field offset: 0x90
	private Vector2 tempX1; //Field offset: 0x94
	private Vector2 tempX2; //Field offset: 0x9C

	public LongSongNameController() { }

	[CompilerGenerated]
	private void <Refresh>b__21_0() { }

	private void Awake() { }

	private void Move() { }

	private void PlayAnim(RectTransform x1, RectTransform x2) { }

	public void Refresh(bool isSpecialFont = false) { }

	public void Refresh(string text, bool isSpecialFont = false, float delay = 1) { }

	private void Start() { }

	public void Stop() { }

	private void Update() { }

}

