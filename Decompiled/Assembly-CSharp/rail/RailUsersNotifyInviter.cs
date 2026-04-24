using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C8")]
public class RailUsersNotifyInviter : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400159E")]
	public RailID invitee_id;

	[Address(RVA = "0x27219D0", Offset = "0x27201D0", Length = "0x9D")]
	[Token(Token = "0x6002F75")]
	public RailUsersNotifyInviter()
	{
	}
}
