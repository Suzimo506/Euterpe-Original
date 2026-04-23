using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000270")]
public class DirectConsumeAssetsFinished : EventBase
{
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x30")]
	public List<RailAssetItem> assets;

	[Address(RVA = "0xD1FB00", Offset = "0xD1E300", Length = "0x69")]
	[Token(Token = "0x6002CAE")]
	public DirectConsumeAssetsFinished()
	{
	}
}
