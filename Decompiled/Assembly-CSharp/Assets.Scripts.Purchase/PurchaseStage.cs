using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D0")]
public class PurchaseStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F74")]
	[Address(RVA = "0x658190", Offset = "0x656990", Length = "0xB2")]
	public PurchaseStage()
	{
	}

	[Address(RVA = "0x657F70", Offset = "0x656770", Length = "0x14A")]
	[Token(Token = "0x6003F75")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x6580C0", Offset = "0x6568C0", Length = "0xC7")]
	[Token(Token = "0x6003F76")]
	private void OnTransactionCompleted(TransactionResult transactionResult)
	{
	}

	[Address(RVA = "0x657EB0", Offset = "0x6566B0", Length = "0xB3")]
	[Token(Token = "0x6003F77")]
	private IAPOrder GetIAPOrderByIAPPipelineContext(IAPPipelineContext context)
	{
		return default(IAPOrder);
	}
}
