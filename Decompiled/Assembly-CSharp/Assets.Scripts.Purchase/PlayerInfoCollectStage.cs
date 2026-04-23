using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006CE")]
public class PlayerInfoCollectStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F70")]
	[Address(RVA = "0xFE0C00", Offset = "0xFDF400", Length = "0x70")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F71")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public PlayerInfoCollectStage()
	{
	}
}
