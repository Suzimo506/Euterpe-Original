using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000375")]
public interface IRailStatisticHelper
{
	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailPlayerStats CreatePlayerStats(RailID player);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EBC")]
	IRailGlobalStats GetGlobalStats();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EBD")]
	RailResult AsyncGetNumberOfPlayer(string user_data);
}
