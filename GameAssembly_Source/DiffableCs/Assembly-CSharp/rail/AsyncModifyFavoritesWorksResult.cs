namespace rail;

public class AsyncModifyFavoritesWorksResult : EventBase
{
	public List<SpaceWorkID> success_ids; //Field offset: 0x30
	public List<SpaceWorkID> failure_ids; //Field offset: 0x38
	public EnumRailModifyFavoritesSpaceWorkType modify_flag; //Field offset: 0x40

	public AsyncModifyFavoritesWorksResult() { }

}

