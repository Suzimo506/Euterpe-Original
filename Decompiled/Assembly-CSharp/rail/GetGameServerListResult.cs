using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002EF")]
public class GetGameServerListResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001212")]
	public List<GameServerInfo> server_info;

	[Token(Token = "0x4001213")]
	[FieldOffset(Offset = "0x38")]
	public uint total_num;

	[Token(Token = "0x4001214")]
	[FieldOffset(Offset = "0x3C")]
	public uint start_index;

	[Token(Token = "0x4001215")]
	[FieldOffset(Offset = "0x40")]
	public uint end_index;

	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0xD20350", Offset = "0xD1EB50", Length = "0x69")]
	public GetGameServerListResult()
	{
	}
}
