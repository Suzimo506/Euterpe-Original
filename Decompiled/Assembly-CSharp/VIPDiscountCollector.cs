using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;

[Token(Token = "0x2000064")]
public class VIPDiscountCollector : IDiscountCollector
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E6")]
	private MDIAPManager mdiap;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<string> m_InEffectiveMusicPackage;

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x4EB530", Offset = "0x4E9D30", Length = "0x439")]
	public override void Collect()
	{
	}

	[Address(RVA = "0x4EB2B0", Offset = "0x4E9AB0", Length = "0x27E")]
	[Token(Token = "0x600030F")]
	private void AddVipDiscount(string activedVipProductId, DateTime startTimeUtc, DateTime vipExpirationTimeUtc)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x4EB970", Offset = "0x4EA170", Length = "0xB3")]
	private string GetVipDiscount(string productId, out int outDiscount)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref outDiscount) = null;
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x4EBA30", Offset = "0x4EA230", Length = "0xB5")]
	public VIPDiscountCollector()
	{
	}
}
