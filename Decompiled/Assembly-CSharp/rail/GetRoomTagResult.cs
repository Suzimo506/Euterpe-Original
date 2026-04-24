using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034E")]
public class GetRoomTagResult : EventBase
{
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x30")]
	public string room_tag;

	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public GetRoomTagResult()
	{
	}
}
