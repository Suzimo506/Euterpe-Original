using System;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000451")]
public class RectTramPos
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017A6")]
	public float x;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40017A7")]
	public float y;

	[Token(Token = "0x600327A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RectTramPos()
	{
	}
}
