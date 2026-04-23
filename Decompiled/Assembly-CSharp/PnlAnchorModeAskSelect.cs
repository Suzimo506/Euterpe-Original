using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F8")]
public class PnlAnchorModeAskSelect : UISelectManage
{
	[SerializeField]
	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x118")]
	private Button m_ConfirmBtn;

	[SerializeField]
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_AnchorTxt;

	[Address(RVA = "0x4FA610", Offset = "0x4F8E10", Length = "0x8C")]
	[Token(Token = "0x6000744")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x4FA580", Offset = "0x4F8D80", Length = "0x85")]
	[Token(Token = "0x6000745")]
	public void OnClickCloseAnchorMode()
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6000746")]
	public PnlAnchorModeAskSelect()
	{
	}
}
