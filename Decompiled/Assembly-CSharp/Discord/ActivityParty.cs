using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000423")]
public struct ActivityParty
{
	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x0")]
	public string Id;

	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0x8")]
	public PartySize Size;
}
