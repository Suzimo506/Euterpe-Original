namespace rail;

public class GameServerListSorter
{
	public string sort_key; //Field offset: 0x10
	public EnumRailSortType sort_type; //Field offset: 0x18
	public GameServerListSorterKeyType sorter_key_type; //Field offset: 0x1C
	public EnumRailPropertyValueType sort_value_type; //Field offset: 0x20

	public GameServerListSorter() { }

}

