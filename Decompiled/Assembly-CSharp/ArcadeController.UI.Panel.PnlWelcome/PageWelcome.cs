using Cpp2ILInjected;

namespace ArcadeController.UI.Panel.PnlWelcome;

[Token(Token = "0x200053F")]
public class PageWelcome : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F7A")]
	private bool m_IsOnInput;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x6003765")]
	public PageWelcome()
	{
	}
}
