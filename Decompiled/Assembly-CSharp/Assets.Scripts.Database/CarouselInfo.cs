using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x20007BA")]
public class CarouselInfo
{
	[Token(Token = "0x40028B8")]
	[FieldOffset(Offset = "0x10")]
	public string keyImg;

	[Token(Token = "0x40028B9")]
	[FieldOffset(Offset = "0x18")]
	public List<string> valueImg;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40028BA")]
	public string bgm;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004759")]
	public CarouselInfo()
	{
	}
}
