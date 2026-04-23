using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x200054C")]
public class PageShop : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F95")]
	[SerializeField]
	private Scrollbar m_Scrollbar;

	[Token(Token = "0x6003772")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageShop()
	{
	}
}
