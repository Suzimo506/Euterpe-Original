using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Serializable]
[Token(Token = "0x20006DA")]
public enum TransactionState
{
	[Token(Token = "0x40024A8")]
	BaginPurchase,
	[Token(Token = "0x40024A9")]
	Purchased,
	[Token(Token = "0x40024AA")]
	Restored,
	[Token(Token = "0x40024AB")]
	Deferred,
	[Token(Token = "0x40024AC")]
	Failed
}
