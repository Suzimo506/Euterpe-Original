using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000259")]
public class IRailUserSpaceHelperImpl : RailObject, IRailUserSpaceHelper
{
	[Token(Token = "0x6002987")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailUserSpaceHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002988")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailUserSpaceHelperImpl()
	{
	}

	[Token(Token = "0x6002989")]
	[Address(RVA = "0x3762C0", Offset = "0x374AC0", Length = "0x1CE")]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x376490", Offset = "0x374C90", Length = "0x1B0")]
	[Token(Token = "0x600298A")]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3761D0", Offset = "0x3749D0", Length = "0xE2")]
	[Token(Token = "0x600298B")]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600298C")]
	[Address(RVA = "0x376000", Offset = "0x374800", Length = "0x1CE")]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x375E40", Offset = "0x374640", Length = "0x1B0")]
	[Token(Token = "0x600298D")]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x375D50", Offset = "0x374550", Length = "0xE2")]
	[Token(Token = "0x600298E")]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x376D80", Offset = "0x375580", Length = "0x23F")]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x376B70", Offset = "0x375370", Length = "0x20F")]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002991")]
	[Address(RVA = "0x3769C0", Offset = "0x3751C0", Length = "0x1AB")]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002992")]
	[Address(RVA = "0x376810", Offset = "0x375010", Length = "0x1A1")]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3777A0", Offset = "0x375FA0", Length = "0x1B7")]
	[Token(Token = "0x6002993")]
	public virtual RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x377FC0", Offset = "0x3767C0", Length = "0x209")]
	[Token(Token = "0x6002994")]
	public virtual IRailSpaceWork OpenSpaceWork(SpaceWorkID id)
	{
		return null;
	}

	[Token(Token = "0x6002995")]
	[Address(RVA = "0x377B70", Offset = "0x376370", Length = "0x103")]
	public virtual IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type)
	{
		return null;
	}

	[Token(Token = "0x6002996")]
	[Address(RVA = "0x377D60", Offset = "0x376560", Length = "0x25B")]
	public virtual RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002997")]
	[Address(RVA = "0x377C80", Offset = "0x376480", Length = "0xD2")]
	public virtual uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return default(uint);
	}

	[Token(Token = "0x6002998")]
	[Address(RVA = "0x3771D0", Offset = "0x3759D0", Length = "0x1F3")]
	public virtual RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002999")]
	[Address(RVA = "0x376650", Offset = "0x374E50", Length = "0x1B6")]
	public virtual RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600299A")]
	[Address(RVA = "0x377960", Offset = "0x376160", Length = "0x209")]
	public virtual RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600299B")]
	[Address(RVA = "0x3773D0", Offset = "0x375BD0", Length = "0x3CD")]
	public virtual RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600299C")]
	[Address(RVA = "0x376FC0", Offset = "0x3757C0", Length = "0x209")]
	public virtual RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data)
	{
		return default(RailResult);
	}
}
