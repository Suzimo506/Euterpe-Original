using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Steamworks;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006B1")]
public class SteamGetSpecialDLC : IGetSpecialDLC
{
	[Token(Token = "0x4002413")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsAutoGetting;

	[Token(Token = "0x170005CE")]
	public Action<Dictionary<string, bool>> getCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6003ECD")]
	[Address(RVA = "0x933500", Offset = "0x931D00", Length = "0x139")]
	public void Init()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003ECE")]
	public void Get()
	{
	}

	[Address(RVA = "0x933490", Offset = "0x931C90", Length = "0x65")]
	[Token(Token = "0x6003ECF")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x45310", Offset = "0x44710")]
	private IEnumerator GetCoroutine()
	{
		return null;
	}

	[Address(RVA = "0x51B480", Offset = "0x519C80", Length = "0x7")]
	[Token(Token = "0x6003ED0")]
	private CSteamID GetSteamUserID()
	{
		return default(CSteamID);
	}

	[Address(RVA = "0x933640", Offset = "0x931E40", Length = "0xB")]
	[Token(Token = "0x6003ED1")]
	public SteamGetSpecialDLC()
	{
	}
}
