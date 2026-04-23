using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E5")]
public class RailVoiceChannelUserSpeakingState
{
	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailVoiceChannelUserSpeakingLimit speaking_limit;

	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0x18")]
	public RailID user_id;

	[Address(RVA = "0x2721C10", Offset = "0x2720410", Length = "0x9D")]
	[Token(Token = "0x6002FB7")]
	public RailVoiceChannelUserSpeakingState()
	{
	}
}
