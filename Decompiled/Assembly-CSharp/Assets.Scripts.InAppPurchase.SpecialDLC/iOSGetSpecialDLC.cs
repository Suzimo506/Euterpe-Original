using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006B3")]
public class iOSGetSpecialDLC : IGetSpecialDLC
{
	[Token(Token = "0x170005D0")]
	public Action<Dictionary<string, bool>> getCallback
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6003EDA")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6003ED9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Address(RVA = "0x939F50", Offset = "0x938750", Length = "0x19A")]
	[Token(Token = "0x6003EDB")]
	public void Init()
	{
	}

	[Address(RVA = "0x939F00", Offset = "0x938700", Length = "0x48")]
	[Token(Token = "0x6003EDC")]
	public void Get()
	{
	}

	[Address(RVA = "0x939D10", Offset = "0x938510", Length = "0x15E")]
	[Token(Token = "0x6003EDD")]
	private void AutoGet()
	{
	}

	[Address(RVA = "0x93A0F0", Offset = "0x9388F0", Length = "0xFF")]
	[Token(Token = "0x6003EDE")]
	private void OnReceiptDataCallBack(string receiptData)
	{
	}

	[Address(RVA = "0x939E70", Offset = "0x938670", Length = "0x81")]
	[Token(Token = "0x6003EDF")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x48040", Offset = "0x47440")]
	private IEnumerator GetCoroutine(string receiptData)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003EE0")]
	public iOSGetSpecialDLC()
	{
	}
}
