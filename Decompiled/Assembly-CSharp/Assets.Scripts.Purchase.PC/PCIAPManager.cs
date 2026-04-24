using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase.PC;

[Token(Token = "0x20006DF")]
public class PCIAPManager
{
	[Token(Token = "0x40024DE")]
	protected static PCIAPManager s_Instance;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024DF")]
	private IPCStoreListener m_PCStoreListener;

	[Token(Token = "0x40024E1")]
	[FieldOffset(Offset = "0x20")]
	public List<ProductInfo> restoreProducts;

	[Token(Token = "0x40024E2")]
	[FieldOffset(Offset = "0x28")]
	private Product[] m_Products;

	[Token(Token = "0x170005F5")]
	public static PCIAPManager instance
	{
		[Address(RVA = "0xFDF980", Offset = "0xFDE180", Length = "0x35")]
		[Token(Token = "0x600407D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F6")]
	public bool isInited
	{
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x4D3F40", Offset = "0x4D2740", Length = "0x9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005F7")]
	public bool isHasHandler
	{
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x4D3F40", Offset = "0x4D2740", Length = "0x9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000085")]
	public event Action<bool, ProductInfo[]> onRestoreCompleted
	{
		[CompilerGenerated]
		[Token(Token = "0x600407F")]
		[Address(RVA = "0xFDF8E0", Offset = "0xFDE0E0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004080")]
		[Address(RVA = "0xFDF9C0", Offset = "0xFDE1C0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x600407E")]
	[Address(RVA = "0xFDF770", Offset = "0xFDDF70", Length = "0x16C")]
	public PCIAPManager()
	{
	}

	[Token(Token = "0x6004083")]
	[Address(RVA = "0xFDE630", Offset = "0xFDCE30", Length = "0x301")]
	public void Init()
	{
	}

	[Address(RVA = "0xFDE9E0", Offset = "0xFDD1E0", Length = "0x48")]
	[Token(Token = "0x6004084")]
	public bool IsPlayerFirstFirstPurchased()
	{
		return default(bool);
	}

	[Address(RVA = "0xFDEAE0", Offset = "0xFDD2E0", Length = "0x1DB")]
	[Token(Token = "0x6004085")]
	public void RefreshAllProductsInfo(string[] productIds)
	{
	}

	[Address(RVA = "0xFDECC0", Offset = "0xFDD4C0", Length = "0xF")]
	[Token(Token = "0x6004086")]
	public void RefreshStoreIAP()
	{
	}

	[Address(RVA = "0xFDE430", Offset = "0xFDCC30", Length = "0x1FF")]
	[Token(Token = "0x6004087")]
	private void InitProductPCIAPProductInfos()
	{
	}

	[Token(Token = "0x6004088")]
	[Address(RVA = "0xFDE350", Offset = "0xFDCB50", Length = "0xD1")]
	private void InitEvents()
	{
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
	private void SetStoreHandler(IPCStoreListener handler)
	{
	}

	[Token(Token = "0x600408A")]
	[Address(RVA = "0xFDE000", Offset = "0xFDC800", Length = "0x15D")]
	private IPCStoreListener GetCurrentHandler()
	{
		return null;
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0xFDDF20", Offset = "0xFDC720", Length = "0xDE")]
	public void CheckStoreInitAndRestore()
	{
	}

	[Address(RVA = "0xFDECD0", Offset = "0xFDD4D0", Length = "0xA0")]
	[Token(Token = "0x600408C")]
	private void RestoreAllPurchase()
	{
	}

	[Address(RVA = "0xFDE940", Offset = "0xFDD140", Length = "0x4D")]
	[Token(Token = "0x600408D")]
	private int IsHasJustAsPlannedInt()
	{
		return default(int);
	}

	[Token(Token = "0x600408E")]
	[Address(RVA = "0xFDE990", Offset = "0xFDD190", Length = "0x43")]
	public bool IsHasJustAsPlanned()
	{
		return default(bool);
	}

	[Token(Token = "0x600408F")]
	[Address(RVA = "0xFDF020", Offset = "0xFDD820", Length = "0x7F")]
	public void Restore(string productId)
	{
	}

	[Address(RVA = "0xFDF0A0", Offset = "0xFDD8A0", Length = "0x11C")]
	[Token(Token = "0x6004090")]
	public bool TryGetProduct(string productId, out Product product)
	{
		product = null;
		return default(bool);
	}

	[Token(Token = "0x6004091")]
	[Address(RVA = "0xFDEA30", Offset = "0xFDD230", Length = "0xAB")]
	public void PurchaseProduct(string productID)
	{
	}

	[Token(Token = "0x6004092")]
	[Address(RVA = "0xFDE2F0", Offset = "0xFDCAF0", Length = "0x55")]
	private string GetThirdPlatformID()
	{
		return null;
	}

	[Address(RVA = "0xFDED70", Offset = "0xFDD570", Length = "0x2A2")]
	[Token(Token = "0x6004093")]
	private void RestoreCompletedCheck(bool isSuccessful, ProductInfo[] productInfos)
	{
	}

	[Address(RVA = "0xFDE160", Offset = "0xFDC960", Length = "0x18A")]
	[Token(Token = "0x6004094")]
	public string GetLoaclLanguage()
	{
		return null;
	}
}
