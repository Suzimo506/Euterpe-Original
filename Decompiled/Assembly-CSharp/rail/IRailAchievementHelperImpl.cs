using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022C")]
public class IRailAchievementHelperImpl : RailObject, IRailAchievementHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002732")]
	internal IRailAchievementHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002733")]
	~IRailAchievementHelperImpl()
	{
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0xD20760", Offset = "0xD1EF60", Length = "0x1AF")]
	public virtual IRailPlayerAchievement CreatePlayerAchievement(RailID player)
	{
		return null;
	}

	[Token(Token = "0x6002735")]
	[Address(RVA = "0xD20910", Offset = "0xD1F110", Length = "0xA0")]
	public virtual IRailGlobalAchievement GetGlobalAchievement()
	{
		return null;
	}
}
