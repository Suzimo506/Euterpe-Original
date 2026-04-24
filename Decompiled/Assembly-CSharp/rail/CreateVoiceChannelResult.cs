using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003DA")]
public class CreateVoiceChannelResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015C2")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0xD1FA90", Offset = "0xD1E290", Length = "0x64")]
	public CreateVoiceChannelResult()
	{
	}
}
