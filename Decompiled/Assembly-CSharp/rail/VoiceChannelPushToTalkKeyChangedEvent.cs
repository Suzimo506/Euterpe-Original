using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E9")]
public class VoiceChannelPushToTalkKeyChangedEvent : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015F4")]
	public uint push_to_talk_hot_key;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002FBB")]
	public VoiceChannelPushToTalkKeyChangedEvent()
	{
	}
}
