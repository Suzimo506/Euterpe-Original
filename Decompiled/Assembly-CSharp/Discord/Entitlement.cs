using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042A")]
public struct Entitlement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001737")]
	public long Id;

	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0x8")]
	public EntitlementType Type;

	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0x10")]
	public long SkuId;
}
