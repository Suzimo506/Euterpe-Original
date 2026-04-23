using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C0")]
public class ChineseRealNameCheckStage : IIAPPipelineStage
{
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	[Token(Token = "0x6003F3F")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x9757D0", Offset = "0x973FD0", Length = "0x134")]
	[Token(Token = "0x6003F40")]
	private bool CheckAccountRealNameVerify(out string errorMsg)
	{
		errorMsg = null;
		return default(bool);
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public ChineseRealNameCheckStage()
	{
	}
}
