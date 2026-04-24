namespace rail;

public class GameServerListFilterKey
{
	public string filter_value; //Field offset: 0x10
	public string key_name; //Field offset: 0x18
	public EnumRailPropertyValueType value_type; //Field offset: 0x20
	public EnumRailComparisonType comparison_type; //Field offset: 0x24

	public GameServerListFilterKey() { }

}

