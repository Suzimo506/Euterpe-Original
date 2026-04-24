namespace rail;

public class IRailUserSpaceHelperImpl : RailObject, IRailUserSpaceHelper
{

	internal IRailUserSpaceHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data) { }

	public override RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options) { }

	public override RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type) { }

	public override RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data) { }

	public override RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options) { }

	public override RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type) { }

	public override RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data) { }

	public override RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works) { }

	public override RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by) { }

	public override RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data) { }

	public override RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options) { }

	public override RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data) { }

	public override RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data) { }

	public override RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data) { }

	public override RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data) { }

	public override RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data) { }

	public override IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type) { }

	protected virtual void Finalize() { }

	public override RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result) { }

	public override uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result) { }

	public override IRailSpaceWork OpenSpaceWork(SpaceWorkID id) { }

}

