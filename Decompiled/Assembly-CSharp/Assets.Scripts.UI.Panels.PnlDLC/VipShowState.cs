using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Flags]
[Token(Token = "0x2000948")]
public enum VipShowState
{
	[Token(Token = "0x400328B")]
	ShowOnSale = 0,
	[Token(Token = "0x400328C")]
	ShowPurchased = 1,
	[Token(Token = "0x400328D")]
	ShowVipNotOnSale = 2,
	[Token(Token = "0x400328E")]
	NotShow = 3
}
