using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200036C")]
public interface IRailSmallObjectServiceHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EA5")]
	RailResult AsyncDownloadObjects(List<uint> indexes, string user_data);

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetObjectContent(uint index, out string content);

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryObjectState(string user_data);
}
