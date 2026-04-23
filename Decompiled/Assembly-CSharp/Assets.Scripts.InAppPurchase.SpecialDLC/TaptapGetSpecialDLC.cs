using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006B2")]
public class TaptapGetSpecialDLC : IGetSpecialDLC
{
	[Token(Token = "0x4002415")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsAutoGetting;

	[Token(Token = "0x170005CF")]
	public Action<Dictionary<string, bool>> getCallback
	{
		[CompilerGenerated]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6003ED3")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		set
		{
		}
	}

	[Address(RVA = "0x933A90", Offset = "0x932290", Length = "0xA8")]
	[Token(Token = "0x6003ED4")]
	public void Init()
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0x933A40", Offset = "0x932240", Length = "0x4C")]
	public void Get()
	{
	}

	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0x933B40", Offset = "0x932340", Length = "0xEF")]
	private void OnRestoreCallBack(bool arg1, TransactionResult arg2)
	{
	}

	[Address(RVA = "0x9339D0", Offset = "0x9321D0", Length = "0x65")]
	[Token(Token = "0x6003ED7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47340", Offset = "0x46740")]
	private IEnumerator GetCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0x933640", Offset = "0x931E40", Length = "0xB")]
	public TaptapGetSpecialDLC()
	{
	}
}
