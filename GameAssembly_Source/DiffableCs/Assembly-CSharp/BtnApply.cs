//Type is in global namespace

public class BtnApply : MonoBehaviour
{
	public GameObject imgInUse; //Field offset: 0x18
	public GameObject imgApply; //Field offset: 0x20
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject lockedObj; //Field offset: 0x28
	public GameObject imgLocked; //Field offset: 0x30
	public GameObject parUnlockObj; //Field offset: 0x38
	public GameObject imgSwitch; //Field offset: 0x40
	public Image m_LockImgIcon; //Field offset: 0x48
	public Text m_lockTxt; //Field offset: 0x50
	private int m_MaxItemCount; //Field offset: 0x58
	private string m_ChipImage; //Field offset: 0x60
	private int m_Order; //Field offset: 0x68
	[SerializeField]
	private Button m_BtnApply; //Field offset: 0x70
	[SerializeField]
	private Button m_LockBtnApply; //Field offset: 0x78
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x80
	private SelectableFancyPanel m_Parent; //Field offset: 0x88
	[CompilerGenerated]
	private int <lastCellIndex>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private int <lastItemIndex>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private bool <unlock>k__BackingField; //Field offset: 0x98
	private Func<BtnApply, Boolean> m_SetUseStateCallback; //Field offset: 0xA0

	public Button btnApply
	{
		 get { } //Length: 5
	}

	public private int lastCellIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int lastItemIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[Obsolete]
	public Button lockBtnApply
	{
		 get { } //Length: 5
	}

	public MenuType menuType
	{
		 get { } //Length: 29
	}

	public private bool unlock
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public BtnApply() { }

	public Button get_btnApply() { }

	[CompilerGenerated]
	public int get_lastCellIndex() { }

	[CompilerGenerated]
	public int get_lastItemIndex() { }

	public Button get_lockBtnApply() { }

	public MenuType get_menuType() { }

	[CompilerGenerated]
	public bool get_unlock() { }

	private IData GetItem() { }

	public void Init(SelectableFancyPanel parent) { }

	public void OnFsvIndexChanged(int index) { }

	[CompilerGenerated]
	private void set_lastCellIndex(int value) { }

	[CompilerGenerated]
	private void set_lastItemIndex(int value) { }

	[CompilerGenerated]
	private void set_unlock(bool value) { }

	private void SetLockImg(IData item) { }

	private bool SetUnlockAnimator(IData item) { }

	public void SetUseCallback(Func<BtnApply, Boolean> callback) { }

	private void SetUseState(bool isUnlock) { }

}

