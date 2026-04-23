using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C5")]
public class CollectionBundleSelectStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F50")]
	[Address(RVA = "0xFD4320", Offset = "0xFD2B20", Length = "0x672")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0xFD4200", Offset = "0xFD2A00", Length = "0x11E")]
	[Token(Token = "0x6003F51")]
	private static CollectionBundlePriceGradient FindClosestPrice(List<CollectionBundlePriceGradient> priceGradients, decimal priceLeft)
	{
		return default(CollectionBundlePriceGradient);
	}

	[Token(Token = "0x6003F52")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public CollectionBundleSelectStage()
	{
	}
}
