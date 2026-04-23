using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI;

[Flags]
[Token(Token = "0x2000827")]
public enum MenuType
{
	[Token(Token = "0x4002A79")]
	Option = 0,
	[Token(Token = "0x4002A7A")]
	Elfin = 1,
	[Token(Token = "0x4002A7B")]
	Role = 2,
	[Token(Token = "0x4002A7C")]
	Trove = 4,
	[Token(Token = "0x4002A7D")]
	Achv = 8,
	[Token(Token = "0x4002A7E")]
	MaxIndex = 8
}
