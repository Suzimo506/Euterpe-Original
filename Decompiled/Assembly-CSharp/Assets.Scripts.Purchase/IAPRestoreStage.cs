using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C7")]
public class IAPRestoreStage : IIAPPipelineStage
{
	[Address(RVA = "0xFD82C0", Offset = "0xFD6AC0", Length = "0x1A1")]
	[Token(Token = "0x6003F56")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F57")]
	[Address(RVA = "0xFD82C0", Offset = "0xFD6AC0", Length = "0x1A1")]
	private void RestoreAll()
	{
	}

	[Address(RVA = "0xFD8470", Offset = "0xFD6C70", Length = "0x252")]
	[Token(Token = "0x6003F58")]
	private void OnPlatformRestorceCompleted(bool isSuccess, TransactionResult result)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003F59")]
	public IAPRestoreStage()
	{
	}
}
