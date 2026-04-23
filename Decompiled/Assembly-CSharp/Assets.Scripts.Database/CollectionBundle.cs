using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AE")]
public class CollectionBundle : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002899")]
	public string uid;

	[Token(Token = "0x400289A")]
	[FieldOffset(Offset = "0x28")]
	[JsonProperty]
	public string prev_product_uid;

	[Token(Token = "0x400289B")]
	[JsonProperty]
	[FieldOffset(Offset = "0x30")]
	public List<string> packageInGroup;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400289C")]
	[JsonProperty]
	public List<CollectionBundlePriceGradient> priceGradients;

	[JsonProperty]
	[Token(Token = "0x400289D")]
	[FieldOffset(Offset = "0x40")]
	public bool isPurchaseBundle;

	[JsonProperty]
	[Token(Token = "0x400289E")]
	[FieldOffset(Offset = "0x41")]
	public bool isShowInOverview;

	[Token(Token = "0x6004724")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public CollectionBundle()
	{
	}
}
