using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006BF")]
public class ChineseAdultCheckStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F39")]
	[Address(RVA = "0x9755E0", Offset = "0x973DE0", Length = "0x1BE")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x975160", Offset = "0x973960", Length = "0x15D")]
	[Token(Token = "0x6003F3A")]
	private void CheckAdult()
	{
	}

	[Address(RVA = "0x975300", Offset = "0x973B00", Length = "0x2D1")]
	[Token(Token = "0x6003F3B")]
	private void CheckSuccess(float fAmount)
	{
	}

	[Token(Token = "0x6003F3C")]
	[Address(RVA = "0x9752C0", Offset = "0x973AC0", Length = "0x3F")]
	private void CheckFailed(long code)
	{
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0x9757A0", Offset = "0x973FA0", Length = "0x25")]
	private void ToNextStage()
	{
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public ChineseAdultCheckStage()
	{
	}
}
