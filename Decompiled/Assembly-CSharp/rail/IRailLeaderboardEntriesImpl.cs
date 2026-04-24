using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000247")]
public class IRailLeaderboardEntriesImpl : RailObject, IRailLeaderboardEntries, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600287E")]
	internal IRailLeaderboardEntriesImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600287F")]
	~IRailLeaderboardEntriesImpl()
	{
	}

	[Address(RVA = "0xD2D770", Offset = "0xD2BF70", Length = "0x8C")]
	[Token(Token = "0x6002880")]
	public virtual RailID GetRailID()
	{
		return null;
	}

	[Address(RVA = "0xD2D710", Offset = "0xD2BF10", Length = "0x5F")]
	[Token(Token = "0x6002881")]
	public virtual string GetLeaderboardName()
	{
		return null;
	}

	[Token(Token = "0x6002882")]
	[Address(RVA = "0xD2D290", Offset = "0xD2BA90", Length = "0x1E3")]
	public virtual RailResult AsyncRequestLeaderboardEntries(RailID player, RequestLeaderboardEntryParam param, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002883")]
	[Address(RVA = "0xD2D540", Offset = "0xD2BD40", Length = "0x8C")]
	public virtual RequestLeaderboardEntryParam GetEntriesParam()
	{
		return null;
	}

	[Address(RVA = "0xD2D4E0", Offset = "0xD2BCE0", Length = "0x55")]
	[Token(Token = "0x6002884")]
	public virtual int GetEntriesCount()
	{
		return default(int);
	}

	[Address(RVA = "0xD2D5D0", Offset = "0xD2BDD0", Length = "0x132")]
	[Token(Token = "0x6002885")]
	public virtual RailResult GetLeaderboardEntry(int index, LeaderboardEntry leaderboard_entry)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2D480", Offset = "0xD2BC80", Length = "0x55")]
	[Token(Token = "0x6002886")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD2D800", Offset = "0xD2C000", Length = "0x55")]
	[Token(Token = "0x6002887")]
	public virtual void Release()
	{
	}
}
