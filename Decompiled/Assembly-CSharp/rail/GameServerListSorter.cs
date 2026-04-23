using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002EA")]
public class GameServerListSorter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001206")]
	public string sort_key;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001207")]
	public EnumRailSortType sort_type;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001208")]
	public GameServerListSorterKeyType sorter_key_type;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001209")]
	public EnumRailPropertyValueType sort_value_type;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002DC2")]
	public GameServerListSorter()
	{
	}
}
