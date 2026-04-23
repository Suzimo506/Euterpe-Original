using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000364")]
public class SetRoomMetadataResult : EventBase
{
	[Token(Token = "0x4001498")]
	[FieldOffset(Offset = "0x30")]
	public ulong room_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E96")]
	public SetRoomMetadataResult()
	{
	}
}
