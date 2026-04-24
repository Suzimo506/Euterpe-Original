using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006DC")]
internal class TapTapStorePurchase : IStoreListener
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024B5")]
	private bool m_IsFirstPurchase;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40024BC")]
	private bool m_IsInited;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40024BD")]
	private Dictionary<string, Product> productsFromServer;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40024BE")]
	private Product[] m_Products;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40024BF")]
	private string[] m_ProductIds;

	[Token(Token = "0x40024C1")]
	[FieldOffset(Offset = "0x70")]
	private Action beforePurchaseCallBack;

	[Token(Token = "0x170005EE")]
	public bool Inited
	{
		[Address(RVA = "0x5B0970", Offset = "0x5AF170", Length = "0x5")]
		[Token(Token = "0x600400F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005EF")]
	public bool IsFirstPurchase
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6004010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005F0")]
	public Product[] products
	{
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000076")]
	public event Action<bool> onInitSucceed
	{
		[Token(Token = "0x6004012")]
		[CompilerGenerated]
		[Address(RVA = "0x65FCD0", Offset = "0x65E4D0", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x660130", Offset = "0x65E930", Length = "0x9E")]
		[Token(Token = "0x6004013")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000077")]
	public event Action<TransactionResult> onTransactionCompleted
	{
		[Address(RVA = "0x660090", Offset = "0x65E890", Length = "0x9E")]
		[Token(Token = "0x6004014")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x6604F0", Offset = "0x65ECF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6004015")]
		remove
		{
		}
	}

	[Token(Token = "0x14000078")]
	public event Action<string[]> onReceiptCompleted
	{
		[Address(RVA = "0x65FF50", Offset = "0x65E750", Length = "0x9E")]
		[Token(Token = "0x6004016")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004017")]
		[CompilerGenerated]
		[Address(RVA = "0x6603B0", Offset = "0x65EBB0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000079")]
	public event Action<ProductInfo[]> onReceipToProductInfos
	{
		[CompilerGenerated]
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x65FEB0", Offset = "0x65E6B0", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6004019")]
		[CompilerGenerated]
		[Address(RVA = "0x660310", Offset = "0x65EB10", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007A")]
	public event Action<string> onReceipDataCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x65FE10", Offset = "0x65E610", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x660270", Offset = "0x65EA70", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007B")]
	public event Action<List<ProductInfo>> onProductRefresh
	{
		[CompilerGenerated]
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x65FD70", Offset = "0x65E570", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x6601D0", Offset = "0x65E9D0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007C")]
	public event Action<bool, TransactionResult> onRestoreCompleted
	{
		[Address(RVA = "0x65FFF0", Offset = "0x65E7F0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600401E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x660450", Offset = "0x65EC50", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6004020")]
	[Address(RVA = "0x65F2D0", Offset = "0x65DAD0", Length = "0x2B2")]
	public void InitStoreIAP(string[] productIds)
	{
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0x65F6C0", Offset = "0x65DEC0", Length = "0xB2")]
	public void RefreshStoreIAP()
	{
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x65F780", Offset = "0x65DF80", Length = "0x16E")]
	private void ResetProducts()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004023")]
	private void InitProducts()
	{
	}

	[Address(RVA = "0x65EA60", Offset = "0x65D260", Length = "0x55E")]
	[Token(Token = "0x6004024")]
	private void ExcutePeroServerProduct(JObject jObj)
	{
	}

	[Address(RVA = "0x65EFC0", Offset = "0x65D7C0", Length = "0x308")]
	[Token(Token = "0x6004025")]
	private void GetInfo(JToken token)
	{
	}

	[Token(Token = "0x6004026")]
	[Address(RVA = "0x65F660", Offset = "0x65DE60", Length = "0x5B")]
	private void RefreshProductAfterRestore(bool arg1, TransactionResult arg2)
	{
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0x65F940", Offset = "0x65E140", Length = "0x1F")]
	private void TapTapBeforePurchaseCheckCallBack(List<ProductInfo> obj)
	{
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0x65E850", Offset = "0x65D050", Length = "0xE9")]
	public void BeforePurchase(Action action, string productId = null)
	{
	}

	[Token(Token = "0x6004029")]
	[Obsolete]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Purchase(string productId)
	{
	}

	[Address(RVA = "0x65F590", Offset = "0x65DD90", Length = "0xC7")]
	[Token(Token = "0x600402A")]
	public void Purchase(IAPOrder iapOrder)
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C3F0", Offset = "0x5B7F0")]
	[Token(Token = "0x600402B")]
	[Address(RVA = "0x65E940", Offset = "0x65D140", Length = "0x4A")]
	private IEnumerator<float> E_Private_Purchase(IAPOrder order, string extra)
	{
		return null;
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0x65E990", Offset = "0x65D190", Length = "0xC4")]
	private void EndPurchase(TransactionResult tr)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600402D")]
	private void PeroUidCheckFail(string productId)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600402E")]
	private void TapTapRefreshPeroUid(string productId, Action<string> successCallBack)
	{
	}

	[Address(RVA = "0x65F8F0", Offset = "0x65E0F0", Length = "0x49")]
	[Token(Token = "0x600402F")]
	public void Restore(string productId)
	{
	}

	[Token(Token = "0x6004030")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void RestoreAll()
	{
	}

	[Token(Token = "0x6004031")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public bool IsStoreAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6004032")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SecondaryVerify(TransactionResult transactionResult, Action<bool> callback)
	{
	}

	[Address(RVA = "0x65F9B0", Offset = "0x65E1B0", Length = "0x314")]
	[Token(Token = "0x6004033")]
	public TapTapStorePurchase()
	{
	}
}
