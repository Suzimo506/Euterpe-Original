using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E7")]
public class VoiceChannelInviteEvent : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015EF")]
	public string channel_name;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x38")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x40")]
	public string inviter_name;

	[Address(RVA = "0x27227B0", Offset = "0x2720FB0", Length = "0x9D")]
	[Token(Token = "0x6002FB9")]
	public VoiceChannelInviteEvent()
	{
	}
}
