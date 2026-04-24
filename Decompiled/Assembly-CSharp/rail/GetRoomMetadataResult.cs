using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034D")]
public class GetRoomMetadataResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001451")]
	public List<RailKeyValue> key_value;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001452")]
	public ulong room_id;

	[Address(RVA = "0xD20680", Offset = "0xD1EE80", Length = "0x69")]
	[Token(Token = "0x6002E7F")]
	public GetRoomMetadataResult()
	{
	}
}
