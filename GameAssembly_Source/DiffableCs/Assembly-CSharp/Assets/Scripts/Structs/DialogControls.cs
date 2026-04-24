namespace Assets.Scripts.Structs;

public class DialogControls : IPause, IRelease
{
	private int m_Index; //Field offset: 0x10
	[SerializeField]
	private string m_Comment; //Field offset: 0x18
	[SerializeField]
	private DialogSubControl m_UpControl; //Field offset: 0x20
	[SerializeField]
	private DialogSubControl m_DownControl; //Field offset: 0x28
	[SerializeField]
	private Transform m_Tf; //Field offset: 0x30
	[SerializeField]
	private bool m_ExcludeAnim; //Field offset: 0x38
	private Bone m_Body; //Field offset: 0x40
	private Transform m_SpineTf; //Field offset: 0x48
	private int m_CurControl; //Field offset: 0x50
	private Vector3 m_TfOffset; //Field offset: 0x54

	public int controlIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool excludeAnim
	{
		 get { } //Length: 5
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public DialogControls() { }

	public int get_controlIndex() { }

	public bool get_excludeAnim() { }

	public override bool get_IsGlobal() { }

	public DialogSubControl GetControl(int index = -1) { }

	public void Init(DialogMasterControl parent, int index) { }

	public override void Pause(bool pauseCorountine) { }

	public override void Release(bool isEditor) { }

	public override void Resume() { }

	public void set_controlIndex(int value) { }

	public void SetBone(Bone bone, Transform tf) { }

	public void SetHide(bool hide) { }

	public void SetOffset(Vector3 offset) { }

	public void SetSorting(string sort, int order) { }

	public void UpdatePosition() { }

}

