using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000063")]
public class PeroServerDiscountCollector : IDiscountCollector
{
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x20")]
	private bool isRequestFinished;

	[Address(RVA = "0x4F84F0", Offset = "0x4F6CF0", Length = "0x16")]
	[Token(Token = "0x6000308")]
	public override void Collect()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x4F8A40", Offset = "0x4F7240", Length = "0x2A6")]
	private void RequestProductInfosFromPeroServer()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x4F8510", Offset = "0x4F6D10", Length = "0xEE")]
	private void ExcuteWithServerResponse(JObject jobj)
	{
	}

	[Address(RVA = "0x4F8600", Offset = "0x4F6E00", Length = "0x43B")]
	[Token(Token = "0x600030B")]
	private void GetProductDataFromPeroServer(JObject jobj)
	{
	}

	[Address(RVA = "0x4F8D00", Offset = "0x4F7500", Length = "0xB")]
	[Token(Token = "0x600030C")]
	public PeroServerDiscountCollector()
	{
	}
}
