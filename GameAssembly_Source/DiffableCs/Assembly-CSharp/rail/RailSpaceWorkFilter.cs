namespace rail;

public class RailSpaceWorkFilter
{
	public List<EnumRailWorkFileClass> classes; //Field offset: 0x10
	public List<EnumRailSpaceWorkType> type; //Field offset: 0x18
	public List<RailID> collector_list; //Field offset: 0x20
	public List<RailID> subscriber_list; //Field offset: 0x28
	public List<RailID> creator_list; //Field offset: 0x30

	public RailSpaceWorkFilter() { }

}

