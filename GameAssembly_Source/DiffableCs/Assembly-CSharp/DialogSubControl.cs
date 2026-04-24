//Type is in global namespace

public class DialogSubControl : MonoBehaviour, IPause, IRelease
{
	internal enum DialogDir
	{
		Up = 0,
		Down = 1,
	}

	private static readonly Vector2 s_MinSize; //Field offset: 0x0
	private static readonly Vector2 s_MaxSize; //Field offset: 0x8
	private static readonly Vector2 s_CanvasMinSize; //Field offset: 0x10
	private static readonly Vector2 s_CanvasMaxSize; //Field offset: 0x18
	[SerializeField]
	private Animator m_Anim; //Field offset: 0x18
	[SerializeField]
	private SuperTextMesh m_Text; //Field offset: 0x20
	[SerializeField]
	private SpriteRenderer m_Bg; //Field offset: 0x28
	[SerializeField]
	private Transform m_Rect; //Field offset: 0x30
	[SerializeField]
	private DialogDir m_Dir; //Field offset: 0x38
	[SerializeField]
	private GameObject m_HideControl; //Field offset: 0x40
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private bool m_IsCanvas; //Field offset: 0x48
	[SerializeField]
	private Image m_BgImg; //Field offset: 0x50
	private DialogMasterControl m_MasterControl; //Field offset: 0x58
	private DialogState m_DialogState; //Field offset: 0x60

	public DialogState dialogState
	{
		 get { } //Length: 4
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	private static DialogSubControl() { }

	public DialogSubControl() { }

	public DialogState get_dialogState() { }

	public override bool get_IsGlobal() { }

	public void Init(DialogMasterControl masterControl) { }

	public override void Pause(bool pauseCorountine) { }

	public void PlayDialogAnim(DialogState state, float normalize = 0) { }

	public override void Release(bool isEditor) { }

	public override void Resume() { }

	public void SetBaseImg(Sprite sprite) { }

	public void SetDialog(ref GameDialogArgs args) { }

	public void SetHide(bool hide) { }

	public void SetSize(Vector2 size, int type) { }

	public void SetSorting(string sortingName, int order) { }

}

