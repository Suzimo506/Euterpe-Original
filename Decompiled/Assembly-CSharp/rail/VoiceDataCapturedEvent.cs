using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003ED")]
public class VoiceDataCapturedEvent : EventBase
{
	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0x30")]
	public bool is_last_package;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002FBF")]
	public VoiceDataCapturedEvent()
	{
	}
}
