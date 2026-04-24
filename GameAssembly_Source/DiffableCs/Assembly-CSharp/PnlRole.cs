//Type is in global namespace

public class PnlRole : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, Int32> <>9__42_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__42_0(int <p0>, int <p1>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public int delegateRoleIndex; //Field offset: 0x10
		public PnlRole <>4__this; //Field offset: 0x18

		public <>c__DisplayClass38_0() { }

		internal void <GetRoleTipMessage>b__0() { }

	}

	private const string silencer_default_hp = "250"; //Field offset: 0x0
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x18
	[SerializeField]
	private SelectableFancyPanel m_FancyPanel; //Field offset: 0x20
	[SerializeField]
	private BtnCharacterSpecial m_BtnCharacterSpecial; //Field offset: 0x28
	private DBConfigCharacter m_ConfigCharacter; //Field offset: 0x30
	private int m_CurCellIndex; //Field offset: 0x38
	[SerializeField]
	private PnlRoleTalkBubble m_TalkBubble; //Field offset: 0x40
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Text m_TxtCv; //Field offset: 0x48
	[SerializeField]
	private Text m_TxtHp; //Field offset: 0x50
	[SerializeField]
	private Text m_TxtCosName; //Field offset: 0x58
	[SerializeField]
	private Text m_TxtCharName; //Field offset: 0x60
	[SerializeField]
	private Text m_TxtSkill; //Field offset: 0x68
	[CompilerGenerated]
	private Action<Int32, Int32> onApplyRole; //Field offset: 0x70
	private Coroutine m_EndCoroutine; //Field offset: 0x78
	private bool m_IsFinishAnim; //Field offset: 0x80
	private Action m_EndCallback; //Field offset: 0x88
	private CharacterApply m_PrevTalkApply; //Field offset: 0x90

	public event Action<Int32, Int32> onApplyRole
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public SelectableFancyPanel fancyPanel
	{
		 get { } //Length: 5
	}

	public bool isFinishAnim
	{
		 get { } //Length: 8
	}

	public PnlRole() { }

	[CompilerGenerated]
	private void <TalkEndCallback>b__37_0() { }

	[CompilerGenerated]
	public void add_onApplyRole(Action<Int32, Int32> value) { }

	private void Clean() { }

	public SelectableFancyPanel get_fancyPanel() { }

	public bool get_isFinishAnim() { }

	private AbstractMessageBox GetRoleTipMessage(int roleIdx) { }

	private string GetTalkText(int index) { }

	private string HpDesHandler(int elfinIndex, CharacterInfo charInfo) { }

	public void InvokeTalk(int roleIdx, string animName, string voiceName, bool force, Action endCallback = null, bool autoAddSuffix = true) { }

	private bool IsSelectedRole(int index) { }

	private void JumpToDlc(int roleIndex) { }

	private void OnApplyClicked() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnFsvIndexChanged(int index) { }

	private void OnPnlDlcOut() { }

	public void PlayCharacterBgm(int i) { }

	[CompilerGenerated]
	public void remove_onApplyRole(Action<Int32, Int32> value) { }

	private void SetProperties(CharacterInfo charInfo, LocalCharacterInfo localCharInfo) { }

	private bool SetSelectedImg(BtnApply apply) { }

	private string SkillDesHandler(CharacterInfo charInfo, LocalCharacterInfo localCharInfo, int skinIndex, int elfinIndex) { }

	private void SkinSwitchedCallback(PnlRoleSubControl control) { }

	private void Start() { }

	private void TalkEndCallback() { }

}

