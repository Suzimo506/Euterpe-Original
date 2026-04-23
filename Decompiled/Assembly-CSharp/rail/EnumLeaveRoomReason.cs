using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000345")]
public enum EnumLeaveRoomReason
{
	[Token(Token = "0x4001437")]
	kLeaveRoomReasonActive = 1,
	[Token(Token = "0x4001438")]
	kLeaveRoomReasonTimeout,
	[Token(Token = "0x4001439")]
	kLeaveRoomReasonKick
}
