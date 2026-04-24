using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D9")]
public class CreateVoiceChannelOption
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015C1")]
	public bool join_channel_after_created;

	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public CreateVoiceChannelOption()
	{
	}
}
