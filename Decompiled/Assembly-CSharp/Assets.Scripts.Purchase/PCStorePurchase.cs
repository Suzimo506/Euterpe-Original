using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D7")]
public class PCStorePurchase : IStoreListener
{
	[Token(Token = "0x170005DC")]
	public bool Inited
	{
		[Address(RVA = "0xFE0270", Offset = "0xFDEA70", Length = "0x47")]
		[Token(Token = "0x6003FCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005DD")]
	public bool IsFirstPurchase
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005DE")]
	public Product[] products
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003FCE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400006F")]
	public event Action<bool> onInitSucceed
	{
		[Address(RVA = "0xFDFE10", Offset = "0xFDE610", Length = "0x9E")]
		[Token(Token = "0x6003FD9")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0xFE02C0", Offset = "0xFDEAC0", Length = "0x9E")]
		[Token(Token = "0x6003FDA")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000070")]
	public event Action<TransactionResult> onTransactionCompleted
	{
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0xFE01D0", Offset = "0xFDE9D0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0xFE0680", Offset = "0xFDEE80", Length = "0x9E")]
		[Token(Token = "0x6003FDC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000071")]
	public event Action<bool, TransactionResult> onRestoreCompleted
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0xFE0130", Offset = "0xFDE930", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0xFE05E0", Offset = "0xFDEDE0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000072")]
	public event Action<string[]> onReceiptCompleted
	{
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0xFE0090", Offset = "0xFDE890", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0xFE0540", Offset = "0xFDED40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003FE0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000073")]
	public event Action<ProductInfo[]> onReceipToProductInfos
	{
		[CompilerGenerated]
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0xFDFFF0", Offset = "0xFDE7F0", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0xFE04A0", Offset = "0xFDECA0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000074")]
	public event Action<string> onReceipDataCallback
	{
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0xFDFF50", Offset = "0xFDE750", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0xFE0400", Offset = "0xFDEC00", Length = "0x9E")]
		[Token(Token = "0x6003FE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000075")]
	public event Action<List<ProductInfo>> onProductRefresh
	{
		[Address(RVA = "0xFDFEB0", Offset = "0xFDE6B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003FE5")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0xFE0360", Offset = "0xFDEB60", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6003FCF")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void InitStoreIAP(string[] productIds)
	{
	}

	[Token(Token = "0x6003FD0")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void InitStoreIAP()
	{
	}

	[Address(RVA = "0xFDFD60", Offset = "0xFDE560", Length = "0x51")]
	[Token(Token = "0x6003FD1")]
	public void RefreshStoreIAP()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003FD2")]
	[Obsolete]
	public void BeforePurchase(Action action, string productId = null)
	{
	}

	[Address(RVA = "0xFDFBE0", Offset = "0xFDE3E0", Length = "0x173")]
	[Token(Token = "0x6003FD3")]
	public void Purchase(string productId)
	{
	}

	[Address(RVA = "0xFDFA60", Offset = "0xFDE260", Length = "0x17F")]
	[Token(Token = "0x6003FD4")]
	public void Purchase(IAPOrder order)
	{
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0xFDFDC0", Offset = "0xFDE5C0", Length = "0x49")]
	public void Restore(string productId)
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void RestoreAll()
	{
	}

	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public bool IsStoreAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FD8")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SecondaryVerify(TransactionResult transactionResult, Action<bool> callback)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003FE7")]
	public PCStorePurchase()
	{
	}
}
