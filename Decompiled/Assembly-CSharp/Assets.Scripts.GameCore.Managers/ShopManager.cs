using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000749")]
public class ShopManager : Singleton<ShopManager>
{
	[Token(Token = "0x2000CC2")]
	public enum ModuleLayout
	{
		[Token(Token = "0x4003DEB")]
		None,
		[Token(Token = "0x4003DEC")]
		One,
		[Token(Token = "0x4003DED")]
		VSplit,
		[Token(Token = "0x4003DEE")]
		VTrisection,
		[Token(Token = "0x4003DEF")]
		AntitheticalCouplet,
		[Token(Token = "0x4003DF0")]
		Count
	}

	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x10")]
	public List<ShopModule> shopGoods;

	[Token(Token = "0x1700066A")]
	public int curGoodsCount
	{
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x6DF6A0", Offset = "0x6DDEA0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700066B")]
	public bool shopEnable
	{
		[CompilerGenerated]
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x600443C")]
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700066C")]
	public bool goodsInited
	{
		[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600443D")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x575860", Offset = "0x574060", Length = "0x4")]
		[Token(Token = "0x600443E")]
		private set
		{
		}
	}

	[Address(RVA = "0x6DEFE0", Offset = "0x6DD7E0", Length = "0xC7")]
	[Token(Token = "0x600443F")]
	public void GetShopData()
	{
	}

	[Address(RVA = "0x6DF0B0", Offset = "0x6DD8B0", Length = "0x197")]
	[Token(Token = "0x6004440")]
	public void GetShopEnable(Action<bool> callback)
	{
	}

	[Token(Token = "0x6004441")]
	[Address(RVA = "0x6DF250", Offset = "0x6DDA50", Length = "0xAD")]
	public void GetShopGoodData()
	{
	}

	[Address(RVA = "0x6DF300", Offset = "0x6DDB00", Length = "0x17D")]
	[Token(Token = "0x6004442")]
	public bool HasShopGoods(string language)
	{
		return default(bool);
	}

	[Token(Token = "0x6004443")]
	[Address(RVA = "0x6DF660", Offset = "0x6DDE60", Length = "0x38")]
	public ShopManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
