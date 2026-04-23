using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000373")]
public interface IRailGlobalStats : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EAD")]
	RailResult AsyncRequestGlobalStats(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EAE")]
	RailResult GetGlobalStatValue(string name, out long data);

	[Token(Token = "0x6002EAF")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGlobalStatValue(string name, out double data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EB0")]
	RailResult GetGlobalStatValueHistory(string name, long[] global_stats_data, uint data_size, out int num_global_stats);

	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGlobalStatValueHistory(string name, double[] global_stats_data, uint data_size, out int num_global_stats);
}
