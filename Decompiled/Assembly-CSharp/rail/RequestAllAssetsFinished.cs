using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200027E")]
public class RequestAllAssetsFinished : EventBase
{
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x30")]
	public List<RailAssetInfo> assetinfo_list;

	[Address(RVA = "0x2721D80", Offset = "0x2720580", Length = "0x69")]
	[Token(Token = "0x6002CB9")]
	public RequestAllAssetsFinished()
	{
	}
}
