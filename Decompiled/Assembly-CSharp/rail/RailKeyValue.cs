using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A1")]
public class RailKeyValue
{
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x10")]
	public string value;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001077")]
	public string key;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CFD")]
	public RailKeyValue()
	{
	}
}
