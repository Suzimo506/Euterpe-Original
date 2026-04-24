using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000265")]
public interface IRailAchievementHelper
{
	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailPlayerAchievement CreatePlayerAchievement(RailID player);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C7A")]
	IRailGlobalAchievement GetGlobalAchievement();
}
