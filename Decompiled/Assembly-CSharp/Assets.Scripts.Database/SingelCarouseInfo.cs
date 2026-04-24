using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x20007BB")]
public class SingelCarouseInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40028BB")]
	public List<string> imgs;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40028BC")]
	public string bgm;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40028BD")]
	public int bgmMode;

	[Token(Token = "0x40028BE")]
	[FieldOffset(Offset = "0x28")]
	public string description;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600475A")]
	public SingelCarouseInfo()
	{
	}
}
