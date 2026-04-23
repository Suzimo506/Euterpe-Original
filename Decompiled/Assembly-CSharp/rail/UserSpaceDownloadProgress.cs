using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B9")]
public class UserSpaceDownloadProgress : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001578")]
	public List<RailUserSpaceDownloadProgress> progress;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x38")]
	public uint total_progress;

	[Address(RVA = "0x27225D0", Offset = "0x2720DD0", Length = "0x69")]
	[Token(Token = "0x6002F62")]
	public UserSpaceDownloadProgress()
	{
	}
}
