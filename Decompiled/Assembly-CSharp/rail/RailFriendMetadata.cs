using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C3")]
public class RailFriendMetadata
{
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x10")]
	public RailID friend_rail_id;

	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x18")]
	public List<RailKeyValue> metadatas;

	[Address(RVA = "0x271FCD0", Offset = "0x271E4D0", Length = "0xCA")]
	[Token(Token = "0x6002D51")]
	public RailFriendMetadata()
	{
	}
}
