using System;
using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D5")]
public interface IStoreListener
{
	[Token(Token = "0x170005D9")]
	bool Inited
	{
		[Token(Token = "0x6003F84")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170005DA")]
	bool IsFirstPurchase
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003F85")]
		get;
	}

	[Token(Token = "0x170005DB")]
	Product[] products
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003F86")]
		get;
	}

	[Token(Token = "0x14000068")]
	event Action<bool> onInitSucceed;

	[Token(Token = "0x14000069")]
	event Action<TransactionResult> onTransactionCompleted;

	[Token(Token = "0x1400006A")]
	event Action<bool, TransactionResult> onRestoreCompleted;

	[Token(Token = "0x1400006B")]
	event Action<string[]> onReceiptCompleted;

	[Token(Token = "0x1400006C")]
	event Action<ProductInfo[]> onReceipToProductInfos;

	[Token(Token = "0x1400006D")]
	event Action<string> onReceipDataCallback;

	[Token(Token = "0x1400006E")]
	event Action<List<ProductInfo>> onProductRefresh;

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003F87")]
	void InitStoreIAP(string[] productIds);

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0x0", Length = "0x0")]
	void RefreshStoreIAP();

	[Token(Token = "0x6003F89")]
	[Address(RVA = "0x0", Length = "0x0")]
	void BeforePurchase(Action action, string productId = null);

	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Purchase(string productId);

	[Token(Token = "0x6003F8B")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Purchase(IAPOrder order);

	[Token(Token = "0x6003F8C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Restore(string productId);

	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0x0", Length = "0x0")]
	void RestoreAll();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003F8E")]
	bool IsStoreAvailable();

	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SecondaryVerify(TransactionResult transactionResult, Action<bool> callback);
}
