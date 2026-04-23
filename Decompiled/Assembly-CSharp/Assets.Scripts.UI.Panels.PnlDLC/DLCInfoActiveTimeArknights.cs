using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000917")]
internal class DLCInfoActiveTimeArknights : DLCInfoActiveTime
{
	[Token(Token = "0x6005286")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected override void RefreshTimeRemainTitleText()
	{
	}

	[Token(Token = "0x6005287")]
	[Address(RVA = "0x423B40", Offset = "0x422340", Length = "0x19B")]
	protected override void RefreshTimeRemainText(TimeSpan timeSpan)
	{
	}

	[Address(RVA = "0x423CF0", Offset = "0x4224F0", Length = "0xE")]
	[Token(Token = "0x6005288")]
	public DLCInfoActiveTimeArknights()
	{
	}
}
