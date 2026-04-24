namespace rail;

public class AsyncSearchSpaceWorksResult : EventBase
{
	public uint total_available_works; //Field offset: 0x30
	public List<RailSpaceWorkDescriptor> spacework_descriptors; //Field offset: 0x38

	public AsyncSearchSpaceWorksResult() { }

}

