using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D4")]
public static class IAPUtil
{
	[Address(RVA = "0xFD8AF0", Offset = "0xFD72F0", Length = "0x275")]
	[Token(Token = "0x6003F82")]
	public static void RequestPeroServerForProductData(Product[] productRef, Action successCallback, Action failedCallback)
	{
	}

	[Address(RVA = "0xFD86D0", Offset = "0xFD6ED0", Length = "0x41F")]
	[Token(Token = "0x6003F83")]
	private static void ExcutePeroServerProduct(JObject jObj, Product[] productRef)
	{
	}
}
