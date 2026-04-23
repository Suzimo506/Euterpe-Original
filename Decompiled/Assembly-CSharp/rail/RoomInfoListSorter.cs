using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035E")]
public class RoomInfoListSorter
{
	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0x10")]
	public double close_to_value;

	[Token(Token = "0x4001489")]
	[FieldOffset(Offset = "0x18")]
	public string property_key;

	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x20")]
	public EnumRailSortType property_sort_type;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400148B")]
	public EnumRailPropertyValueType property_value_type;

	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RoomInfoListSorter()
	{
	}
}
