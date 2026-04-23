using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200029E")]
public class RailDlcID : RailComparableID
{
	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x271F990", Offset = "0x271E190", Length = "0x51")]
	public RailDlcID()
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x271F9F0", Offset = "0x271E1F0", Length = "0x61")]
	public RailDlcID(ulong id)
	{
	}
}
