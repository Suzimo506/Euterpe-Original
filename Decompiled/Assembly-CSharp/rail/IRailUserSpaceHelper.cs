using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000397")]
public interface IRailUserSpaceHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F37")]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data);

	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F39")]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F3A")]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data);

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options);

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F3D")]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F3E")]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F3F")]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by);

	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F41")]
	RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data);

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailSpaceWork OpenSpaceWork(SpaceWorkID id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F43")]
	IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F44")]
	RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result);

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result);

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data);

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data);

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data);

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data);

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data);
}
