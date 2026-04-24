using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000248")]
public class IRailLeaderboardHelperImpl : RailObject, IRailLeaderboardHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002888")]
	internal IRailLeaderboardHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailLeaderboardHelperImpl()
	{
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0xD2D940", Offset = "0xD2C140", Length = "0xA7")]
	public virtual IRailLeaderboard OpenLeaderboard(string leaderboard_name)
	{
		return null;
	}

	[Token(Token = "0x600288B")]
	[Address(RVA = "0xD2D860", Offset = "0xD2C060", Length = "0xD8")]
	public virtual IRailLeaderboard AsyncCreateLeaderboard(string leaderboard_name, LeaderboardSortType sort_type, LeaderboardDisplayType display_type, string user_data, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}
}
