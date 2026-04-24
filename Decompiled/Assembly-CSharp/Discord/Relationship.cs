using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000427")]
public struct Relationship
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400172B")]
	public RelationshipType Type;

	[Token(Token = "0x400172C")]
	[FieldOffset(Offset = "0x8")]
	public User User;

	[Token(Token = "0x400172D")]
	[FieldOffset(Offset = "0x30")]
	public Presence Presence;
}
