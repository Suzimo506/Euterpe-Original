using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F4")]
public class ThinkingDataTapTapPurchase
{
	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x10")]
	private DateTime m_MinTime;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001AD3")]
	private DateTime m_MaxTime;

	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x20")]
	private int m_PriceCount;

	[Token(Token = "0x4001AD5")]
	[FieldOffset(Offset = "0x28")]
	private List<ProductInfo> m_RestoreList;

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x742A0", Offset = "0x736A0")]
	[Token(Token = "0x60036FC")]
	[Address(RVA = "0x506F40", Offset = "0x505740", Length = "0x65")]
	public IEnumerator CheckFirstOrder()
	{
		return null;
	}

	[Address(RVA = "0x506FB0", Offset = "0x5057B0", Length = "0x367")]
	[Token(Token = "0x60036FD")]
	private static void CheckPurchaseData(JObject jObj)
	{
	}

	[Address(RVA = "0x507320", Offset = "0x505B20", Length = "0x395")]
	[Token(Token = "0x60036FE")]
	private void SetUserPurchaseTime()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60036FF")]
	public ThinkingDataTapTapPurchase()
	{
	}
}
