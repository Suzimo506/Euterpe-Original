using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000123")]
public class PnlInputArcade : UISelectManage
{
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x118")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView modeFancyScrollView;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40006F4")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView feverFancyScrollView;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40006F5")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView reverseFancyScrollView;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40006F6")]
	public Transform arcadeFeverTipsBtn;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40006F7")]
	public PointsBar screenPointsBar;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x140")]
	public Button btnHandleUI;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40006F9")]
	private bool m_IsLeftRight;

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x149")]
	private bool m_IsReverse;

	[FieldOffset(Offset = "0x14A")]
	[Token(Token = "0x40006FB")]
	private bool m_IsManualAutoFever;

	[FieldOffset(Offset = "0x14B")]
	[Token(Token = "0x40006FC")]
	private bool m_IsInitReverse;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x14C")]
	private bool m_IsInitManualFever;

	[FieldOffset(Offset = "0x14D")]
	[Token(Token = "0x40006FE")]
	private bool m_IsInitHandlerSetting;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x150")]
	public Color highLightColor;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x160")]
	public Color normalColor;

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6000841")]
	public PnlInputArcade()
	{
	}
}
