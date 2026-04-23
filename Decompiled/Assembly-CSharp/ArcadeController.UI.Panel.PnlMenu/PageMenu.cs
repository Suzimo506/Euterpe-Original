using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x200054A")]
public class PageMenu : PageAbstractHandler
{
	[Token(Token = "0x4001F8B")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private InputAxisBinding m_InputAxisBinding;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001F8C")]
	private List<PageAbstractHandler> m_ChildPages;

	[Token(Token = "0x6003770")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageMenu()
	{
	}
}
