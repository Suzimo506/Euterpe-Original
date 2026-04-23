using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000329")]
public class UploadLeaderboardParam
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001290")]
	public LeaderboardData data;

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x18")]
	public LeaderboardUploadType type;

	[Address(RVA = "0x2722560", Offset = "0x2720D60", Length = "0x64")]
	[Token(Token = "0x6002E1D")]
	public UploadLeaderboardParam()
	{
	}
}
