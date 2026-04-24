using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000361")]
public class SetMemberMetadataResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001496")]
	public ulong room_id;

	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x38")]
	public RailID member_id;

	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x27221A0", Offset = "0x27209A0", Length = "0x9D")]
	public SetMemberMetadataResult()
	{
	}
}
