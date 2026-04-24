using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000282")]
public class UpdateAssetsPropertyFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400100A")]
	public List<RailAssetProperty> asset_property_list;

	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0x27224F0", Offset = "0x2720CF0", Length = "0x69")]
	public UpdateAssetsPropertyFinished()
	{
	}
}
