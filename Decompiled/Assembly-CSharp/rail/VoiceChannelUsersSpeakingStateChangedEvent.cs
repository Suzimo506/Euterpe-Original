using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003EC")]
public class VoiceChannelUsersSpeakingStateChangedEvent : EventBase
{
	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0x30")]
	public RailVoiceChannelID voice_channel_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015FC")]
	public List<RailVoiceChannelUserSpeakingState> users_speaking_state;

	[Address(RVA = "0x2722B20", Offset = "0x2721320", Length = "0xCA")]
	[Token(Token = "0x6002FBE")]
	public VoiceChannelUsersSpeakingStateChangedEvent()
	{
	}
}
