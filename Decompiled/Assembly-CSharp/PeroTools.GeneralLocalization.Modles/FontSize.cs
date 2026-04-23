using System;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000448")]
public class FontSize
{
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x10")]
	public int size;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40017A3")]
	public int maxSize;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003268")]
	public FontSize()
	{
	}
}
