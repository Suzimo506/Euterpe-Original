using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E3")]
public class RailVoiceCaptureOption
{
	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailVoiceCaptureFormat voice_data_format;

	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailVoiceCaptureOption()
	{
	}
}
