using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000281")]
public class StartConsumeAssetsFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001009")]
	public ulong asset_id;

	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public StartConsumeAssetsFinished()
	{
	}
}
