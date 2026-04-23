using System;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase.PC;

[Token(Token = "0x20006DE")]
public interface IPCStoreListener
{
	[Token(Token = "0x170005F4")]
	bool IsFirstPurchase
	{
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x14000084")]
	event Action<bool, ProductInfo[]> onRestoreCompleted;

	[Token(Token = "0x6004079")]
	[Address(RVA = "0x0", Length = "0x0")]
	void CheckProductInit();

	[Token(Token = "0x600407A")]
	[Address(RVA = "0x0", Length = "0x0")]
	void PurchaseProduct(string productId);

	[Token(Token = "0x600407B")]
	[Address(RVA = "0x0", Length = "0x0")]
	void RestorePurchaseAll();

	[Token(Token = "0x600407C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Restore(string productID);
}
