using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035D")]
public class RoomInfoListFilterKey
{
	[Token(Token = "0x4001484")]
	[FieldOffset(Offset = "0x10")]
	public string filter_value;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001485")]
	public string key_name;

	[Token(Token = "0x4001486")]
	[FieldOffset(Offset = "0x20")]
	public EnumRailPropertyValueType value_type;

	[Token(Token = "0x4001487")]
	[FieldOffset(Offset = "0x24")]
	public EnumRailComparisonType comparison_type;

	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RoomInfoListFilterKey()
	{
	}
}
