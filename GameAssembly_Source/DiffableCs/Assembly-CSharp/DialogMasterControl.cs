//Type is in global namespace

public class DialogMasterControl : MonoBehaviour, IPause, IRelease
{
	private string m_Language; //Field offset: 0x18
	[SerializeField]
	private DialogControls[] m_Controls; //Field offset: 0x20
	[SerializeField]
	private Vector3 m_RoleDialogOffset; //Field offset: 0x28
	[SerializeField]
	private Vector3 m_CatDialogOffset; //Field offset: 0x34
	[SerializeField]
	private Vector3 m_LRUpTextOffset; //Field offset: 0x40
	[SerializeField]
	private Vector3 m_LRDownTextOffset; //Field offset: 0x4C
	[SerializeField]
	private Vector3[] m_BossDialogOffset; //Field offset: 0x58
	[SerializeField]
	private string m_SortingName; //Field offset: 0x60
	[SerializeField]
	private int m_SortingOrder; //Field offset: 0x68
	[SerializeField]
	private Canvas m_DialogCanvas; //Field offset: 0x70
	[SerializeField]
	private TalkBaseImg[] m_TalkBaseImgs; //Field offset: 0x78

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public string language
	{
		 get { } //Length: 5
	}

	public DialogMasterControl() { }

	public override bool get_IsGlobal() { }

	public string get_language() { }

	public Font GetFont(int index = -1) { }

	public Vector3 GetLRDialogOffset(DialogDir dir) { }

	public TalkBaseImg GetTalkBaseImg(int index) { }

	public void Init() { }

	private void LateUpdate() { }

	private void OnBossSetHide(bool hide) { }

	private void OnInvokeDialog(GameDialogArgs args) { }

	private void OnSceneChanged(int index) { }

	public override void Pause(bool pauseCorountine) { }

	public override void Release(bool isEditor) { }

	public override void Resume() { }

	public void SetBone(int index, int bossIndex, Dictionary<String, Bone> bones, Transform spineTf) { }

}

