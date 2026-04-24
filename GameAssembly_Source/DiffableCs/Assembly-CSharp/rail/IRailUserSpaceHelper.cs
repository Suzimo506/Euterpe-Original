namespace rail;

public interface IRailUserSpaceHelper
{

	public RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data) { }

	public RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options) { }

	public RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type) { }

	public RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data) { }

	public RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options) { }

	public RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type) { }

	public RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data) { }

	public RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by) { }

	public RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works) { }

	public RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data) { }

	public RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options) { }

	public RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data) { }

	public RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data) { }

	public RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data) { }

	public RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data) { }

	public RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data) { }

	public IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type) { }

	public RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result) { }

	public uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result) { }

	public IRailSpaceWork OpenSpaceWork(SpaceWorkID id) { }

}

