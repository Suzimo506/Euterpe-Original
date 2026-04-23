using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlStage;

[Token(Token = "0x2000544")]
public class PageStage : PageAbstractHandler
{
	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public Button m_BtnOwn;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001F81")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_FancyScrollViewMusic;

	[SerializeField]
	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x70")]
	private Button m_BtnSwitchL;

	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4001F83")]
	private Button m_BtnSwitchR;

	[Token(Token = "0x600376A")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageStage()
	{
	}
}
