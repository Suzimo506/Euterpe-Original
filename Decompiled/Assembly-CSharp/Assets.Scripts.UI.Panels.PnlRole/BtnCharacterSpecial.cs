using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200095C")]
public class BtnCharacterSpecial : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003310")]
	public GameObject description;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003311")]
	private PnlRole m_Parent;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003312")]
	[SerializeField]
	private Button m_BtnNeko;

	[Token(Token = "0x4003313")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_NekoDescription;

	[Token(Token = "0x4003314")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button[] m_BtnReimu;

	[Token(Token = "0x4003315")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Button m_BtnMarisa;

	[SerializeField]
	[Token(Token = "0x4003316")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_TouhouDescription;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4003317")]
	private Text m_TouhouDescriptionText;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4003318")]
	[SerializeField]
	private Button m_BtnTouhouQuetion;

	[Token(Token = "0x4003319")]
	[FieldOffset(Offset = "0x60")]
	private int m_ClickCount;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400331A")]
	private bool m_ToggleBarrageModeCoolDown;

	[Token(Token = "0x400331B")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine m_ToggleBarrageCoolDownCoroutine;

	[Token(Token = "0x400331C")]
	[FieldOffset(Offset = "0x70")]
	private int m_CurRoleIdx;

	[Token(Token = "0x6005515")]
	[Address(RVA = "0x6783E0", Offset = "0x676BE0", Length = "0x3AB")]
	public void Init(PnlRole parent)
	{
	}

	[Address(RVA = "0x678910", Offset = "0x677110", Length = "0xA9")]
	[Token(Token = "0x6005516")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x678ED0", Offset = "0x6776D0", Length = "0x64")]
	[Token(Token = "0x6005517")]
	private void OnTouhouQuestionClicked()
	{
	}

	[Address(RVA = "0x6793E0", Offset = "0x677BE0", Length = "0x171")]
	[Token(Token = "0x6005518")]
	private void SpecialButtonInit()
	{
	}

	[Address(RVA = "0x678C10", Offset = "0x677410", Length = "0xC3")]
	[Token(Token = "0x6005519")]
	private void OnRoleApply(int index, int prevIndex)
	{
	}

	[Address(RVA = "0x6789C0", Offset = "0x6771C0", Length = "0x23")]
	[Token(Token = "0x600551A")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x679190", Offset = "0x677990", Length = "0xEA")]
	[Token(Token = "0x600551B")]
	private void SetSpecialButton(int roleIdx, bool enable)
	{
	}

	[Token(Token = "0x600551C")]
	[Address(RVA = "0x678790", Offset = "0x676F90", Length = "0x17A")]
	private void NekoSkillHandler()
	{
	}

	[Address(RVA = "0x6782F0", Offset = "0x676AF0", Length = "0x83")]
	[Token(Token = "0x600551D")]
	private void CancelToggleBarrageCoolDown(bool state)
	{
	}

	[Token(Token = "0x600551E")]
	[Address(RVA = "0x679560", Offset = "0x677D60", Length = "0x31A")]
	private void TouhouSkillHandler(int role)
	{
	}

	[Token(Token = "0x600551F")]
	[Address(RVA = "0x678CE0", Offset = "0x6774E0", Length = "0x1E5")]
	private void OnSkillSpecialClicked()
	{
	}

	[Token(Token = "0x6005520")]
	[Address(RVA = "0x678FE0", Offset = "0x6777E0", Length = "0xEA")]
	private void ResetButton()
	{
	}

	[Token(Token = "0x6005521")]
	[Address(RVA = "0x6790D0", Offset = "0x6778D0", Length = "0xB5")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6005522")]
	[Address(RVA = "0x678F40", Offset = "0x677740", Length = "0x92")]
	private void ResetBarrageMode(int index, int prevIndex)
	{
	}

	[Address(RVA = "0x6789F0", Offset = "0x6771F0", Length = "0x1BB")]
	[Token(Token = "0x6005523")]
	public void OnFsvIndexChanged(int index)
	{
	}

	[Address(RVA = "0x679280", Offset = "0x677A80", Length = "0x15D")]
	[Token(Token = "0x6005524")]
	private void SetTouhouDes(int index, bool playAnimator)
	{
	}

	[Address(RVA = "0x678380", Offset = "0x676B80", Length = "0x53")]
	[Token(Token = "0x6005525")]
	private void HideSpecialDescription()
	{
	}

	[Token(Token = "0x6005526")]
	[Address(RVA = "0x678BB0", Offset = "0x6773B0", Length = "0x57")]
	private void OnNavigationShow(bool value)
	{
	}

	[Token(Token = "0x6005527")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BtnCharacterSpecial()
	{
	}
}
