using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x2000549")]
public class PageElfin : PageAbstractHandler
{
	[SerializeField]
	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x60")]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_FancyScrollView;

	[SerializeField]
	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_BtnPrevious;

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4001F8A")]
	private GameObject m_BtnNext;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600376F")]
	public PageElfin()
	{
	}
}
