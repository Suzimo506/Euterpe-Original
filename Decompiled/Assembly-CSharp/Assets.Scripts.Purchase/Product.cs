using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D8")]
public class Product : ICloneable
{
	[Token(Token = "0x400249A")]
	[FieldOffset(Offset = "0x58")]
	private int m_Discount;

	[Token(Token = "0x170005DF")]
	public bool isAvailable
	{
		[Address(RVA = "0xFE2D40", Offset = "0xFE1540", Length = "0x18F")]
		[Token(Token = "0x6003FE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005E0")]
	public string id
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003FE9")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170005E1")]
	public string title
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170005E2")]
	public decimal oriPrice
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x7322C0", Offset = "0x730AC0", Length = "0xB")]
		get
		{
			return default(decimal);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0xFE2F00", Offset = "0xFE1700", Length = "0x8")]
		private set
		{
		}
	}

	[Token(Token = "0x170005E3")]
	public decimal price
	{
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x6C05E0", Offset = "0x6BEDE0", Length = "0xB")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Address(RVA = "0x6C06A0", Offset = "0x6BEEA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6003FF0")]
		private set
		{
		}
	}

	[Token(Token = "0x170005E4")]
	public string currency
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x170005E5")]
	public string currencySymbol
	{
		[CompilerGenerated]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		[Token(Token = "0x6003FF3")]
		get
		{
			return null;
		}
		[Address(RVA = "0x637D40", Offset = "0x636540", Length = "0xC")]
		[Token(Token = "0x6003FF4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005E6")]
	public string purchaseTime
	{
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003FF5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
		[Token(Token = "0x6003FF6")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005E7")]
	public int discount
	{
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		[Token(Token = "0x6003FF7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005E8")]
	public int showDiscount
	{
		[Address(RVA = "0xFE2EE0", Offset = "0xFE16E0", Length = "0x9")]
		[Token(Token = "0x6003FF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005E9")]
	public DateTime discountStartTime
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0xE71340", Offset = "0xE6FB40", Length = "0x5")]
		private set
		{
		}
	}

	[Token(Token = "0x170005EA")]
	public DateTime discountEndTime
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		[Address(RVA = "0xFE2EF0", Offset = "0xFE16F0", Length = "0x5")]
		[Token(Token = "0x6003FFC")]
		private set
		{
		}
	}

	[Obsolete]
	[Token(Token = "0x170005EB")]
	public bool isUnlockAll
	{
		[Token(Token = "0x6004001")]
		[Address(RVA = "0xFE2ED0", Offset = "0xFE16D0", Length = "0xB")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005EC")]
	public string localizedOriPrice
	{
		[CompilerGenerated]
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x170005ED")]
	public string localizedPrice
	{
		[CompilerGenerated]
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004008")]
		[CompilerGenerated]
		[Address(RVA = "0x5C14B0", Offset = "0x5BFCB0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0xFE2CA0", Offset = "0xFE14A0", Length = "0x9B")]
	public Product(string productId)
	{
	}

	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0xFE2500", Offset = "0xFE0D00", Length = "0x53")]
	public void SetBaseInfo(string productTitle, decimal productOriPrice, decimal productPrice, string productCurrencySymbol)
	{
	}

	[Address(RVA = "0xFE2560", Offset = "0xFE0D60", Length = "0xC")]
	[Token(Token = "0x6003FFF")]
	public void SetDiscount(int discount, DateTime startTime, DateTime endTime)
	{
	}

	[Token(Token = "0x6004000")]
	[Address(RVA = "0xFE2570", Offset = "0xFE0D70", Length = "0x13")]
	public void SetShowDiscount(int showDiscount, DateTime startTime, DateTime endTime)
	{
	}

	[Address(RVA = "0xFE2350", Offset = "0xFE0B50", Length = "0x42")]
	[Token(Token = "0x6004002")]
	public int GetPriceDiscount(DateTime utcTime)
	{
		return default(int);
	}

	[Address(RVA = "0xFE23F0", Offset = "0xFE0BF0", Length = "0x45")]
	[Token(Token = "0x6004003")]
	public int GetShowPriceDiscount(DateTime utcTime)
	{
		return default(int);
	}

	[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
	[Token(Token = "0x6004004")]
	public int GetShowPriceDiscount()
	{
		return default(int);
	}

	[Token(Token = "0x6004005")]
	[Address(RVA = "0xFE23A0", Offset = "0xFE0BA0", Length = "0x4C")]
	public decimal GetPrice(DateTime utcTime)
	{
		return default(decimal);
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0xFE2440", Offset = "0xFE0C40", Length = "0xBF")]
	public bool IsOnDiscount(DateTime utcTime)
	{
		return default(bool);
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0xFE2BB0", Offset = "0xFE13B0", Length = "0xED")]
	public Product(Product clone)
	{
	}

	[Address(RVA = "0xFE2230", Offset = "0xFE0A30", Length = "0x117")]
	[Token(Token = "0x600400C")]
	public object Clone()
	{
		return null;
	}

	[Address(RVA = "0xFE2590", Offset = "0xFE0D90", Length = "0x612")]
	[Token(Token = "0x600400D")]
	public override string ToString()
	{
		return null;
	}
}
