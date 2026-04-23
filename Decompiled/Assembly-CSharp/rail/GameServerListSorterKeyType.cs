using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002EB")]
public enum GameServerListSorterKeyType
{
	[Token(Token = "0x400120B")]
	kGameServerListSorterKeyTypeCustom = 1,
	[Token(Token = "0x400120C")]
	kGameServerListSorterGameServerName,
	[Token(Token = "0x400120D")]
	kGameServerListSorterCurrentPlayerNumber
}
