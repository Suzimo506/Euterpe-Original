using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000243")]
public class IRailInGameCoinImpl : RailObject, IRailInGameCoin
{
	[Token(Token = "0x6002862")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailInGameCoinImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailInGameCoinImpl()
	{
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0xD2CCA0", Offset = "0xD2B4A0", Length = "0x65")]
	public virtual RailResult AsyncRequestCoinInfo(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0xD2CB70", Offset = "0xD2B370", Length = "0x128")]
	public virtual RailResult AsyncPurchaseCoins(RailCoins purchase_info, string user_data)
	{
		return default(RailResult);
	}
}
