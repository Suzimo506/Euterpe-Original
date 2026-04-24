using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006AE")]
public interface IGetSpecialDLC
{
	[Token(Token = "0x170005CB")]
	Action<Dictionary<string, bool>> getCallback
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003EB9")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003EB8")]
		set;
	}

	[Token(Token = "0x6003EBA")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Init();

	[Token(Token = "0x6003EBB")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Get();
}
