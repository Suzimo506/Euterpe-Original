using System;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x200044B")]
public class FontType
{
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x10")]
	public Font font;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600326E")]
	public FontType()
	{
	}
}
