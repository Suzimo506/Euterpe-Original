using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Serializable]
[Token(Token = "0x20006BB")]
public struct IAPPipelineContext
{
	[Token(Token = "0x2000C58")]
	public enum ProductType
	{
		[Token(Token = "0x4003CD3")]
		music_package,
		[Token(Token = "0x4003CD4")]
		collection_bundle
	}

	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x0")]
	public bool vaild;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4002446")]
	public string errorMsg;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002447")]
	public uint errorCode;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002448")]
	public TransactionState state;

	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x18")]
	public readonly string originalProductId;

	[Token(Token = "0x400244A")]
	[FieldOffset(Offset = "0x20")]
	public string peroOrderIdentifier;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400244B")]
	public string iOSAdultVerifyOrder;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400244C")]
	public string purchasedReceipt;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400244D")]
	public string peroOrderUUID;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400244E")]
	public string payProductId;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400244F")]
	public DateTime invokeTimeUtc;

	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0x50")]
	public int discount;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002451")]
	public string discountSource;

	[Token(Token = "0x4002452")]
	[FieldOffset(Offset = "0x60")]
	public decimal priceCny;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002453")]
	public decimal price;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002454")]
	public string currency;

	[Token(Token = "0x4002455")]
	[FieldOffset(Offset = "0x88")]
	public ProductType productType;

	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0x90")]
	public List<string> PackageInCollectionBundle;

	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0x98")]
	public List<string> packagesPurchase;

	[Token(Token = "0x4002458")]
	[FieldOffset(Offset = "0xA0")]
	public string playerUUID;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002459")]
	public bool isFirstPurchase;

	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x400245A")]
	public bool isUseVipDiscount;

	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0xFD6850", Offset = "0xFD5050", Length = "0x1BA")]
	public IAPPipelineContext(string originalProductId)
	{
	}
}
