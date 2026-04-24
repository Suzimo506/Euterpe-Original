using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.InAppPurchase.SpecialDLC;

[Token(Token = "0x20006AF")]
public class NSGetSpecialDLC : IGetSpecialDLC
{
	[Token(Token = "0x170005CC")]
	public Action<Dictionary<string, bool>> getCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6003EBD")]
		set
		{
		}
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003EBE")]
	public void Init()
	{
	}

	[Token(Token = "0x6003EBF")]
	[Address(RVA = "0x92F070", Offset = "0x92D870", Length = "0xE8")]
	public void Get()
	{
	}

	[Token(Token = "0x6003EC0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public NSGetSpecialDLC()
	{
	}
}
