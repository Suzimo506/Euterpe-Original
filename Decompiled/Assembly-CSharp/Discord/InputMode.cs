using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042D")]
public struct InputMode
{
	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x0")]
	public InputModeType Type;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x8")]
	public string Shortcut;
}
