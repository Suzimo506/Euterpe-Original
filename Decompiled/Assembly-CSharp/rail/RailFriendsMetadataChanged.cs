using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002CD")]
public class RailFriendsMetadataChanged : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011BE")]
	public List<RailFriendMetadata> friends_changed_metadata;

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x2720250", Offset = "0x271EA50", Length = "0x69")]
	public RailFriendsMetadataChanged()
	{
	}
}
