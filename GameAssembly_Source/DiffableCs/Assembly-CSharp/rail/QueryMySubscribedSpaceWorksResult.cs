namespace rail;

public class QueryMySubscribedSpaceWorksResult
{
	public uint total_available_works; //Field offset: 0x10
	public EnumRailSpaceWorkType spacework_type; //Field offset: 0x14
	public List<RailSpaceWorkDescriptor> spacework_descriptors; //Field offset: 0x18

	public QueryMySubscribedSpaceWorksResult() { }

}

