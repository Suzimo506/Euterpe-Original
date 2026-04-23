using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E4")]
public class RailVoiceCaptureSpecification
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015E6")]
	public EnumRailVoiceCaptureChannel channels;

	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x14")]
	public uint samples_per_second;

	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x18")]
	public uint bits_per_sample;

	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0x1C")]
	public EnumRailVoiceCaptureFormat capture_format;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002FB6")]
	public RailVoiceCaptureSpecification()
	{
	}
}
