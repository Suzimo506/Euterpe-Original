using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200026E")]
public class CompleteConsumeAssetsFinished : EventBase
{
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x30")]
	public RailAssetItem asset_item;

	[Address(RVA = "0xD1F890", Offset = "0xD1E090", Length = "0x64")]
	[Token(Token = "0x6002CAC")]
	public CompleteConsumeAssetsFinished()
	{
	}
}
