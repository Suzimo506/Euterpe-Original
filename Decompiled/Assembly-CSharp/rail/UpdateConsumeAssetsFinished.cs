using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000283")]
public class UpdateConsumeAssetsFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400100B")]
	public ulong asset_id;

	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public UpdateConsumeAssetsFinished()
	{
	}
}
