using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000374")]
public interface IRailPlayerStats : IRailComponent
{
	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailID GetRailID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB3")]
	RailResult AsyncRequestStats(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB4")]
	RailResult GetStatValue(string name, out int data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB5")]
	RailResult GetStatValue(string name, out double data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB6")]
	RailResult SetStatValue(string name, int data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB7")]
	RailResult SetStatValue(string name, double data);

	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult UpdateAverageStatValue(string name, double data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB9")]
	RailResult AsyncStoreStats(string user_data);

	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ResetAllStats();
}
