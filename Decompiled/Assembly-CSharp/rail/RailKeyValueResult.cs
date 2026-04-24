using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D5")]
public class RailKeyValueResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011C4")]
	public RailResult error_code;

	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x18")]
	public string value;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011C6")]
	public string key;

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailKeyValueResult()
	{
	}
}
