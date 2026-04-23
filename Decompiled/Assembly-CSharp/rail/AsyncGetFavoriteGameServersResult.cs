using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E3")]
public class AsyncGetFavoriteGameServersResult : EventBase
{
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x30")]
	public List<RailID> server_id_array;

	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0xD1F280", Offset = "0xD1DA80", Length = "0x69")]
	public AsyncGetFavoriteGameServersResult()
	{
	}
}
