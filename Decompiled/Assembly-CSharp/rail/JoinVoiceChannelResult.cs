using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E1")]
public class JoinVoiceChannelResult : EventBase
{
	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0x30")]
	public RailVoiceChannelID already_joined_channel_id;

	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x38")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x37E170", Offset = "0x37C970", Length = "0x8C")]
	public JoinVoiceChannelResult()
	{
	}
}
