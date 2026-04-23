using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200058B")]
public struct ExchangeItem
{
	[Token(Token = "0x40020AE")]
	[FieldOffset(Offset = "0x0")]
	public int type;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40020AF")]
	public string uid;

	[Address(RVA = "0x654CC0", Offset = "0x6534C0", Length = "0x57")]
	[Token(Token = "0x6003892")]
	public override string ToString()
	{
		return null;
	}
}
