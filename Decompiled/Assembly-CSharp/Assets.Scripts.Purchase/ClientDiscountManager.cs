using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using MEC;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006B6")]
public class ClientDiscountManager
{
	[Token(Token = "0x4002422")]
	[FieldOffset(Offset = "0x10")]
	private List<IDiscountCollector> m_Collectors;

	[Token(Token = "0x4002423")]
	private static List<DiscountInfo> s_DiscountInfos;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002424")]
	private CoroutineHandle m_CollectCoroutine;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002426")]
	private readonly float timeout;

	[Token(Token = "0x4002428")]
	[FieldOffset(Offset = "0x30")]
	private List<string> errorMessages;

	[Token(Token = "0x170005D1")]
	public bool isCollectedSuccess
	{
		[Address(RVA = "0x45EE60", Offset = "0x45D660", Length = "0x5")]
		[Token(Token = "0x6003EE6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x45EF00", Offset = "0x45D700", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000062")]
	public event Action<bool> OnCollected
	{
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0xFD3220", Offset = "0xFD1A20", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0xFD32C0", Offset = "0xFD1AC0", Length = "0x9E")]
		[Token(Token = "0x6003EE5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0xFD2FF0", Offset = "0xFD17F0", Length = "0x22C")]
	public ClientDiscountManager()
	{
	}

	[Token(Token = "0x6003EE9")]
	[Address(RVA = "0xFD1600", Offset = "0xFCFE00", Length = "0x1C4")]
	~ClientDiscountManager()
	{
	}

	[Address(RVA = "0xFD2760", Offset = "0xFD0F60", Length = "0x15D")]
	[Token(Token = "0x6003EEA")]
	private void RegisterEvent()
	{
	}

	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0xFD15B0", Offset = "0xFCFDB0", Length = "0x4F")]
	public void Collect()
	{
	}

	[Address(RVA = "0xFD14A0", Offset = "0xFCFCA0", Length = "0x65")]
	[Token(Token = "0x6003EEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4AC60", Offset = "0x4A060")]
	private IEnumerator<float> AsyncCollect()
	{
		return null;
	}

	[Token(Token = "0x6003EED")]
	[Address(RVA = "0xFD0EE0", Offset = "0xFCF6E0", Length = "0x58")]
	public void AddCollector(IDiscountCollector collector)
	{
	}

	[Address(RVA = "0xFD1510", Offset = "0xFCFD10", Length = "0x44")]
	[Token(Token = "0x6003EEE")]
	public void ClearCollector()
	{
	}

	[Address(RVA = "0xFD2D90", Offset = "0xFD1590", Length = "0x25F")]
	[Token(Token = "0x6003EEF")]
	public bool TryOverridePayProductId(string productId, out string newPayProductId)
	{
		newPayProductId = null;
		return default(bool);
	}

	[Address(RVA = "0xFD1C00", Offset = "0xFD0400", Length = "0x3C6")]
	[Token(Token = "0x6003EF0")]
	public void OverrideTapTapProduct(Product product)
	{
	}

	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0xFD1FD0", Offset = "0xFD07D0", Length = "0x782")]
	public void RefreshProductsByDiscount(Product[] products, ProductInfo[] serverProductInfos)
	{
	}

	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void RefreshProductsByDiscountNEW(Product[] iapProducts, ProductInfo ServerProductInfos)
	{
	}

	[Address(RVA = "0xFD17D0", Offset = "0xFCFFD0", Length = "0x36")]
	[Token(Token = "0x6003EF3")]
	public int GetDiscount(string productId)
	{
		return default(int);
	}

	[Address(RVA = "0xFD1810", Offset = "0xFD0010", Length = "0x219")]
	[Token(Token = "0x6003EF4")]
	public bool GetPayProductIdFromPeroServer(List<ProductInfo> serverProductInfos, string productId, out string payProductId)
	{
		payProductId = null;
		return default(bool);
	}

	[Address(RVA = "0xFD28C0", Offset = "0xFD10C0", Length = "0x4CC")]
	[Token(Token = "0x6003EF5")]
	public bool TryGetDiscount(string productId, out DiscountInfo outDiscountInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<DiscountInfo, @null>(ref outDiscountInfo) = null;
		return default(bool);
	}

	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0xFD0F40", Offset = "0xFCF740", Length = "0x2B5")]
	internal static void AddDiscountInfo(DiscountInfo discountInfo)
	{
	}

	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0xFD1560", Offset = "0xFCFD60", Length = "0x4A")]
	public static void ClearDiscountInfos()
	{
	}

	[Obsolete]
	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0xFD1200", Offset = "0xFCFA00", Length = "0x296")]
	public static string ApplyDiscount(string priceStr, int discount)
	{
		return null;
	}

	[Address(RVA = "0xFD1A30", Offset = "0xFD0230", Length = "0x1C4")]
	[Token(Token = "0x6003EF9")]
	private bool GetProductDiscountByPayProductId(string payProductId, out int discount)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref discount) = null;
		return default(bool);
	}
}
