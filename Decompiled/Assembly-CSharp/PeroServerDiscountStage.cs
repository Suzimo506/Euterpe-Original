using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000066")]
public class PeroServerDiscountStage : IIAPPipelineStage
{
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x4F8FD0", Offset = "0x4F77D0", Length = "0x3B")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x4F9010", Offset = "0x4F7810", Length = "0x243")]
	[Token(Token = "0x6000315")]
	private void RequestToPeroServer(string originalProductId)
	{
	}

	[Address(RVA = "0x4F8D10", Offset = "0x4F7510", Length = "0x2B9")]
	[Token(Token = "0x6000316")]
	private void ExcuteWithServerResult(JObject result)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6000317")]
	public PeroServerDiscountStage()
	{
	}
}
