using System;
using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F1")]
public class ThinkingDataIOSPurchase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001ABB")]
	private DateTime m_MinTime;

	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0x18")]
	private DateTime m_MaxTime;

	[Token(Token = "0x4001ABD")]
	[FieldOffset(Offset = "0x20")]
	private int m_PriceCount;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001ABE")]
	private List<ProductInfo> m_RestoreList;

	[Address(RVA = "0x87A100", Offset = "0x878900", Length = "0xEF")]
	[Token(Token = "0x60036D1")]
	public void CheckOrderList()
	{
	}

	[Token(Token = "0x60036D2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void IosOrderList(ProductInfo[] productInfos)
	{
	}

	[Token(Token = "0x60036D3")]
	[Address(RVA = "0x87A1F0", Offset = "0x8789F0", Length = "0x509")]
	private void GetProductInfo(ProductInfo productInfo)
	{
	}

	[Token(Token = "0x60036D4")]
	[Address(RVA = "0x87A7E0", Offset = "0x878FE0", Length = "0x395")]
	private void SetUserPurchaseTime()
	{
	}

	[Token(Token = "0x60036D5")]
	[Address(RVA = "0x87A700", Offset = "0x878F00", Length = "0xD4")]
	private string IsOldJustAsPlanned()
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60036D6")]
	public ThinkingDataIOSPurchase()
	{
	}
}
