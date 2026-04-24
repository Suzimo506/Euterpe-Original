using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000296")]
public enum EnumRailComparisonType
{
	[Token(Token = "0x400104C")]
	kRailComparisonTypeEqualToOrLessThan = 1,
	[Token(Token = "0x400104D")]
	kRailComparisonTypeLessThan,
	[Token(Token = "0x400104E")]
	kRailComparisonTypeEqual,
	[Token(Token = "0x400104F")]
	kRailComparisonTypeGreaterThan,
	[Token(Token = "0x4001050")]
	kRailComparisonTypeEqualToOrGreaterThan,
	[Token(Token = "0x4001051")]
	kRailComparisonTypeNotEqual,
	[Token(Token = "0x4001052")]
	kRailComparisonTypeIn,
	[Token(Token = "0x4001053")]
	kRailComparisonTypeNotIn,
	[Token(Token = "0x4001054")]
	kRailComparisonTypeFuzzyMatch,
	[Token(Token = "0x4001055")]
	kRailComparisonTypeContain,
	[Token(Token = "0x4001056")]
	kRailComparisonTypeNotContain
}
