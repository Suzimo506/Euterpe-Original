using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200029F")]
public class RailGameID : RailComparableID
{
	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x27204F0", Offset = "0x271ECF0", Length = "0x51")]
	public RailGameID()
	{
	}

	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x2720550", Offset = "0x271ED50", Length = "0x61")]
	public RailGameID(ulong id)
	{
	}
}
