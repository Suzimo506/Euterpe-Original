using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200029D")]
public enum EnumRailSortType
{
	[Token(Token = "0x4001072")]
	kRailSortTypeAsc = 1,
	[Token(Token = "0x4001073")]
	kRailSortTypeDesc,
	[Token(Token = "0x4001074")]
	kRailSortTypeCloseTo,
	[Token(Token = "0x4001075")]
	kRailSortTypeDistanceNear
}
