using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x200087D")]
[Flags]
public enum ButtonType
{
	[Token(Token = "0x4002C4C")]
	None = 0,
	[Token(Token = "0x4002C4D")]
	Yes = 1,
	[Token(Token = "0x4002C4E")]
	No = 2,
	[Token(Token = "0x4002C4F")]
	Cancel = 4,
	[Token(Token = "0x4002C50")]
	Help = 8
}
