using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.InAppPurchase;

[CreateAssetMenu]
[Token(Token = "0x20006AD")]
public class LocalIAPProductsScriptableObject : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400240E")]
	public string[] products;

	[Token(Token = "0x400240F")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<string> invalidProducts;

	[Token(Token = "0x6003EB6")]
	[Address(RVA = "0x92DEF0", Offset = "0x92C6F0", Length = "0x143")]
	public void ClearInvalidProduct()
	{
	}

	[Address(RVA = "0x92E040", Offset = "0x92C840", Length = "0x9F")]
	[Token(Token = "0x6003EB7")]
	public LocalIAPProductsScriptableObject()
	{
	}
}
