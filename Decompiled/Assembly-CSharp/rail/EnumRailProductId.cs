using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030A")]
public enum EnumRailProductId
{
	[Token(Token = "0x400123D")]
	EnumRailProductId_For_Game_Start = 1,
	[Token(Token = "0x400123E")]
	EnumRailProductId_For_Game_End = 1000000000,
	[Token(Token = "0x400123F")]
	EnumRailProductId_For_Platfrom_Start = 1000000001,
	[Token(Token = "0x4001240")]
	EnumRailProductId_For_Platfrom_Storage_Space = 1000000001,
	[Token(Token = "0x4001241")]
	EnumRailProductId_For_Platfrom_All = 1000000011
}
