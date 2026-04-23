using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006BE")]
public abstract class IAPManager
{
	[Token(Token = "0x400245D")]
	protected static IAPManager s_Instance;

	[Token(Token = "0x400245E")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<string, Product> m_Products;

	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<string, DateTime> purchaseHistory;

	[Token(Token = "0x4002460")]
	[FieldOffset(Offset = "0x20")]
	protected uint m_Arg;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002462")]
	protected IAPPipeline m_IAPPipeline;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002463")]
	protected IAPPipelinePostExcute m_IAPPipelinePostExcute;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002464")]
	protected bool isProductDictInited;

	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4002466")]
	public (bool, bool) restoreAndPurchaseState;

	[Token(Token = "0x4002467")]
	[FieldOffset(Offset = "0x48")]
	public Action<string[]> onReceiptCompleted;

	[Token(Token = "0x4002468")]
	[FieldOffset(Offset = "0x50")]
	public Action<ProductInfo[]> onReceiptCallBack;

	[Token(Token = "0x4002469")]
	[FieldOffset(Offset = "0x58")]
	public Action<string> onReceiptDataCallBack;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400246A")]
	protected Action<bool> OnGetProductsCompleted;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400246B")]
	protected Action<TransactionResult> OnTransactionCompleted;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400246C")]
	protected Action<bool, TransactionResult> OnRestoreCompleted;

	[Token(Token = "0x400246D")]
	[FieldOffset(Offset = "0x78")]
	protected Action<bool, TransactionResult> OnRestoreCompletedWithNoNotify;

	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x80")]
	protected IStoreListener m_StoreListener;

	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x88")]
	protected bool m_Initing;

	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x89")]
	protected bool m_IsRestoring;

	[FieldOffset(Offset = "0x8A")]
	[Token(Token = "0x4002471")]
	protected bool m_IsRestoringWithNoNotify;

	[Token(Token = "0x170005D3")]
	public static IAPManager instance
	{
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0xFD62D0", Offset = "0xFD4AD0", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D4")]
	public ClientDiscountManager clientDiscountManager
	{
		[CompilerGenerated]
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		protected set
		{
		}
	}

	[Token(Token = "0x170005D5")]
	public bool isCheckingRestore
	{
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003F18")]
		[CompilerGenerated]
		[Address(RVA = "0x5F9A80", Offset = "0x5F8280", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x170005D6")]
	public bool isInited
	{
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0xFD6310", Offset = "0xFD4B10", Length = "0x4B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005D7")]
	public bool hasHandler
	{
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0xFD62C0", Offset = "0xFD4AC0", Length = "0xC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005D8")]
	public bool isPurchaseAvailable
	{
		[Address(RVA = "0xFD6360", Offset = "0xFD4B60", Length = "0x4B")]
		[Token(Token = "0x6003F29")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000063")]
	public event Action<bool, TransactionResult> onRestoreCompleted
	{
		[Address(RVA = "0xFD61C0", Offset = "0xFD49C0", Length = "0x76")]
		[Token(Token = "0x6003F1D")]
		add
		{
		}
		[Address(RVA = "0xFD6510", Offset = "0xFD4D10", Length = "0x76")]
		[Token(Token = "0x6003F1E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000064")]
	public event Action<bool, TransactionResult> onRestoreCompletedWithNoUINotify
	{
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0xFD6140", Offset = "0xFD4940", Length = "0x76")]
		add
		{
		}
		[Address(RVA = "0xFD6490", Offset = "0xFD4C90", Length = "0x76")]
		[Token(Token = "0x6003F20")]
		remove
		{
		}
	}

	[Token(Token = "0x14000065")]
	public event Action<TransactionResult> onTransactionCompleted
	{
		[Address(RVA = "0xFD6240", Offset = "0xFD4A40", Length = "0x76")]
		[Token(Token = "0x6003F21")]
		add
		{
		}
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0xFD6590", Offset = "0xFD4D90", Length = "0x76")]
		remove
		{
		}
	}

	[Token(Token = "0x14000066")]
	public event Action<bool> onGetProductsCompleted
	{
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0xFD6060", Offset = "0xFD4860", Length = "0x76")]
		add
		{
		}
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0xFD63B0", Offset = "0xFD4BB0", Length = "0x76")]
		remove
		{
		}
	}

	[Token(Token = "0x14000067")]
	public event Action<List<ProductInfo>> onProductRefresh
	{
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0xFD60E0", Offset = "0xFD48E0", Length = "0x5A")]
		add
		{
		}
		[Address(RVA = "0xFD6430", Offset = "0xFD4C30", Length = "0x5A")]
		[Token(Token = "0x6003F26")]
		remove
		{
		}
	}

	[Address(RVA = "0x9163C0", Offset = "0x914BC0", Length = "0xAC")]
	[Token(Token = "0x6003F14")]
	public static T GetInstance<T>() where T : IAPManager
	{
		return null;
	}

	[Token(Token = "0x6003F19")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public bool IsCurStateOnRestoreOrPurchase()
	{
		return default(bool);
	}

	[Address(RVA = "0x5F9A80", Offset = "0x5F8280", Length = "0x4")]
	[Token(Token = "0x6003F1A")]
	public void SetIsCheckRestore(bool bValue)
	{
	}

	[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
	[Token(Token = "0x6003F1B")]
	public void SetArg(uint arg)
	{
	}

	[Token(Token = "0x6003F1C")]
	[Address(RVA = "0xFD5990", Offset = "0xFD4190", Length = "0xF8")]
	private void TestCallBack(TransactionResult tr)
	{
	}

	[Token(Token = "0x6003F2A")]
	[Address(RVA = "0x5C14C0", Offset = "0x5BFCC0", Length = "0xC")]
	public void SetStoreHandler(IStoreListener store)
	{
	}

	[Token(Token = "0x6003F2B")]
	[Address(RVA = "0xFD4EB0", Offset = "0xFD36B0", Length = "0x179")]
	public virtual void InitIAP(string[] productIds)
	{
	}

	[Address(RVA = "0xFD57B0", Offset = "0xFD3FB0", Length = "0x77")]
	[Token(Token = "0x6003F2C")]
	public virtual void RefreshStoreIAP()
	{
	}

	[Address(RVA = "0xFD5290", Offset = "0xFD3A90", Length = "0x32B")]
	[Token(Token = "0x6003F2D")]
	protected void InvokeTransactionCompleted(string msg, string productId, TransactionState state)
	{
	}

	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0xFD4C30", Offset = "0xFD3430", Length = "0xBE")]
	public virtual void BeforePurchase(Action action, string productId = null)
	{
	}

	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0xFD5750", Offset = "0xFD3F50", Length = "0x5A")]
	public virtual void Purchase(string productId)
	{
	}

	[Address(RVA = "0xFD55C0", Offset = "0xFD3DC0", Length = "0x95")]
	[Token(Token = "0x6003F30")]
	private void PostInvoke(IAPPipelineContext context)
	{
	}

	[Token(Token = "0x6003F31")]
	[Address(RVA = "0xFD5660", Offset = "0xFD3E60", Length = "0xE7")]
	public virtual void Purchase(IAPOrder order)
	{
	}

	[Address(RVA = "0xFD5830", Offset = "0xFD4030", Length = "0x152")]
	[Token(Token = "0x6003F32")]
	public void RestoreAll(bool notifyUI = true)
	{
	}

	[Token(Token = "0x6003F33")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void ClearPurchase();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003F34")]
	public abstract bool TryGetProduct(string productId, out Product product);

	[Token(Token = "0x6003F35")]
	[Address(RVA = "0xFD5A90", Offset = "0xFD4290", Length = "0x8F")]
	public bool TryGetProductBuyTime(string productId, out DateTime buyTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<DateTime, @null>(ref buyTime) = null;
		return default(bool);
	}

	[Token(Token = "0x6003F36")]
	[Address(RVA = "0xFD4CF0", Offset = "0xFD34F0", Length = "0x1B1")]
	public string[] GetAllPayProductIdByProductId(string productId)
	{
		return null;
	}

	[Token(Token = "0x6003F37")]
	[Address(RVA = "0xFD5030", Offset = "0xFD3830", Length = "0x25E")]
	protected void InitProductDic()
	{
	}

	[Token(Token = "0x6003F38")]
	[Address(RVA = "0xFD5B20", Offset = "0xFD4320", Length = "0x53C")]
	protected IAPManager()
	{
	}
}
