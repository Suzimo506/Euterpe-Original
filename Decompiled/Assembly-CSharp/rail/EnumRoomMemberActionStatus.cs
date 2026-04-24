using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000346")]
public enum EnumRoomMemberActionStatus
{
	[Token(Token = "0x400143B")]
	kMemberEnteredRoom = 1,
	[Token(Token = "0x400143C")]
	kMemberLeftRoom = 2,
	[Token(Token = "0x400143D")]
	kMemberDisconnectServer = 4
}
