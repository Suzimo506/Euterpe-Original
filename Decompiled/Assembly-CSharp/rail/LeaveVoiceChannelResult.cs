using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E2")]
public class LeaveVoiceChannelResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015E3")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0x38")]
	public EnumRailVoiceLeaveChannelReason reason;

	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x37E440", Offset = "0x37CC40", Length = "0x64")]
	public LeaveVoiceChannelResult()
	{
	}
}
