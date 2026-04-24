using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption;

[Token(Token = "0x200054E")]
public class PageCredits : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F97")]
	[SerializeField]
	private PnlCredits m_PnlCredits;

	[Token(Token = "0x6003774")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageCredits()
	{
	}
}
