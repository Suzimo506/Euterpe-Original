using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006CF")]
public class ProductPriceCollectStage : IIAPPipelineStage
{
	[Address(RVA = "0x657D10", Offset = "0x656510", Length = "0x198")]
	[Token(Token = "0x6003F72")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6003F73")]
	public ProductPriceCollectStage()
	{
	}
}
