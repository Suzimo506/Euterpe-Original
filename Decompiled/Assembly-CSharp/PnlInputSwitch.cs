using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000127")]
public class PnlInputSwitch : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400072E")]
	public Button switchL;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400072F")]
	public Button switchR;

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x128")]
	public Text txtButton;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x130")]
	public Text txtScreen;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x138")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView controlScrollView;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000733")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView buttonFancyScrollView;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x148")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenFancyScrollView;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000735")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView feverFancyScrollView;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000736")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView reverseFancyScrollView;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000737")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView vibrationFancyScrollView;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000738")]
	public PointsBar buttonPointsBar;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000739")]
	public PointsBar screenPointsBar;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x178")]
	public Color highLightColor;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x188")]
	public Color normalColor;

	[SerializeField]
	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x198")]
	private UISetColor[] m_UiSetColors;

	[Token(Token = "0x400073D")]
	private static readonly string[] buttonProposal;

	[Token(Token = "0x400073E")]
	private static readonly string[] revertButtonProposal;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x1A0")]
	private bool m_IsButtonPage;

	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x1A4")]
	private int m_ControlIndex;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x1A8")]
	private int m_ButtonProposalIndex;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x1AC")]
	private int m_ScreenProposalIndex;

	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_IsBtnReverse;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x1B1")]
	private bool m_IsTouchReverse;

	[FieldOffset(Offset = "0x1B2")]
	[Token(Token = "0x4000745")]
	private bool m_IsVibration;

	[FieldOffset(Offset = "0x1B3")]
	[Token(Token = "0x4000746")]
	private bool m_IsAutoFever;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x1B4")]
	private bool m_IsInitVibration;

	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x1B5")]
	private bool m_IsInitReverse;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x1B6")]
	private bool m_IsInitButton;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x1B7")]
	private bool m_IsInitScreen;

	[Address(RVA = "0x7A4AD0", Offset = "0x7A32D0", Length = "0xE")]
	[Token(Token = "0x600085E")]
	public PnlInputSwitch()
	{
	}
}
