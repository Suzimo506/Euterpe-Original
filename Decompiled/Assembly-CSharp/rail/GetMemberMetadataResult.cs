using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034A")]
public class GetMemberMetadataResult : EventBase
{
	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x30")]
	public List<RailKeyValue> key_value;

	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x38")]
	public ulong room_id;

	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x40")]
	public RailID member_id;

	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0xD20500", Offset = "0xD1ED00", Length = "0x91")]
	public GetMemberMetadataResult()
	{
	}
}
