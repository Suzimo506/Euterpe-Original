using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlTips;

[Token(Token = "0x2000541")]
public class PageLlusCheck : PageAbstractHandler
{
	[Token(Token = "0x4001F7D")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private PnlIllusCheck m_PnlIllusCheck;

	[Token(Token = "0x6003767")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageLlusCheck()
	{
	}
}
