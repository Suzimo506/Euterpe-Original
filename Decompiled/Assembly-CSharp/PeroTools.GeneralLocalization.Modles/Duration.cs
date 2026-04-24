using System;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000445")]
public class Duration
{
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x10")]
	public int duration;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003262")]
	public Duration()
	{
	}
}
