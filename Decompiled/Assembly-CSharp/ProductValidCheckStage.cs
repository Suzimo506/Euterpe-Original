using Assets.Scripts.Purchase;
using Cpp2ILInjected;

[Token(Token = "0x2000067")]
public class ProductValidCheckStage : IIAPPipelineStage
{
	[Address(RVA = "0x5699F0", Offset = "0x5681F0", Length = "0x2EE")]
	[Token(Token = "0x6000319")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public ProductValidCheckStage()
	{
	}
}
