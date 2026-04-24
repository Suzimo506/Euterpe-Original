using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Token(Token = "0x200094C")]
public struct AnnounceRequestResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40032AC")]
	public AnnouncesRequestState state;

	[Token(Token = "0x40032AD")]
	[FieldOffset(Offset = "0x8")]
	public long resultCode;

	[Token(Token = "0x40032AE")]
	[FieldOffset(Offset = "0x10")]
	public string msg;
}
