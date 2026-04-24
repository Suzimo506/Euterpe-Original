using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200036F")]
public class RailSmallObjectDownloadResult : EventBase
{
	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x30")]
	public List<RailSmallObjectDownloadInfo> download_infos;

	[Address(RVA = "0x2721110", Offset = "0x271F910", Length = "0x69")]
	[Token(Token = "0x6002EA9")]
	public RailSmallObjectDownloadResult()
	{
	}
}
