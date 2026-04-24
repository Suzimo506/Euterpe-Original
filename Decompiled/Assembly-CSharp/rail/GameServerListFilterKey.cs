using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E9")]
public class GameServerListFilterKey
{
	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x10")]
	public string filter_value;

	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x18")]
	public string key_name;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001204")]
	public EnumRailPropertyValueType value_type;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001205")]
	public EnumRailComparisonType comparison_type;

	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GameServerListFilterKey()
	{
	}
}
