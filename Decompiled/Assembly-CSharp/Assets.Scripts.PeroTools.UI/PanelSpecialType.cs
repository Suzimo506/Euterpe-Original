using System;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B3")]
[Flags]
public enum PanelSpecialType
{
	[Token(Token = "0x400214C")]
	None = 0,
	[Token(Token = "0x400214D")]
	Popup = 1,
	[Token(Token = "0x400214E")]
	IgnoreStack = 2
}
