using System;
using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F0")]
public class ThinkingDataGooglePurchase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001AB7")]
	private DateTime m_MinTime;

	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x18")]
	private DateTime m_MaxTime;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001AB9")]
	private int m_PriceCount;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001ABA")]
	private List<ProductInfo> m_RestoreList;

	[Token(Token = "0x60036CF")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Initialization()
	{
	}

	[Token(Token = "0x60036D0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ThinkingDataGooglePurchase()
	{
	}
}
