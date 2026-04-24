namespace rail;

public class RoomInfoListFilter
{
	public EnumRailOptionalValue filter_friends_in_room; //Field offset: 0x10
	public string room_tag; //Field offset: 0x18
	public uint available_slot_at_least; //Field offset: 0x20
	public EnumRailOptionalValue filter_password; //Field offset: 0x24
	public string room_name_contained; //Field offset: 0x28
	public List<RoomInfoListFilterKey> key_filters; //Field offset: 0x30
	public EnumRailOptionalValue filter_friends_owned; //Field offset: 0x38

	public RoomInfoListFilter() { }

}

