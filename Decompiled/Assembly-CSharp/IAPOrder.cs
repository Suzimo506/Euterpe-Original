using System;
using System.Collections.Generic;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000065")]
public struct IAPOrder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E8")]
	public string productIdentifier;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002E9")]
	public decimal priceCny;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EA")]
	public string peroOrderIdentifier;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x20")]
	public string peroOrderUUID;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002EC")]
	public string playerUUID;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002ED")]
	public int productType;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002EE")]
	public List<string> bundleList;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002EF")]
	public string selectDiscount;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F0")]
	public int discount;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x5C58A0", Offset = "0x5C40A0", Length = "0x4A0")]
	public IAPOrder(IAPPipelineContext context)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x5C5590", Offset = "0x5C3D90", Length = "0x309")]
	public override string ToString()
	{
		return null;
	}
}
