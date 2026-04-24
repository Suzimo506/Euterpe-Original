using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000267")]
public interface IRailPlayerAchievement : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C7E")]
	RailID GetRailID();

	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRequestAchievement(string user_data);

	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult HasAchieved(string name, out bool achieved);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C81")]
	RailResult GetAchievementInfo(string name, out string achievement_info);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C82")]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C83")]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C84")]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C85")]
	RailResult MakeAchievement(string name);

	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult CancelAchievement(string name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C87")]
	RailResult AsyncStoreAchievement(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C88")]
	RailResult ResetAllAchievements();

	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetAllAchievementsName(List<string> names);
}
