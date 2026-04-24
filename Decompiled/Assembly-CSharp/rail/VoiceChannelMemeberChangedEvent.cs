using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E8")]
public class VoiceChannelMemeberChangedEvent : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015F2")]
	public RailVoiceChannelID voice_channel_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015F3")]
	public List<RailID> member_ids;

	[Address(RVA = "0x2722850", Offset = "0x2721050", Length = "0xCA")]
	[Token(Token = "0x6002FBA")]
	public VoiceChannelMemeberChangedEvent()
	{
	}
}
