using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000246")]
public class IRailLeaderboardImpl : RailObject, IRailLeaderboard, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002871")]
	internal IRailLeaderboardImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002872")]
	~IRailLeaderboardImpl()
	{
	}

	[Address(RVA = "0xD2DE80", Offset = "0xD2C680", Length = "0x5F")]
	[Token(Token = "0x6002873")]
	public virtual string GetLeaderboardName()
	{
		return null;
	}

	[Address(RVA = "0xD2E080", Offset = "0xD2C880", Length = "0x55")]
	[Token(Token = "0x6002874")]
	public virtual int GetTotalEntriesCount()
	{
		return default(int);
	}

	[Address(RVA = "0xD2DB70", Offset = "0xD2C370", Length = "0x65")]
	[Token(Token = "0x6002875")]
	public virtual RailResult AsyncGetLeaderboard(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2DEE0", Offset = "0xD2C6E0", Length = "0x12E")]
	[Token(Token = "0x6002876")]
	public virtual RailResult GetLeaderboardParameters(LeaderboardParameters param)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2DD10", Offset = "0xD2C510", Length = "0xA0")]
	[Token(Token = "0x6002877")]
	public virtual IRailLeaderboardEntries CreateLeaderboardEntries()
	{
		return null;
	}

	[Token(Token = "0x6002878")]
	[Address(RVA = "0xD2DBE0", Offset = "0xD2C3E0", Length = "0x128")]
	public virtual RailResult AsyncUploadLeaderboard(UploadLeaderboardParam update_param, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002879")]
	[Address(RVA = "0xD2E010", Offset = "0xD2C810", Length = "0x65")]
	public virtual RailResult GetLeaderboardSortType(out int sort_type)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref sort_type) = null;
		return default(RailResult);
	}

	[Token(Token = "0x600287A")]
	[Address(RVA = "0xD2DE10", Offset = "0xD2C610", Length = "0x65")]
	public virtual RailResult GetLeaderboardDisplayType(out int display_type)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref display_type) = null;
		return default(RailResult);
	}

	[Token(Token = "0x600287B")]
	[Address(RVA = "0xD2D9F0", Offset = "0xD2C1F0", Length = "0x17B")]
	public virtual RailResult AsyncAttachSpaceWork(SpaceWorkID spacework_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600287C")]
	[Address(RVA = "0xD2DDB0", Offset = "0xD2C5B0", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD2E0E0", Offset = "0xD2C8E0", Length = "0x55")]
	[Token(Token = "0x600287D")]
	public virtual void Release()
	{
	}
}
