using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003EB")]
public class VoiceChannelSpeakingUsersChangedEvent : EventBase
{
	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x30")]
	public List<RailID> speaking_users;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015F9")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0x40")]
	public List<RailID> not_speaking_users;

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x2722A20", Offset = "0x2721220", Length = "0xF7")]
	public VoiceChannelSpeakingUsersChangedEvent()
	{
	}
}
