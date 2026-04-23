using Cpp2ILInjected;

namespace Assets.Scripts.Helpers;

[Token(Token = "0x20006E3")]
public struct AccountGameDatas
{
	[Token(Token = "0x40024FF")]
	[FieldOffset(Offset = "0x0")]
	public string nickname;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4002500")]
	public int accountLevel;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002501")]
	public string iapInfoStr;
}
