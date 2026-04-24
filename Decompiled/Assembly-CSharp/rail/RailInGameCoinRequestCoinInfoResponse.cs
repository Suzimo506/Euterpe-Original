using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000308")]
public class RailInGameCoinRequestCoinInfoResponse : EventBase
{
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x30")]
	public List<RailCoinInfo> coin_infos;

	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x2720990", Offset = "0x271F190", Length = "0x69")]
	public RailInGameCoinRequestCoinInfoResponse()
	{
	}
}
