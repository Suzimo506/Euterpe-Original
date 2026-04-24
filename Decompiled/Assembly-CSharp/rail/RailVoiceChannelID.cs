using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A3")]
public class RailVoiceChannelID : RailComparableID
{
	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x2721B40", Offset = "0x2720340", Length = "0x51")]
	public RailVoiceChannelID()
	{
	}

	[Address(RVA = "0x2721BA0", Offset = "0x27203A0", Length = "0x61")]
	[Token(Token = "0x6002D00")]
	public RailVoiceChannelID(ulong id)
	{
	}
}
