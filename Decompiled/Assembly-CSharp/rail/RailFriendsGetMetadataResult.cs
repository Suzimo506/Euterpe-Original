using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002CB")]
public class RailFriendsGetMetadataResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011BC")]
	public RailID friend_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011BD")]
	public List<RailKeyValueResult> friend_kvs;

	[Address(RVA = "0x2720180", Offset = "0x271E980", Length = "0xCA")]
	[Token(Token = "0x6002D58")]
	public RailFriendsGetMetadataResult()
	{
	}
}
