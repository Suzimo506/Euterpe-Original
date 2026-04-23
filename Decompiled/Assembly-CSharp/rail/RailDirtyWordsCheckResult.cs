using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D0")]
public class RailDirtyWordsCheckResult
{
	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailDirtyWordsType dirty_type;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015AE")]
	public string replace_string;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F89")]
	public RailDirtyWordsCheckResult()
	{
	}
}
