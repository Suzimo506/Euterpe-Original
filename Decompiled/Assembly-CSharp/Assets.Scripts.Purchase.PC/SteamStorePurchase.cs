using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using Steamworks;

namespace Assets.Scripts.Purchase.PC;

[Token(Token = "0x20006E0")]
public class SteamStorePurchase : IPCStoreListener
{
	[Token(Token = "0x40024E3")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsFirstPurchase;

	[Token(Token = "0x40024E4")]
	[FieldOffset(Offset = "0x14")]
	private CSteamID m_SteamUserID;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40024E5")]
	private Dictionary<string, DateTime> m_PurchasedProduct;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40024E6")]
	protected Callback<MicroTxnAuthorizationResponse_t> m_MicroTxnAuthorizationResponse;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40024E8")]
	private bool m_IsConnect;

	[Token(Token = "0x170005F8")]
	public bool IsFirstPurchase
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6004096")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005F9")]
	private string m_Environment
	{
		[Address(RVA = "0xFE3220", Offset = "0xFE1A20", Length = "0x2B")]
		[Token(Token = "0x6004097")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000086")]
	public event Action<bool, ProductInfo[]> onRestoreCompleted
	{
		[Address(RVA = "0xFE4680", Offset = "0xFE2E80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6004098")]
		add
		{
		}
		[Address(RVA = "0xFE4720", Offset = "0xFE2F20", Length = "0x9E")]
		[Token(Token = "0x6004099")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0xFE2F10", Offset = "0xFE1710", Length = "0x178")]
	[Token(Token = "0x600409A")]
	public void CheckProductInit()
	{
	}

	[Token(Token = "0x600409B")]
	[Address(RVA = "0xFE3320", Offset = "0xFE1B20", Length = "0x19A")]
	public void PurchaseProduct(string productId)
	{
	}

	[Address(RVA = "0xFE3220", Offset = "0xFE1A20", Length = "0x2B")]
	[Token(Token = "0x600409C")]
	private string GetEnvironmentStr()
	{
		return null;
	}

	[Address(RVA = "0xFE3250", Offset = "0xFE1A50", Length = "0xCE")]
	[Token(Token = "0x600409D")]
	private string GetProductNameInLocal(string productId)
	{
		return null;
	}

	[Token(Token = "0x600409E")]
	[Address(RVA = "0xFE3320", Offset = "0xFE1B20", Length = "0x19A")]
	private void OnCheckOwnerPurchase(string productID)
	{
	}

	[Address(RVA = "0xFE3900", Offset = "0xFE2100", Length = "0x2EC")]
	[Token(Token = "0x600409F")]
	private void RefreshProductIdsByRespone(JObject jObject)
	{
	}

	[Token(Token = "0x60040A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x63970", Offset = "0x62D70")]
	[Address(RVA = "0xFE3730", Offset = "0xFE1F30", Length = "0x81")]
	private IEnumerator OnStartPurchase(string productID)
	{
		return null;
	}

	[Token(Token = "0x60040A1")]
	[Address(RVA = "0xFE34C0", Offset = "0xFE1CC0", Length = "0x1D6")]
	private void OnMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t pCallback)
	{
	}

	[Address(RVA = "0xFE36A0", Offset = "0xFE1EA0", Length = "0x81")]
	[Token(Token = "0x60040A2")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x63C00", Offset = "0x63000")]
	private IEnumerator OnQueryComfirmOrder(string orderID)
	{
		return null;
	}

	[Address(RVA = "0xFE3C60", Offset = "0xFE2460", Length = "0xAD")]
	[Token(Token = "0x60040A3")]
	public void RestorePurchaseAll()
	{
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0xFE3090", Offset = "0xFE1890", Length = "0x181")]
	private void FirstPurchaseCheck()
	{
	}

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0xFE3BF0", Offset = "0xFE23F0", Length = "0x65")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x63EA0", Offset = "0x632A0")]
	private IEnumerator RestoreAll()
	{
		return null;
	}

	[Address(RVA = "0xFE3DA0", Offset = "0xFE25A0", Length = "0xC9")]
	[Token(Token = "0x60040A6")]
	public void Restore(string productID)
	{
	}

	[Address(RVA = "0xFE3D10", Offset = "0xFE2510", Length = "0x81")]
	[Token(Token = "0x60040A7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64010", Offset = "0x63410")]
	private IEnumerator RestorePurchase(string productID)
	{
		return null;
	}

	[Address(RVA = "0xFE44F0", Offset = "0xFE2CF0", Length = "0x43")]
	[Token(Token = "0x60040A8")]
	private void UnBlockTips(string tipText)
	{
	}

	[Token(Token = "0x60040A9")]
	[Address(RVA = "0xFE37C0", Offset = "0xFE1FC0", Length = "0x139")]
	private void OnUnLockProduct(string productId, DateTime purchasedTime)
	{
	}

	[Address(RVA = "0xFE4540", Offset = "0xFE2D40", Length = "0x132")]
	[Token(Token = "0x60040AA")]
	public SteamStorePurchase()
	{
	}
}
