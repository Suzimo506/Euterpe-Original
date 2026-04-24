using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AF")]
public struct CollectionBundlePriceGradient
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400289F")]
	public int priceLeft;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40028A0")]
	public int priceCny;

	[FieldOffset(Offset = "0x8")]
	[JsonProperty]
	[Token(Token = "0x40028A1")]
	public int pay_price_id;
}
