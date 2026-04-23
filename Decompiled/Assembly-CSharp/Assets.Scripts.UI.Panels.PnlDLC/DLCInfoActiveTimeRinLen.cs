using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000919")]
internal class DLCInfoActiveTimeRinLen : DLCInfoActiveTime
{
	[Token(Token = "0x600528C")]
	[Address(RVA = "0x423F00", Offset = "0x422700", Length = "0x19B")]
	protected override void RefreshTimeRemainText(TimeSpan timeSpan)
	{
	}

	[Token(Token = "0x600528D")]
	[Address(RVA = "0x423CF0", Offset = "0x4224F0", Length = "0xE")]
	public DLCInfoActiveTimeRinLen()
	{
	}
}
