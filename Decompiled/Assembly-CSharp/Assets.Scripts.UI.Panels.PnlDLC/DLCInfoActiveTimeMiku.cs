using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000918")]
internal class DLCInfoActiveTimeMiku : DLCInfoActiveTime
{
	[Token(Token = "0x6005289")]
	[Address(RVA = "0x423EA0", Offset = "0x4226A0", Length = "0x5F")]
	protected override void RefreshTimeRemainTitleText()
	{
	}

	[Address(RVA = "0x423D00", Offset = "0x422500", Length = "0x19B")]
	[Token(Token = "0x600528A")]
	protected override void RefreshTimeRemainText(TimeSpan timeSpan)
	{
	}

	[Token(Token = "0x600528B")]
	[Address(RVA = "0x423CF0", Offset = "0x4224F0", Length = "0xE")]
	public DLCInfoActiveTimeMiku()
	{
	}
}
