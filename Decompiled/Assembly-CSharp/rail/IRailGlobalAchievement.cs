using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000266")]
public interface IRailGlobalAchievement : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C7B")]
	RailResult AsyncRequestAchievement(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C7C")]
	RailResult GetGlobalAchievedPercent(string name, out double percent);

	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGlobalAchievedPercentDescending(int index, out string name, out double percent);
}
