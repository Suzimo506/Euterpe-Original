using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006B7")]
public abstract class IDiscountCollector
{
	[Token(Token = "0x400242A")]
	[FieldOffset(Offset = "0x18")]
	public string errorMessage;

	[Token(Token = "0x170005D2")]
	public bool isCollected
	{
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		protected set
		{
		}
	}

	[Token(Token = "0x6003EFC")]
	[Address(RVA = "0xFD8D70", Offset = "0xFD7570", Length = "0x4A")]
	public void Reset()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003EFD")]
	public abstract void Collect();

	[Token(Token = "0x6003EFE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected IDiscountCollector()
	{
	}
}
