//Type is in global namespace

public class BtnCharacterSpecial : MonoBehaviour
{
	public GameObject description; //Field offset: 0x18
	private PnlRole m_Parent; //Field offset: 0x20
	[SerializeField]
	private Button m_BtnNeko; //Field offset: 0x28
	[SerializeField]
	private GameObject m_NekoDescription; //Field offset: 0x30
	[SerializeField]
	private Button[] m_BtnReimu; //Field offset: 0x38
	[SerializeField]
	private Button m_BtnMarisa; //Field offset: 0x40
	[SerializeField]
	private GameObject m_TouhouDescription; //Field offset: 0x48
	[SerializeField]
	private Text m_TouhouDescriptionText; //Field offset: 0x50
	[SerializeField]
	private Button m_BtnTouhouQuetion; //Field offset: 0x58
	private int m_ClickCount; //Field offset: 0x60
	private bool m_ToggleBarrageModeCoolDown; //Field offset: 0x64
	private Coroutine m_ToggleBarrageCoolDownCoroutine; //Field offset: 0x68
	private int m_CurRoleIdx; //Field offset: 0x70

	public BtnCharacterSpecial() { }

	[CompilerGenerated]
	private void <TouhouSkillHandler>b__21_0() { }

	private void CancelToggleBarrageCoolDown(bool state) { }

	public void Init(PnlRole parent) { }

	private void NekoSkillHandler() { }

	private void OnEnable() { }

	public void OnFsvIndexChanged(int index) { }

	private void OnRoleApply(int index, int prevIndex) { }

	private void OnSkillSpecialClicked() { }

	private void OnTouhouQuestionClicked() { }

	private void ResetBarrageMode(int index, int prevIndex) { }

	private void ResetButton() { }

	private void ResetState() { }

	private void SetSpecialButton(int roleIdx, bool enable) { }

	private void SetTouhouDes(int index, bool playAnimator) { }

	private void SpecialButtonInit() { }

	private void TouhouSkillHandler(int role) { }

}

