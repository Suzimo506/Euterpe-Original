using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006CA")]
public class LoginServerCheckStage : IIAPPipelineStage
{
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	[Token(Token = "0x6003F64")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F65")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LoginServerCheckStage()
	{
	}
}
