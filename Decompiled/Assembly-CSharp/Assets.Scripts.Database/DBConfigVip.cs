using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000802")]
public class DBConfigVip : BaseDBConfigLocalObject<DBConfigLocalVip, LocalCollectionBundle>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40029BA")]
	private List<ProductVip> m_Items;

	[Token(Token = "0x17000740")]
	private List<ProductVip> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x600488B")]
		get
		{
			return null;
		}
		[Token(Token = "0x600488C")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x600488D")]
	[Address(RVA = "0x701220", Offset = "0x6FFA20", Length = "0x9C")]
	public DBConfigVip()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x600488E")]
	[Address(RVA = "0x7004D0", Offset = "0x6FECD0", Length = "0x189")]
	public void GetAllVip(List<ProductVip> datas)
	{
	}

	[Token(Token = "0x600488F")]
	[Address(RVA = "0x700660", Offset = "0x6FEE60", Length = "0x233")]
	public static bool IsCurrentVip(DateTime utc, string productId)
	{
		return default(bool);
	}

	[Token(Token = "0x6004890")]
	[Address(RVA = "0x700D90", Offset = "0x6FF590", Length = "0x1AC")]
	public bool TryGetPurchasableVipProductId(DateTime peroServerTimeUtc, out ProductVip productVip)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductVip, @null>(ref productVip) = null;
		return default(bool);
	}

	[Address(RVA = "0x700930", Offset = "0x6FF130", Length = "0x45D")]
	[Token(Token = "0x6004891")]
	public bool TryGetDisplayableVipProductId(DateTime utcTime, out ProductVip productVip)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductVip, @null>(ref productVip) = null;
		return default(bool);
	}

	[Address(RVA = "0x700F40", Offset = "0x6FF740", Length = "0x2D8")]
	[Token(Token = "0x6004892")]
	public bool TryGetVipProductId(string productId, out ProductVip productVip)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductVip, @null>(ref productVip) = null;
		return default(bool);
	}

	[Token(Token = "0x6004893")]
	[Address(RVA = "0x7008A0", Offset = "0x6FF0A0", Length = "0x8C")]
	private static bool IsVipValid(ProductVip productVip)
	{
		return default(bool);
	}

	[Token(Token = "0x6004894")]
	[Address(RVA = "0x700440", Offset = "0x6FEC40", Length = "0x83")]
	public override void Deserialize(string str)
	{
	}
}
