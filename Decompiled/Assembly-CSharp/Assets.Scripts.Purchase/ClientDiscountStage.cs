using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C2")]
public class ClientDiscountStage : IIAPPipelineStage
{
	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0xD8")]
	private ClientDiscountManager cdm;

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0xFD36C0", Offset = "0xFD1EC0", Length = "0x5E")]
	public ClientDiscountStage()
	{
	}

	[Address(RVA = "0xFD3460", Offset = "0xFD1C60", Length = "0x258")]
	[Token(Token = "0x6003F46")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F47")]
	[Address(RVA = "0xFD3360", Offset = "0xFD1B60", Length = "0xFE")]
	private void ClientDiscountManagerCollected(bool isCollectSuccess)
	{
	}
}
