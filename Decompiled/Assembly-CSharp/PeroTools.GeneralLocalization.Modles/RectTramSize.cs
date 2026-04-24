using System;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000454")]
public class RectTramSize
{
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x10")]
	public float width;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40017A9")]
	public float height;

	[Token(Token = "0x6003280")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RectTramSize()
	{
	}
}
