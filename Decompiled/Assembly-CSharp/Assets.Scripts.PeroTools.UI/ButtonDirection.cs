using System;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B4")]
[Flags]
public enum ButtonDirection
{
	[Token(Token = "0x4002150")]
	None = 0,
	[Token(Token = "0x4002151")]
	Up = 1,
	[Token(Token = "0x4002152")]
	Down = 2,
	[Token(Token = "0x4002153")]
	Left = 4,
	[Token(Token = "0x4002154")]
	Right = 8,
	[Token(Token = "0x4002155")]
	Count = 5
}
