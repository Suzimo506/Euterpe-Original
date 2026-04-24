using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A0")]
public class RailID : RailComparableID
{
	[Address(RVA = "0x2720930", Offset = "0x271F130", Length = "0x51")]
	[Token(Token = "0x6002CFA")]
	public RailID()
	{
	}

	[Address(RVA = "0x27208C0", Offset = "0x271F0C0", Length = "0x61")]
	[Token(Token = "0x6002CFB")]
	public RailID(ulong id)
	{
	}

	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x27208B0", Offset = "0x271F0B0", Length = "0xA")]
	public EnumRailIDDomain GetDomain()
	{
		return default(EnumRailIDDomain);
	}
}
