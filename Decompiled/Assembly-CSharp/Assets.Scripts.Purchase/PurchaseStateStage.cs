using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D1")]
public class PurchaseStateStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F78")]
	[Address(RVA = "0x658290", Offset = "0x656A90", Length = "0xC2")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F79")]
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	private void CheckSuccess()
	{
	}

	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0x658250", Offset = "0x656A50", Length = "0x3F")]
	private void CheckFailed()
	{
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public PurchaseStateStage()
	{
	}
}
