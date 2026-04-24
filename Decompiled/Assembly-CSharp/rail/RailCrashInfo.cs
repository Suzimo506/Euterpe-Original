using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003CF")]
public class RailCrashInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015AC")]
	public RailUtilsCrashType exception_type;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F88")]
	public RailCrashInfo()
	{
	}
}
