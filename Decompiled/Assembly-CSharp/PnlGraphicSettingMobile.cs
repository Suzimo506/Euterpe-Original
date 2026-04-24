using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000118")]
public class PnlGraphicSettingMobile : UISelectManage
{
	[Token(Token = "0x40006D0")]
	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	private AudioClip m_OptionBgmClip;

	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40006D1")]
	private Animator m_PnlAnimator;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40006D2")]
	private Button m_BackBtn;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40006D3")]
	[SerializeField]
	private Button m_FpsQuestion;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40006D4")]
	private bool m_Freeze;

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x79F9E0", Offset = "0x79E1E0", Length = "0xDA")]
	private void Awake()
	{
	}

	[Address(RVA = "0x79FC40", Offset = "0x79E440", Length = "0x94")]
	[Token(Token = "0x6000824")]
	private void OnFpsQuestionClicked()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x79FAC0", Offset = "0x79E2C0", Length = "0xFD")]
	private void OnBackClicked()
	{
	}

	[Address(RVA = "0x79FBC0", Offset = "0x79E3C0", Length = "0x72")]
	[Token(Token = "0x6000826")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6000827")]
	public PnlGraphicSettingMobile()
	{
	}
}
