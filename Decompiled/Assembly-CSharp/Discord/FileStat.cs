using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000429")]
public struct FileStat
{
	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x0")]
	public string Filename;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x8")]
	public ulong Size;

	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x10")]
	public ulong LastModified;
}
