using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002CA")]
public class RailFriendsGetInviteCommandLine : EventBase
{
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x30")]
	public RailID friend_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011BB")]
	public string invite_command_line;

	[Address(RVA = "0x27200E0", Offset = "0x271E8E0", Length = "0x9D")]
	[Token(Token = "0x6002D57")]
	public RailFriendsGetInviteCommandLine()
	{
	}
}
