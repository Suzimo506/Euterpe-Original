using System;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x200044E")]
public class LayoutSpacing
{
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x10")]
	public float spacing;

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LayoutSpacing()
	{
	}
}
