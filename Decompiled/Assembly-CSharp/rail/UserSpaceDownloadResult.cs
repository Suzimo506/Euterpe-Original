using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003BA")]
public class UserSpaceDownloadResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400157A")]
	public uint total_results;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400157B")]
	public List<RailUserSpaceDownloadResult> results;

	[Address(RVA = "0x2722640", Offset = "0x2720E40", Length = "0x69")]
	[Token(Token = "0x6002F63")]
	public UserSpaceDownloadResult()
	{
	}
}
