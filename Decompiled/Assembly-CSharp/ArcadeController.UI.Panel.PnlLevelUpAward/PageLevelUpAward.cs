using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlLevelUpAward;

[Token(Token = "0x2000558")]
public class PageLevelUpAward : PageUniversalHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001FA2")]
	public List<Button> btnEnters;

	[Token(Token = "0x600377E")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageLevelUpAward()
	{
	}
}
