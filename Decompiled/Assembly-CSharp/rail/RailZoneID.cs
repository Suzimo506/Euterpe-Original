using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A4")]
public class RailZoneID : RailComparableID
{
	[Address(RVA = "0x2721D20", Offset = "0x2720520", Length = "0x51")]
	[Token(Token = "0x6002D01")]
	public RailZoneID()
	{
	}

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x2721CB0", Offset = "0x27204B0", Length = "0x61")]
	public RailZoneID(ulong id)
	{
	}
}
