using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using PeroTools2.Commons;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006B0")]
public class SpecialDLCManager : Singleton<SpecialDLCManager>
{
	[Token(Token = "0x4002411")]
	[FieldOffset(Offset = "0x10")]
	public bool isIAPCacheReady;

	[Token(Token = "0x4002412")]
	[FieldOffset(Offset = "0x18")]
	private IGetSpecialDLC m_GetSpecialDlc;

	[Token(Token = "0x170005CD")]
	public string[] specialDlcProductIds
	{
		[Address(RVA = "0x932E40", Offset = "0x931640", Length = "0x13F")]
		[Token(Token = "0x6003EC1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EC2")]
	[Address(RVA = "0x932A00", Offset = "0x931200", Length = "0xD9")]
	public void InitSpecialDLC()
	{
	}

	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0x932BD0", Offset = "0x9313D0", Length = "0xD0")]
	public void RefreshRemoteMusePlusTime()
	{
	}

	[Token(Token = "0x6003EC4")]
	[Address(RVA = "0x932B70", Offset = "0x931370", Length = "0x5D")]
	private void RefreshMusePlusTime(DateTime time)
	{
	}

	[Address(RVA = "0x932AE0", Offset = "0x9312E0", Length = "0x8E")]
	[Token(Token = "0x6003EC5")]
	public bool IsFreeToGet(string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0x9327C0", Offset = "0x930FC0", Length = "0x48")]
	[Token(Token = "0x6003EC6")]
	public void Get()
	{
	}

	[Token(Token = "0x6003EC7")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnGetCallback(Dictionary<string, bool> results)
	{
	}

	[Address(RVA = "0x932810", Offset = "0x931010", Length = "0x1EB")]
	[Token(Token = "0x6003EC8")]
	private void InitPlatforms()
	{
	}

	[Token(Token = "0x6003EC9")]
	[Address(RVA = "0x932E00", Offset = "0x931600", Length = "0x38")]
	public SpecialDLCManager()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
