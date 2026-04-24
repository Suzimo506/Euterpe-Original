using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000322")]
public class LeaderboardParameters
{
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x10")]
	public string param;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002E19")]
	public LeaderboardParameters()
	{
	}
}
